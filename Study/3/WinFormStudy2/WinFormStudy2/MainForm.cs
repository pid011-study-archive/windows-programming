using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormStudy2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            MessageBox.Show($"{SystemInformation.PowerStatus.BatteryLifePercent}", "메시지박스", MessageBoxButtons.OKCancel);
        }
    }
}
