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

        private void OnScroll(object sender, ScrollEventArgs e)
        {
            button1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}
