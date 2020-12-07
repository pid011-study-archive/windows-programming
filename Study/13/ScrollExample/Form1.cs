using System.Drawing;
using System.Windows.Forms;

namespace ScrollExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                e.Graphics.DrawString($"{i + 1}번째 줄", Font, Brushes.Black, 5, 20 * i + AutoScrollPosition.Y);
            }
            Text = AutoScrollPosition.Y.ToString();
        }
    }
}
