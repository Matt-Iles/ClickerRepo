using System;
using System.Collections.Generic;
using System.Text;

namespace Clicker
{
    internal class Style
    {

        // Class for creating rounded corners
        public static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("gdi32.dll", SetLastError = true)]
            public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        }


        // Make buttons rounded + flat
        public void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.Black;

            btn.Region = Region.FromHrgn(Style.NativeMethods.CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 10, 10)
            );
        }
    }
}
