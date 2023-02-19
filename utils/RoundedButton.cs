using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace roman_numerals_net.utils
{
    public class RoundedButton : Button
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        static extern IntPtr CreateRoundedButton(int lr, int tr, int rr, int br, int we, int he);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        static extern bool DeleteObject(IntPtr hObject);

        //private int _we = 16;
        //private int _he = 16;
        private int _borderRadius = 16;

        //public int WidthEllipse { get => _we; set => _we = value; }
        //public int HeightEllipse { get => _he; set => _he = value; }

        [Category("Rounded button")]
        public int BorderRadius { get => _borderRadius; set => _borderRadius = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = CreateRoundedButton(0, 0, Width, Height, BorderRadius, BorderRadius); // WidthEllipse, HeightEllipse
            Region = Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }
    }
}