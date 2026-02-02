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
            maxButton1 = new Button();
            maxButton0 = new Button();
            upgradeButton2 = new Button();
            upgradeLabel2 = new Label();
            upgradeButton1 = new Button();
            upgradeButton0 = new Button();
            upgradeLabel1 = new Label();
            upgradeLabel0 = new Label();
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
            clickButton.Location = new Point(489, 251);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(184, 96);
            clickButton.TabIndex = 0;
            clickButton.Text = "Click me";
            clickButton.UseVisualStyleBackColor = true;
            clickButton.Click += clickButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 15F);
            titleLabel.Location = new Point(12, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(160, 35);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Clicker Game";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Font = new Font("Segoe UI", 12F);
            pointsLabel.Location = new Point(12, 91);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new Size(69, 28);
            pointsLabel.TabIndex = 2;
            pointsLabel.Text = "Points:";
            // 
            // headerGroupBox
            // 
            headerGroupBox.Controls.Add(pointsLabel);
            headerGroupBox.Controls.Add(titleLabel);
            headerGroupBox.Cursor = Cursors.IBeam;
            headerGroupBox.ForeColor = SystemColors.ControlText;
            headerGroupBox.Location = new Point(12, 35);
            headerGroupBox.Name = "headerGroupBox";
            headerGroupBox.Size = new Size(450, 162);
            headerGroupBox.TabIndex = 3;
            headerGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(upgradesPage);
            groupBox1.Controls.Add(upgradeLabel);
            groupBox1.Location = new Point(679, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 593);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // upgradesPage
            // 
            upgradesPage.Controls.Add(maxButton3);
            upgradesPage.Controls.Add(upgradeButton3);
            upgradesPage.Controls.Add(upgradeLabel3);
            upgradesPage.Controls.Add(maxButton2);
            upgradesPage.Controls.Add(maxButton1);
            upgradesPage.Controls.Add(maxButton0);
            upgradesPage.Controls.Add(upgradeButton2);
            upgradesPage.Controls.Add(upgradeLabel2);
            upgradesPage.Controls.Add(upgradeButton1);
            upgradesPage.Controls.Add(upgradeButton0);
            upgradesPage.Controls.Add(upgradeLabel1);
            upgradesPage.Controls.Add(upgradeLabel0);
            upgradesPage.Location = new Point(16, 76);
            upgradesPage.Name = "upgradesPage";
            upgradesPage.Size = new Size(464, 533);
            upgradesPage.TabIndex = 1;
            upgradesPage.TabStop = false;
            // 
            // maxButton3
            // 
            maxButton3.Location = new Point(367, 186);
            maxButton3.Name = "maxButton3";
            maxButton3.Size = new Size(91, 32);
            maxButton3.TabIndex = 11;
            maxButton3.Text = "MAX";
            maxButton3.UseVisualStyleBackColor = true;
            maxButton3.Click += maxButton3_Click;
            // 
            // upgradeButton3
            // 
            upgradeButton3.Location = new Point(306, 186);
            upgradeButton3.Name = "upgradeButton3";
            upgradeButton3.Size = new Size(54, 32);
            upgradeButton3.TabIndex = 10;
            upgradeButton3.Text = "BUY";
            upgradeButton3.UseVisualStyleBackColor = true;
            upgradeButton3.Click += upgradeButton3_Click;
            // 
            // upgradeLabel3
            // 
            upgradeLabel3.AutoSize = true;
            upgradeLabel3.Font = new Font("Segoe UI", 10F);
            upgradeLabel3.Location = new Point(6, 190);
            upgradeLabel3.Name = "upgradeLabel3";
            upgradeLabel3.Size = new Size(85, 23);
            upgradeLabel3.TabIndex = 9;
            upgradeLabel3.Text = "Upgrade3";
            // 
            // maxButton2
            // 
            maxButton2.Location = new Point(367, 136);
            maxButton2.Name = "maxButton2";
            maxButton2.Size = new Size(91, 32);
            maxButton2.TabIndex = 8;
            maxButton2.Text = "MAX";
            maxButton2.UseVisualStyleBackColor = true;
            maxButton2.Click += maxButton2_Click;
            // 
            // maxButton1
            // 
            maxButton1.Location = new Point(366, 89);
            maxButton1.Name = "maxButton1";
            maxButton1.Size = new Size(91, 32);
            maxButton1.TabIndex = 7;
            maxButton1.Text = "MAX";
            maxButton1.UseVisualStyleBackColor = true;
            maxButton1.Click += maxButton1_Click;
            // 
            // maxButton0
            // 
            maxButton0.Location = new Point(366, 42);
            maxButton0.Name = "maxButton0";
            maxButton0.Size = new Size(91, 32);
            maxButton0.TabIndex = 6;
            maxButton0.Text = "MAX";
            maxButton0.UseVisualStyleBackColor = true;
            maxButton0.Click += maxButton0_Click;
            // 
            // upgradeButton2
            // 
            upgradeButton2.Location = new Point(306, 136);
            upgradeButton2.Name = "upgradeButton2";
            upgradeButton2.Size = new Size(54, 32);
            upgradeButton2.TabIndex = 5;
            upgradeButton2.Text = "BUY";
            upgradeButton2.UseVisualStyleBackColor = true;
            upgradeButton2.Click += upgradeButton2_Click;
            // 
            // upgradeLabel2
            // 
            upgradeLabel2.AutoSize = true;
            upgradeLabel2.Font = new Font("Segoe UI", 10F);
            upgradeLabel2.Location = new Point(6, 140);
            upgradeLabel2.Name = "upgradeLabel2";
            upgradeLabel2.Size = new Size(85, 23);
            upgradeLabel2.TabIndex = 4;
            upgradeLabel2.Text = "Upgrade2";
            // 
            // upgradeButton1
            // 
            upgradeButton1.Location = new Point(306, 89);
            upgradeButton1.Name = "upgradeButton1";
            upgradeButton1.Size = new Size(54, 32);
            upgradeButton1.TabIndex = 3;
            upgradeButton1.Text = "BUY";
            upgradeButton1.UseVisualStyleBackColor = true;
            upgradeButton1.Click += upgradeButton1_Click;
            // 
            // upgradeButton0
            // 
            upgradeButton0.Location = new Point(306, 42);
            upgradeButton0.Name = "upgradeButton0";
            upgradeButton0.Size = new Size(54, 32);
            upgradeButton0.TabIndex = 2;
            upgradeButton0.Text = "BUY";
            upgradeButton0.UseVisualStyleBackColor = true;
            upgradeButton0.Click += upgradeButton0_Click;
            // 
            // upgradeLabel1
            // 
            upgradeLabel1.AutoSize = true;
            upgradeLabel1.Font = new Font("Segoe UI", 10F);
            upgradeLabel1.Location = new Point(6, 93);
            upgradeLabel1.Name = "upgradeLabel1";
            upgradeLabel1.Size = new Size(85, 23);
            upgradeLabel1.TabIndex = 1;
            upgradeLabel1.Text = "Upgrade1";
            // 
            // upgradeLabel0
            // 
            upgradeLabel0.AutoSize = true;
            upgradeLabel0.Font = new Font("Segoe UI", 10F);
            upgradeLabel0.Location = new Point(6, 46);
            upgradeLabel0.Name = "upgradeLabel0";
            upgradeLabel0.Size = new Size(85, 23);
            upgradeLabel0.TabIndex = 0;
            upgradeLabel0.Text = "Upgrade0";
            // 
            // upgradeLabel
            // 
            upgradeLabel.AutoSize = true;
            upgradeLabel.Font = new Font("Segoe UI", 15F);
            upgradeLabel.Location = new Point(16, 23);
            upgradeLabel.Name = "upgradeLabel";
            upgradeLabel.Size = new Size(123, 35);
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
            clicksPerSecLabel.Location = new Point(489, 385);
            clicksPerSecLabel.Name = "clicksPerSecLabel";
            clicksPerSecLabel.Size = new Size(162, 20);
            clicksPerSecLabel.TabIndex = 5;
            clicksPerSecLabel.Text = "Auto Clicks Per Second:";
            // 
            // pointsPerClickLabel
            // 
            pointsPerClickLabel.AutoSize = true;
            pointsPerClickLabel.Location = new Point(489, 350);
            pointsPerClickLabel.Name = "pointsPerClickLabel";
            pointsPerClickLabel.Size = new Size(110, 20);
            pointsPerClickLabel.TabIndex = 6;
            pointsPerClickLabel.Text = "Points Per Click:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitGameToolStripMenuItem, resetGameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1159, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitGameToolStripMenuItem
            // 
            exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            exitGameToolStripMenuItem.Size = new Size(90, 24);
            exitGameToolStripMenuItem.Text = "Exit Game";
            exitGameToolStripMenuItem.Click += exitGameToolStripMenuItem_Click;
            // 
            // resetGameToolStripMenuItem
            // 
            resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            resetGameToolStripMenuItem.Size = new Size(102, 24);
            resetGameToolStripMenuItem.Text = "Reset Game";
            resetGameToolStripMenuItem.Click += resetGameToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 665);
            Controls.Add(pointsPerClickLabel);
            Controls.Add(clicksPerSecLabel);
            Controls.Add(groupBox1);
            Controls.Add(headerGroupBox);
            Controls.Add(clickButton);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
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
        private Button upgradeButton1;
        private Button upgradeButton0;
        private Label upgradeLabel1;
        private Label upgradeLabel0;
        private Button upgradeButton2;
        private Label upgradeLabel2;
        private System.Windows.Forms.Timer gameTimer;
        private Label clicksPerSecLabel;
        private Label pointsPerClickLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem resetGameToolStripMenuItem;
        private ToolStripMenuItem exitGameToolStripMenuItem;
        private Button maxButton2;
        private Button maxButton1;
        private Button maxButton0;
        private Button maxButton3;
        private Button upgradeButton3;
        private Label upgradeLabel3;
    }
}
