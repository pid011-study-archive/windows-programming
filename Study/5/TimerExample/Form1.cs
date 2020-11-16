using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerExample
{
    public partial class Form1 : Form
    {
        private Timer _timer;
        private string _date;
        private string _time;

        public Form1()
        {
            InitializeComponent();

            _timer = new Timer
            {
                Interval = 1000
            };
            _timer.Tick += TimerEvent;
            _timer.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _timer.Dispose();
            base.OnFormClosed(e);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            _date = $"{now.Year}년 {now.Month}월 {now.Day}일";
            _time = $"{now.Hour}시 {now.Minute}분 {now.Second}초";

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(_date, Font, Brushes.Black, 10, 10);
            e.Graphics.DrawString(_time, Font, Brushes.Black, 10, 30);
        }
    }
}
