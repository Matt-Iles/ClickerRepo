using System.Runtime.InteropServices.JavaScript;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clicker
{
    public partial class Form1 : Form
    {

        private readonly GameState _game = new GameState();
        private readonly Style _style = new Style();


        public Form1()
        {
            InitializeComponent();
            RefreshUi();

            //Round button corners
            //Make rounded corners(15px radius)
            _style.StyleButton(upgradeButton1, Color.DarkGray);
            _style.StyleButton(upgradeButton2, Color.DarkGray);
            _style.StyleButton(upgradeButton3, Color.DarkGray);
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

        private void upgradeButton1_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyClickPower();

            if (bought)
            {
                // Play message to confirm purchase
                System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }

        private void upgradeButton2_Click(object sender, EventArgs e)
        {
            bool bought = _game.TryBuyAutoClickerTier(0);

            if (bought)
            {
                // Play message to confirm purchase
                System.Media.SystemSounds.Exclamation.Play();
            }
            RefreshUi();
        }
        private void upgradeButton3_Click(object sender, EventArgs e)
        {

        }


        private void RefreshUi()
        {
            // Points display
            pointsLabel.Text = $"Cookies: {_game.Points:N0}";

            //Points per click
            pointsPerClickLabel.Text = $"Click me! (+{_game.PointsPerClick:N0} Cookies)";

            //Clicks per Sec
            clicksPerSecLabel.Text = $"Auto-Clicks/sec: {_game.AutoClickers * _game.PointsPerAutoClickPerUnit}";

            // Click power upgrade
            upgradeLabel1.Text = $"Click Power (Lv {_game.ClickPowerLevel}) – Cost: {_game.GetClickPowerCost():N0}";

            // AutoClicker upgrade label
            upgradeLabel2.Text = $"Level 1 Auto-Clicker (x{_game.AutoClickers}) – Cost: {_game.GetAutoClickerCostAt(0):N0}";

            upgradeLabel3.Text = $"Level 2 Auto-Clicker (x{_game.AutoClickers}) – Cost: {_game.GetAutoClickerCostAt(1):N0}";


            // Cache affordability checks
            bool canBuyClickPower = _game.Points >= _game.GetClickPowerCost();
            bool canBuyAutoClicker = _game.Points >= _game.GetAutoClickerCostAt(0);
            bool canBuyAutoClicker2 = _game.Points >= _game.GetAutoClickerCostAt(1);


            // Enable/disable buttons
            upgradeButton1.Enabled = canBuyClickPower;
            upgradeButton2.Enabled = canBuyAutoClicker;
            upgradeButton3.Enabled = canBuyAutoClicker2;

            // Set BackColor using ternary operator
            upgradeButton1.BackColor = canBuyClickPower ? Color.White : Color.DarkGray;
            upgradeButton2.BackColor = canBuyAutoClicker ? Color.White : Color.DarkGray;
            upgradeButton3.BackColor = canBuyAutoClicker2 ? Color.White : Color.DarkGray;
        }
        

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var dialog = new ConfirmReset("Reset game?", "Reset Game");

            if (dialog.ShowDialog() == DialogResult.OK && dialog.UserConfirmed)
            {
                _game.Reset();
                RefreshUi();
            }
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ConfirmReset("Exit Game?", "Exit Game");

            if (dialog.ShowDialog() == DialogResult.OK && dialog.UserConfirmed)
            {
                Close();
            }
        }
    }
}
