using System;
using System.Drawing;
using System.Windows.Forms;

namespace CheckBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OnCheckBox1Clicked(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                checkBox.Checked = !checkBox.Checked;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    BackColor = Color.Red;
                }
                else
                {
                    BackColor = Control.DefaultBackColor;
                }
            }
        }
    }
}
