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

                //Check that all upgrade buttons are disabled and grey before setting points
                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    //  get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"upgradeButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
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

                foreach (var upgradeIndex in new[] { 0, 1, 2, 3 })
                {
                    // get the private button field and verify state
                    var btnField = typeof(Form1).GetField($"upgradeButton{upgradeIndex}", BindingFlags.Instance | BindingFlags.NonPublic);
                    var btn = (Button?)btnField!.GetValue(form);
                    Assert.NotNull(btn);
                    Assert.True(btn!.Enabled);
                    Assert.Equal(Color.White, btn.BackColor);
                }
               
                form.Close();
            });
        }
    }
}