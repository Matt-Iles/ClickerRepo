using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("Clicker.Tests")] // allowing unit tests to access internal members

namespace Clicker
{
    public partial class Form1 : Form
    {
        // P/Invoke needed to allow dragging a borderless form
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private readonly GameState _game = new GameState();
        private readonly Style _style = new Style();


        public Form1()
        {
            InitializeComponent();
            RefreshUi();

            //Round button corners
            //Make rounded corners(15px radius)
            _style.StyleButton(upgradeClickPowerButton0, Color.DarkGray);
            _style.StyleButton(upgradeButton0, Color.DarkGray);
            _style.StyleButton(upgradeButton1, Color.DarkGray);
            _style.StyleButton(upgradeButton2, Color.DarkGray);

            // allow dragging the window by clicking and dragging the form background
            this.MouseDown += Form1_MouseDown;
        }

        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // release current capture and send a message to simulate title-bar drag
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _game.AutoClickTickSmooth(0.1);
            RefreshUi();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            _game.Click();
            RefreshUi();
        }

        internal void RefreshUi()
        {
            //Initalise variables
            var upgradeTierInfos = _game.GetAutoClickerTierInfos();

            // Points display
            pointsLabel.Text = $"Cookies: {_game.Points:N0}";

            //Points per click
            pointsPerClickLabel.Text = $"Click me! (+{_game.PointsPerClick:N0} Cookies)";

            //Clicks per Sec
            clicksPerSecLabel.Text = $"Auto-Clicks/sec: {_game.GetTotalAutoClickerPointsPerSecond()}";

            // Click power upgrade
            upgradeClickerLabel.Text = $"Click Power (Lv {_game.ClickPowerLevel}) – Cost: {_game.GetClickPowerCost():N0}";

            // AutoClicker upgrade labels
            upgradeLabel0.Text = $"Level 1 Auto-Clicker (x{upgradeTierInfos[0].Count}) – Cost: {upgradeTierInfos[0].NextCost:N0}";
            upgradeLabel1.Text = $"Level 2 Auto-Clicker (x{upgradeTierInfos[1].Count}) – Cost: {upgradeTierInfos[1].NextCost:N0}";
            upgradeLabel2.Text = $"Level 3 Auto-Clicker (x{upgradeTierInfos[2].Count}) – Cost: {upgradeTierInfos[2].NextCost:N0}";
            upgradeLabel3.Text = $"Level 4 Auto-Clicker (x{upgradeTierInfos[3].Count}) – Cost: {upgradeTierInfos[3].NextCost:N0}";

            // Cache affordability checks for single buy
            bool canBuyClickPower = _game.Points >= _game.GetClickPowerCost();
            bool canBuyAutoClicker0 = _game.Points >= upgradeTierInfos[0].NextCost;
            bool canBuyAutoClicker2 = _game.Points >= upgradeTierInfos[1].NextCost;
            bool canBuyAutoClicker3 = _game.Points >= upgradeTierInfos[2].NextCost;
            bool canBuyAutoClicker4 = _game.Points >= upgradeTierInfos[3].NextCost;

            // Enable/disable buttons
            upgradeClickPowerButton0.Enabled = canBuyClickPower;
            upgradeButton0.Enabled = canBuyAutoClicker0;
            upgradeButton1.Enabled = canBuyAutoClicker2;
            upgradeButton2.Enabled = canBuyAutoClicker3;
            upgradeButton3.Enabled = canBuyAutoClicker4;

            // Set BackColor using ternary operator
            upgradeClickPowerButton0.BackColor = canBuyClickPower ? Color.White : Color.DarkGray;
            upgradeButton0.BackColor = canBuyAutoClicker0 ? Color.White : Color.DarkGray;
            upgradeButton1.BackColor = canBuyAutoClicker2 ? Color.White : Color.DarkGray;
            upgradeButton2.BackColor = canBuyAutoClicker3 ? Color.White : Color.DarkGray;
            upgradeButton3.BackColor = canBuyAutoClicker4 ? Color.White : Color.DarkGray;

            // Enable/disable buttons
            maxClickPowerButton0.Enabled = canBuyClickPower;
            maxButton0.Enabled = canBuyAutoClicker0;
            maxButton1.Enabled = canBuyAutoClicker2;
            maxButton2.Enabled = canBuyAutoClicker3;
            maxButton3.Enabled = canBuyAutoClicker4;

            // Set BackColor using ternary operator
            maxClickPowerButton0.BackColor = canBuyClickPower ? Color.White : Color.DarkGray;
            maxButton0.BackColor = canBuyAutoClicker0 ? Color.White : Color.DarkGray;
            maxButton1.BackColor = canBuyAutoClicker2 ? Color.White : Color.DarkGray;
            maxButton2.BackColor = canBuyAutoClicker3 ? Color.White : Color.DarkGray;
            maxButton3.BackColor = canBuyAutoClicker4 ? Color.White : Color.DarkGray;


            // Set max button text based on how many can be bought (empty when zero)
            int canMaxClickBuy0 = _game.CalculateMaxPurchasableClickPower();
            int canMaxBuy0 = (int)upgradeTierInfos[0].NextMaxCount;
            int canMaxBuy1 = (int)upgradeTierInfos[1].NextMaxCount;
            int canMaxBuy2 = (int)upgradeTierInfos[2].NextMaxCount;
            int canMaxBuy3 = (int)upgradeTierInfos[3].NextMaxCount;

            maxClickPowerButton0.Text = canMaxClickBuy0 > 0 ? $"MAX {canMaxClickBuy0}x" : "MAX";
            maxButton0.Text = canMaxBuy0 > 0 ? $"MAX {canMaxBuy0}x" : "MAX";
            maxButton1.Text = canMaxBuy1 > 0 ? $"MAX {canMaxBuy1}x" : "MAX";
            maxButton2.Text = canMaxBuy2 > 0 ? $"MAX {canMaxBuy2}x" : "MAX";
            maxButton3.Text = canMaxBuy3 > 0 ? $"MAX {canMaxBuy3}x" : "MAX";
        }


        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dialog = new PopUpScreen("Reset game?", "Reset Game");

            if (dialog.ShowDialog() == DialogResult.OK && dialog.UserConfirmed)
            {
                _game.Reset();
                RefreshUi();
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new PopUpScreen("Exit Game?", "Exit Game");

            if (dialog.ShowDialog() == DialogResult.OK && dialog.UserConfirmed)
            {
                Close();
            }
        }


        //-------- Upgrade Button Click Handlers --------
        private void upgradeClickPowerButton_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyClickPower();

            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void upgradeButton0_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyAutoClickerTier(0);

            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }
        private void upgradeButton1_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyAutoClickerTier(1);

            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void upgradeButton2_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyAutoClickerTier(2);

            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void upgradeButton3_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyAutoClickerTier(3);

            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        //-------- Max Upgrade Button Click Handlers --------
        private void maxButtonClickPower_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyMaxClickPower();
            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void maxButton0_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyMaxAutoClicker(0);
            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void maxButton1_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyMaxAutoClicker(1);
            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void maxButton2_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyMaxAutoClicker(2);
            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }



        private void maxButton3_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyMaxAutoClicker(3);
            if (bought)
            {
                // Play message to confirm purchase
                //System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }
    }
}
