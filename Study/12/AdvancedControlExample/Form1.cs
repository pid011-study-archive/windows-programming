
using System.Windows.Forms;

namespace AdvancedControlExample
{
    public partial class Form1 : Form
    {
        private int _tick = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //for (var i = 0; i < 100; i++)
            //{
            //    progressBar1.Value = i;
            //    Thread.Sleep(30);
            //}
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            progressBar1.Value = ++_tick;

            if (_tick >= 100)
            {
                timer1.Stop();
                MessageBox.Show("작업을 완료하였습니다.");
                progressBar1.Value = 0;
                _tick = 0;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
        {
            Text = domainUpDown1.Text;
        }

        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            toolTip1.SetToolTip(label1, "레이블에 대한 툴팁");
            toolTip1.SetToolTip(trackBar1, "트랙바");
            toolTip1.SetToolTip(button1, "프로그레스 바 시작 버튼");
            toolTip1.SetToolTip(this, "메인폼");
        }
    }
}
