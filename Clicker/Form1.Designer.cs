namespace Clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clickButton = new Button();
            titleLabel = new Label();
            pointsLabel = new Label();
            headerGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            upgradesPage = new GroupBox();
            maxButton3 = new Button();
            upgradeButton3 = new Button();
            upgradeLabel3 = new Label();
            maxButton2 = new Button();
            upgradeButton2 = new Button();
            upgradeLabel2 = new Label();
            maxButton1 = new Button();
            maxButton0 = new Button();
            maxClickPowerButton0 = new Button();
            upgradeButton1 = new Button();
            upgradeLabel1 = new Label();
            upgradeButton0 = new Button();
            upgradeClickPowerButton0 = new Button();
            upgradeLabel0 = new Label();
            upgradeClickerLabel = new Label();
            upgradeLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            clicksPerSecLabel = new Label();
            pointsPerClickLabel = new Label();
            menuStrip1 = new MenuStrip();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            resetGameToolStripMenuItem = new ToolStripMenuItem();
            headerGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            upgradesPage.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Font = new Font("Segoe UI", 15F);
            clickButton.Location = new Point(428, 188);
            clickButton.Margin = new Padding(3, 2, 3, 2);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(161, 72);
            clickButton.TabIndex = 0;
            clickButton.Text = "Click me";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F);
            titleLabel.Location = new Point(10, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(126, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Clicker Game";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Segoe UI", 12F);
            pointsLabel.Location = new Point(10, 68);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(55, 21);
            pointsLabel.TabIndex = 2;
            pointsLabel.Text = "Points:";
            // 
            // headerGroupBox
            // 
            headerGroupBox.Controls.Add(pointsLabel);
            headerGroupBox.Controls.Add(titleLabel);
            headerGroupBox.Cursor = Cursors.IBeam;
            headerGroupBox.ForeColor = SystemColors.ControlText;
            headerGroupBox.Location = new Point(10, 26);
            headerGroupBox.Margin = new Padding(3, 2, 3, 2);
            headerGroupBox.Name = "headerGroupBox";
            headerGroupBox.Padding = new Padding(3, 2, 3, 2);
            headerGroupBox.Size = new Size(394, 122);
            headerGroupBox.TabIndex = 3;
            headerGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(upgradesPage);
            groupBox1.Controls.Add(upgradeLabel);
            groupBox1.Location = new Point(594, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(420, 445);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // upgradesPage
            // 
            upgradesPage.Controls.Add(maxButton3);
            upgradesPage.Controls.Add(upgradeButton3);
            upgradesPage.Controls.Add(upgradeLabel3);
            upgradesPage.Controls.Add(maxButton2);
            upgradesPage.Controls.Add(upgradeButton2);
            upgradesPage.Controls.Add(upgradeLabel2);
            upgradesPage.Controls.Add(maxButton1);
            upgradesPage.Controls.Add(maxButton0);
            upgradesPage.Controls.Add(maxClickPowerButton0);
            upgradesPage.Controls.Add(upgradeButton1);
            upgradesPage.Controls.Add(upgradeLabel1);
            upgradesPage.Controls.Add(upgradeButton0);
            upgradesPage.Controls.Add(upgradeClickPowerButton0);
            upgradesPage.Controls.Add(upgradeLabel0);
            upgradesPage.Controls.Add(upgradeClickerLabel);
            upgradesPage.Location = new Point(14, 57);
            upgradesPage.Margin = new Padding(3, 2, 3, 2);
            upgradesPage.Name = "upgradesPage";
            upgradesPage.Padding = new Padding(3, 2, 3, 2);
            upgradesPage.Size = new Size(406, 400);
            upgradesPage.TabIndex = 1;
            upgradesPage.TabStop = false;
            // 
            // maxButton3
            // 
            maxButton3.Location = new Point(321, 174);
            maxButton3.Margin = new Padding(3, 2, 3, 2);
            maxButton3.Name = "maxButton3";
            maxButton3.Size = new Size(80, 24);
            maxButton3.TabIndex = 14;
            maxButton3.Text = "MAX";
            maxButton3.UseVisualStyleBackColor = true;
            maxButton3.Click += maxButton3_Click;
            // 
            // upgradeButton3
            // 
            upgradeButton3.Location = new Point(268, 174);
            upgradeButton3.Margin = new Padding(3, 2, 3, 2);
            upgradeButton3.Name = "upgradeButton3";
            upgradeButton3.Size = new Size(47, 24);
            upgradeButton3.TabIndex = 13;
            upgradeButton3.Text = "BUY";
            upgradeButton3.UseVisualStyleBackColor = true;
            upgradeButton3.Click += upgradeButton3_Click;
            // 
            // upgradeLabel3
            // 
            upgradeLabel3.AutoSize = true;
            upgradeLabel3.Font = new Font("Segoe UI", 10F);
            upgradeLabel3.Location = new Point(6, 174);
            upgradeLabel3.Name = "upgradeLabel3";
            upgradeLabel3.Size = new Size(70, 19);
            upgradeLabel3.TabIndex = 12;
            upgradeLabel3.Text = "Upgrade3";
            // 
            // maxButton2
            // 
            maxButton2.Location = new Point(321, 139);
            maxButton2.Margin = new Padding(3, 2, 3, 2);
            maxButton2.Name = "maxButton2";
            maxButton2.Size = new Size(80, 24);
            maxButton2.TabIndex = 11;
            maxButton2.Text = "MAX";
            maxButton2.UseVisualStyleBackColor = true;
            maxButton2.Click += maxButton2_Click;
            // 
            // upgradeButton2
            // 
            upgradeButton2.Location = new Point(268, 139);
            upgradeButton2.Margin = new Padding(3, 2, 3, 2);
            upgradeButton2.Name = "upgradeButton2";
            upgradeButton2.Size = new Size(47, 24);
            upgradeButton2.TabIndex = 10;
            upgradeButton2.Text = "BUY";
            upgradeButton2.UseVisualStyleBackColor = true;
            upgradeButton2.Click += upgradeButton2_Click;
            // 
            // upgradeLabel2
            // 
            upgradeLabel2.AutoSize = true;
            upgradeLabel2.Font = new Font("Segoe UI", 10F);
            upgradeLabel2.Location = new Point(6, 139);
            upgradeLabel2.Name = "upgradeLabel2";
            upgradeLabel2.Size = new Size(70, 19);
            upgradeLabel2.TabIndex = 9;
            upgradeLabel2.Text = "Upgrade2";
            // 
            // maxButton1
            // 
            maxButton1.Location = new Point(321, 104);
            maxButton1.Margin = new Padding(3, 2, 3, 2);
            maxButton1.Name = "maxButton1";
            maxButton1.Size = new Size(80, 24);
            maxButton1.TabIndex = 8;
            maxButton1.Text = "MAX";
            maxButton1.UseVisualStyleBackColor = true;
            maxButton1.Click += maxButton1_Click;
            // 
            // maxButton0
            // 
            maxButton0.Location = new Point(321, 69);
            maxButton0.Margin = new Padding(3, 2, 3, 2);
            maxButton0.Name = "maxButton0";
            maxButton0.Size = new Size(80, 24);
            maxButton0.TabIndex = 7;
            maxButton0.Text = "MAX";
            maxButton0.UseVisualStyleBackColor = true;
            maxButton0.Click += maxButton0_Click;
            // 
            // maxClickPowerButton0
            // 
            maxClickPowerButton0.Location = new Point(321, 34);
            maxClickPowerButton0.Margin = new Padding(3, 2, 3, 2);
            maxClickPowerButton0.Name = "maxClickPowerButton0";
            maxClickPowerButton0.Size = new Size(80, 24);
            maxClickPowerButton0.TabIndex = 6;
            maxClickPowerButton0.Text = "MAX";
            maxClickPowerButton0.UseVisualStyleBackColor = true;
            maxClickPowerButton0.Click += maxButtonClickPower_Click;
            // 
            // upgradeButton1
            // 
            upgradeButton1.Location = new Point(268, 104);
            upgradeButton1.Margin = new Padding(3, 2, 3, 2);
            upgradeButton1.Name = "upgradeButton1";
            upgradeButton1.Size = new Size(47, 24);
            upgradeButton1.TabIndex = 5;
            upgradeButton1.Text = "BUY";
            upgradeButton1.UseVisualStyleBackColor = true;
            upgradeButton1.Click += upgradeButton1_Click;
            // 
            // upgradeLabel1
            // 
            upgradeLabel1.AutoSize = true;
            upgradeLabel1.Font = new Font("Segoe UI", 10F);
            upgradeLabel1.Location = new Point(6, 104);
            upgradeLabel1.Name = "upgradeLabel1";
            upgradeLabel1.Size = new Size(70, 19);
            upgradeLabel1.TabIndex = 4;
            upgradeLabel1.Text = "Upgrade1";
            // 
            // upgradeButton0
            // 
            upgradeButton0.Location = new Point(268, 69);
            upgradeButton0.Margin = new Padding(3, 2, 3, 2);
            upgradeButton0.Name = "upgradeButton0";
            upgradeButton0.Size = new Size(47, 24);
            upgradeButton0.TabIndex = 3;
            upgradeButton0.Text = "BUY";
            upgradeButton0.UseVisualStyleBackColor = true;
            upgradeButton0.Click += upgradeButton0_Click;
            // 
            // upgradeClickPowerButton0
            // 
            upgradeClickPowerButton0.Location = new Point(268, 34);
            upgradeClickPowerButton0.Margin = new Padding(3, 2, 3, 2);
            upgradeClickPowerButton0.Name = "upgradeClickPowerButton0";
            upgradeClickPowerButton0.Size = new Size(47, 24);
            upgradeClickPowerButton0.TabIndex = 2;
            upgradeClickPowerButton0.Text = "BUY";
            upgradeClickPowerButton0.UseVisualStyleBackColor = true;
            upgradeClickPowerButton0.Click += upgradeClickPowerButton_Click;
            // 
            // upgradeLabel0
            // 
            upgradeLabel0.AutoSize = true;
            upgradeLabel0.Font = new Font("Segoe UI", 10F);
            upgradeLabel0.Location = new Point(6, 69);
            upgradeLabel0.Name = "upgradeLabel0";
            upgradeLabel0.Size = new Size(70, 19);
            upgradeLabel0.TabIndex = 1;
            upgradeLabel0.Text = "Upgrade0";
            // 
            // upgradeClickerLabel
            // 
            upgradeClickerLabel.AutoSize = true;
            upgradeClickerLabel.Font = new Font("Segoe UI", 10F);
            upgradeClickerLabel.Location = new Point(6, 34);
            upgradeClickerLabel.Name = "upgradeClickerLabel";
            upgradeClickerLabel.Size = new Size(106, 19);
            upgradeClickerLabel.TabIndex = 0;
            upgradeClickerLabel.Text = "Clicker Upgrade";
            // 
            // upgradeLabel
            // 
            upgradeLabel.AutoSize = true;
            upgradeLabel.Font = new Font("Segoe UI", 15F);
            upgradeLabel.Location = new Point(14, 17);
            upgradeLabel.Name = "upgradeLabel";
            upgradeLabel.Size = new Size(97, 28);
            upgradeLabel.TabIndex = 0;
            upgradeLabel.Text = "Upgrades";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // clicksPerSecLabel
            // 
            clicksPerSecLabel.AutoSize = true;
            clicksPerSecLabel.Location = new Point(428, 289);
            clicksPerSecLabel.Name = "clicksPerSecLabel";
            clicksPerSecLabel.Size = new Size(132, 15);
            clicksPerSecLabel.TabIndex = 5;
            clicksPerSecLabel.Text = "Auto Clicks Per Second:";
            // 
            // pointsPerClickLabel
            // 
            pointsPerClickLabel.AutoSize = true;
            pointsPerClickLabel.Location = new Point(428, 262);
            pointsPerClickLabel.Name = "pointsPerClickLabel";
            pointsPerClickLabel.Size = new Size(92, 15);
            pointsPerClickLabel.TabIndex = 6;
            pointsPerClickLabel.Text = "Points Per Click:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitGameToolStripMenuItem, resetGameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1014, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(71, 20);
            exitGameToolStripMenuItem.Text = "Exit Game";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // resetGameToolStripMenuItem
            // 
            resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            resetGameToolStripMenuItem.Size = new Size(81, 20);
            resetGameToolStripMenuItem.Text = "Reset Game";
            resetGameToolStripMenuItem.Click += resetGameToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 499);
            Controls.Add(pointsPerClickLabel);
            Controls.Add(clicksPerSecLabel);
            Controls.Add(groupBox1);
            Controls.Add(headerGroupBox);
            Controls.Add(clickButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            headerGroupBox.ResumeLayout(false);
            headerGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            upgradesPage.ResumeLayout(false);
            upgradesPage.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickButton;
        private Label titleLabel;
        private Label pointsLabel;
        private GroupBox headerGroupBox;
        private GroupBox groupBox1;
        private GroupBox upgradesPage;
        private Label upgradeLabel;
        private Button upgradeButton0;
        private Button upgradeClickPowerButton0;
        private Label upgradeLabel0;
        private Label upgradeClickerLabel;
        private Button upgradeButton1;
        private Label upgradeLabel1;
        private System.Windows.Forms.Timer gameTimer;
        private Label clicksPerSecLabel;
        private Label pointsPerClickLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resetGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private Button maxButton1;
        private Button maxButton0;
        private Button maxClickPowerButton0;
        private Button maxButton2;
        private Button upgradeButton2;
        private Label upgradeLabel2;
        private Button maxButton3;
        private Button upgradeButton3;
        private Label upgradeLabel3;
    }
}
