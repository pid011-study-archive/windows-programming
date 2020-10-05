using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Color color = Color.FromArgb(0, 0, 0);
            Color color2 = Color.FromArgb(0x78FFFFFF);
            SolidBrush b = new SolidBrush(color2);
            e.Graphics.FillEllipse(b, 50, 50, 150, 100);
        }
    }
}
