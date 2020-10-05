using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTimerExample
{
    public partial class Form1 : Form
    {
        Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            using(Graphics g = CreateGraphics())
            {
                g.DrawRectangle(Pens.Blue, _random.Next(600), _random.Next(400), 10, 10);
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = CreateGraphics())
                {
                    g.DrawRectangle(Pens.Red, e.X, e.Y, 10, 10);
                }
            }
        }
    }
}
