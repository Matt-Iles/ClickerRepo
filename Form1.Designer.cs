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
            clickButton = new Button();
            titleLabel = new Label();
            pointsLabel = new Label();
            headerGroupBox = new GroupBox();
            headerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // clickButton
            // 
            clickButton.Font = new Font("Segoe UI", 15F);
            clickButton.Location = new Point(463, 268);
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
            headerGroupBox.Location = new Point(12, 12);
            headerGroupBox.Name = "headerGroupBox";
            headerGroupBox.Size = new Size(450, 200);
            headerGroupBox.TabIndex = 3;
            headerGroupBox.TabStop = false;
            headerGroupBox.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 665);
            Controls.Add(headerGroupBox);
            Controls.Add(clickButton);
            Name = "Form1";
            Text = "Form1";
            headerGroupBox.ResumeLayout(false);
            headerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button clickButton;
        private Label titleLabel;
        private Label pointsLabel;
        private GroupBox headerGroupBox;
    }
}
