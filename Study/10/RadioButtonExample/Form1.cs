using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioButtonExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }
    }
}
