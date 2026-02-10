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
            upgradeLabel = new Label();
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
            gameTimer = new System.Windows.Forms.Timer(components);
            clicksPerSecLabel = new Label();
            pointsPerClickLabel = new Label();
            menuStrip = new MenuStrip();
            exitGameToolStripMenuItem = new ToolStripMenuItem();
            resetGameToolStripMenuItem = new ToolStripMenuItem();
            maxButton4 = new Button();
            upgradeButton4 = new Button();
            upgradeLabel4 = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            clickButton.Location = new Point(428, 175);
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
            titleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            titleLabel.Location = new Point(12, 43);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(136, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Clicker Game";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Segoe UI", 12F);
            pointsLabel.Location = new Point(12, 86);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(55, 21);
            pointsLabel.TabIndex = 2;
            pointsLabel.Text = "Points:";
            // 
            // upgradeLabel
            // 
            upgradeLabel.AutoSize = true;
            upgradeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            upgradeLabel.Location = new Point(610, 34);
            upgradeLabel.Name = "upgradeLabel";
            upgradeLabel.Size = new Size(101, 28);
            upgradeLabel.TabIndex = 0;
            upgradeLabel.Text = "Upgrades";
            // 
            // maxButton3
            // 
            maxButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxButton3.Location = new Point(925, 223);
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
            upgradeButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeButton3.Location = new Point(872, 223);
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
            upgradeLabel3.Location = new Point(610, 223);
            upgradeLabel3.Name = "upgradeLabel3";
            upgradeLabel3.Size = new Size(70, 19);
            upgradeLabel3.TabIndex = 12;
            upgradeLabel3.Text = "Upgrade3";
            // 
            // maxButton2
            // 
            maxButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxButton2.Location = new Point(925, 188);
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
            upgradeButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeButton2.Location = new Point(872, 188);
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
            upgradeLabel2.Location = new Point(610, 188);
            upgradeLabel2.Name = "upgradeLabel2";
            upgradeLabel2.Size = new Size(70, 19);
            upgradeLabel2.TabIndex = 9;
            upgradeLabel2.Text = "Upgrade2";
            // 
            // maxButton1
            // 
            maxButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxButton1.Location = new Point(925, 153);
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
            maxButton0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxButton0.Location = new Point(925, 118);
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
            maxClickPowerButton0.BackColor = SystemColors.ButtonHighlight;
            maxClickPowerButton0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxClickPowerButton0.Location = new Point(925, 83);
            maxClickPowerButton0.Margin = new Padding(3, 2, 3, 2);
            maxClickPowerButton0.Name = "maxClickPowerButton0";
            maxClickPowerButton0.Size = new Size(80, 24);
            maxClickPowerButton0.TabIndex = 6;
            maxClickPowerButton0.Text = "MAX";
            maxClickPowerButton0.UseVisualStyleBackColor = false;
            maxClickPowerButton0.Click += maxButtonClickPower_Click;
            // 
            // upgradeButton1
            // 
            upgradeButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeButton1.Location = new Point(872, 153);
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
            upgradeLabel1.Location = new Point(610, 153);
            upgradeLabel1.Name = "upgradeLabel1";
            upgradeLabel1.Size = new Size(70, 19);
            upgradeLabel1.TabIndex = 4;
            upgradeLabel1.Text = "Upgrade1";
            // 
            // upgradeButton0
            // 
            upgradeButton0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeButton0.Location = new Point(872, 118);
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
            upgradeClickPowerButton0.FlatStyle = FlatStyle.System;
            upgradeClickPowerButton0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeClickPowerButton0.Location = new Point(872, 83);
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
            upgradeLabel0.Location = new Point(610, 118);
            upgradeLabel0.Name = "upgradeLabel0";
            upgradeLabel0.Size = new Size(70, 19);
            upgradeLabel0.TabIndex = 1;
            upgradeLabel0.Text = "Upgrade0";
            // 
            // upgradeClickerLabel
            // 
            upgradeClickerLabel.AutoSize = true;
            upgradeClickerLabel.Font = new Font("Segoe UI", 10F);
            upgradeClickerLabel.Location = new Point(610, 83);
            upgradeClickerLabel.Name = "upgradeClickerLabel";
            upgradeClickerLabel.Size = new Size(106, 19);
            upgradeClickerLabel.TabIndex = 0;
            upgradeClickerLabel.Text = "Clicker Upgrade";
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
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ControlDark;
            menuStrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { exitGameToolStripMenuItem, resetGameToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1014, 24);
            menuStrip.TabIndex = 7;
            menuStrip.Text = "menuStrip1";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(76, 20);
            exitGameToolStripMenuItem.Text = "Exit Game";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // resetGameToolStripMenuItem
            // 
            resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            resetGameToolStripMenuItem.Size = new Size(87, 20);
            resetGameToolStripMenuItem.Text = "Reset Game";
            resetGameToolStripMenuItem.Click += resetGameToolStripMenuItem_Click;
            // 
            // maxButton4
            // 
            maxButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            maxButton4.Location = new Point(925, 258);
            maxButton4.Margin = new Padding(3, 2, 3, 2);
            maxButton4.Name = "maxButton4";
            maxButton4.Size = new Size(80, 24);
            maxButton4.TabIndex = 17;
            maxButton4.Text = "MAX";
            maxButton4.UseVisualStyleBackColor = true;
            maxButton4.Click += maxButton4_Click;
            // 
            // upgradeButton4
            // 
            upgradeButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            upgradeButton4.Location = new Point(872, 258);
            upgradeButton4.Margin = new Padding(3, 2, 3, 2);
            upgradeButton4.Name = "upgradeButton4";
            upgradeButton4.Size = new Size(47, 24);
            upgradeButton4.TabIndex = 16;
            upgradeButton4.Text = "BUY";
            upgradeButton4.UseVisualStyleBackColor = true;
            upgradeButton4.Click += upgradeButton4_Click;
            // 
            // upgradeLabel4
            // 
            upgradeLabel4.AutoSize = true;
            upgradeLabel4.Font = new Font("Segoe UI", 10F);
            upgradeLabel4.Location = new Point(610, 258);
            upgradeLabel4.Name = "upgradeLabel4";
            upgradeLabel4.Size = new Size(70, 19);
            upgradeLabel4.TabIndex = 15;
            upgradeLabel4.Text = "Upgrade4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1014, 499);
            Controls.Add(maxButton4);
            Controls.Add(upgradeButton4);
            Controls.Add(upgradeLabel4);
            Controls.Add(pointsLabel);
            Controls.Add(upgradeLabel);
            Controls.Add(titleLabel);
            Controls.Add(maxButton3);
            Controls.Add(pointsPerClickLabel);
            Controls.Add(upgradeButton3);
            Controls.Add(clicksPerSecLabel);
            Controls.Add(upgradeLabel3);
            Controls.Add(maxButton2);
            Controls.Add(upgradeButton2);
            Controls.Add(clickButton);
            Controls.Add(upgradeLabel2);
            Controls.Add(menuStrip);
            Controls.Add(maxButton1);
            Controls.Add(upgradeLabel0);
            Controls.Add(maxButton0);
            Controls.Add(upgradeClickerLabel);
            Controls.Add(maxClickPowerButton0);
            Controls.Add(upgradeClickPowerButton0);
            Controls.Add(upgradeButton1);
            Controls.Add(upgradeButton0);
            Controls.Add(upgradeLabel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clickButton;
        private Label titleLabel;
        private Label pointsLabel;
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
        private MenuStrip menuStrip;
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
        private Button maxButton4;
        private Button upgradeButton4;
        private Label upgradeLabel4;
    }
}
