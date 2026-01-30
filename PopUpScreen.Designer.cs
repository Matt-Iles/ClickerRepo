namespace Clicker
{
    partial class PopUpScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textLabel = new Label();
            noButton = new Button();
            yesButton = new Button();
            SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.Dock = DockStyle.Top;
            textLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel.Location = new Point(0, 0);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(358, 80);
            textLabel.TabIndex = 0;
            textLabel.Text = "Text";
            textLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noButton
            // 
            noButton.Location = new Point(59, 91);
            noButton.Name = "noButton";
            noButton.Size = new Size(100, 35);
            noButton.TabIndex = 1;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(204, 91);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(100, 35);
            yesButton.TabIndex = 2;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // PopUpScreen  
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(358, 155);
            Controls.Add(yesButton);
            Controls.Add(noButton);
            Controls.Add(textLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PopUpScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PopUpScreen";
            Load += PopUpScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label textLabel;
        private Button noButton;
        private Button yesButton;
    }
}