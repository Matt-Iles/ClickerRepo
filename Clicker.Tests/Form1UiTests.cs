using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Clicker;
using Xunit;

namespace Clicker.Tests
{
    public class Form1UiTests
    {
        // Helper to run UI code on an STA thread and rethrow exceptions to caller
        private static void RunSta(Action action)
        {
            Exception? ex = null;
            var t = new Thread(() =>
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    ex = e;
                }
                Application.ExitThread();
            });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (ex != null) throw ex;
        }


        // Test to verify that upgrade buttons are enabled and white when affordable
        [Fact]
        public void UpgradeButtons_AreEnabledAndWhite_WhenAffordable()
        {
            RunSta(() =>
            {
                // Arrange: prepare GameState with enough points to afford tier 0
                var gs = new GameState();

                //get base cost for clicker
                long baseCostClicker = gs.ClickPowerBaseCost;

                // get base cost for tier 0 via the public info method (safer than reflecting internal list)
                var tierInfos = gs.GetAutoClickerTierInfos();
                long baseCostTier0 = tierInfos[0].NextCost;
                long baseCostTier1 = tierInfos[1].NextCost;
                long baseCostTier2 = tierInfos[2].NextCost;
                long baseCostTier3 = tierInfos[3].NextCost;

                long totalCost = baseCostClicker + baseCostTier0 + baseCostTier1 + baseCostTier2 + baseCostTier3;


                // create form and inject the desired Points into its internal GameState
                using var form = new Form1();
                var gameField = typeof(Form1).GetField("_game", BindingFlags.Instance | BindingFlags.NonPublic);
                var formGame = (GameState?)gameField!.GetValue(form) ?? throw new Xunit.Sdk.XunitException("_game was null");

                //Check that all buy upgrade buttons are disabled and grey before setting points
                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    //  get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"upgradeButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
                    var btn = (Button?)btnField!.GetValue(form);
                    Assert.NotNull(btn);
                    Assert.False(btn!.Enabled);
                    Assert.Equal(Color.DarkGray, btn.BackColor);
                }

                //Check that all upgrade buttons are disabled and grey before setting points
                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    //  get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"maxButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
                    var btn = (Button?)btnField!.GetValue(form);
                    Assert.NotNull(btn);
                    Assert.False(btn!.Enabled);
                    Assert.Equal(Color.DarkGray, btn.BackColor);
                }

                // set Points on the form's GameState
                var pointsProp = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                pointsProp!.SetValue(formGame, totalCost);

                //  call RefreshUi (private/internal) via reflection
                var refresh = typeof(Form1).GetMethod("RefreshUi", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                refresh!.Invoke(form, null);

                //Loop through all of the buy upgrade buttons and verify that they are enabled and white
                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    // get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"upgradeButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
                    var btn = (Button?)btnField!.GetValue(form);
                    Assert.NotNull(btn);
                    Assert.True(btn.Enabled);
                    Assert.Equal(Color.White, btn.BackColor);
                }

                //Loop through all of the Max buy upgrade buttons and verify that they are enabled and white
                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    // get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"maxButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
                    var btn = (Button?)btnField!.GetValue(form);
                    Assert.NotNull(btn);
                    Assert.True(btn.Enabled);
                    Assert.Equal(Color.White, btn.BackColor);
                }
                form.Close();
            });
        }

        // Test to verify that clicking Exit menu item shows PopUpScreen and closes form on confirmation
        [Fact]
        public void ExitButton_ClosesForm()
        {
            RunSta(() =>
            {
                using var form = new Form1();
                // get the private exit menu item field
                var btnField = typeof(Form1).GetField("exitGameToolStripMenuItem", BindingFlags.Instance | BindingFlags.NonPublic);
                var menuItem = (ToolStripMenuItem?)btnField!.GetValue(form);
                Assert.NotNull(menuItem);

                // trigger the menu click which shows the modal PopUpScreen
                menuItem!.PerformClick();

                bool formClosed = false;
                form.FormClosed += (s, e) => formClosed = true;

                // timer runs on the UI message loop so it can interact with the modal popup
                using var timer = new System.Windows.Forms.Timer();
                timer.Interval = 50;
                timer.Tick += (s, e) =>
                {
                    // look for the PopUpScreen in the open forms
                    for (int i = 0; i < Application.OpenForms.Count; i++)
                    {
                        if (Application.OpenForms[i] is PopUpScreen popup)
                        {
                            timer.Stop();
                            // click the popup's yesButton via reflection
                            var yesField = typeof(PopUpScreen).GetField("yesButton", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                            var yesBtn = (Button?)yesField?.GetValue(popup);
                            if (yesBtn != null)
                            {
                                yesBtn.PerformClick();
                            }
                            else
                            {
                                // fallback in case the control name differs
                                popup.DialogResult = DialogResult.OK;
                                popup.Close();
                            }
                            break;
                        }
                    }
                };
                timer.Start();

               

                // after the modal dialog is handled above, the form should close
                Assert.True(formClosed);
            });
        }
    }
}