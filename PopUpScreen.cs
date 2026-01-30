using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Clicker
{
    public partial class PopUpScreen : Form
    {
        public bool UserConfirmed { get; private set; } = false;
        private readonly Style _style = new Style();

        public PopUpScreen(string message, string title = "Confirm")
        {
            InitializeComponent();
            this.Text = title;
            textLabel.Text = message;

            //Make rounded corners(15px radius)
            this.Region = Region.FromHrgn(Style.NativeMethods.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            // Style buttons
            _style.StyleButton(yesButton, Color.FromArgb(80, 180, 255));
            _style.StyleButton(noButton, Color.FromArgb(200, 200, 200));

            DropShadow();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            UserConfirmed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            UserConfirmed = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PopUpScreen_Load(object sender, EventArgs e)
        {

        }

        //window shadow
        private void DropShadow()
        {
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}