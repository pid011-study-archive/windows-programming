using System;
using System.Windows.Forms;

namespace ShootingStar
{
    public partial class MainForm : Form
    {
        public const int FormHeight = 900;
        public const int FormWidth = 650;

        /// <summary>
        /// Simgleton instance
        /// </summary>
        public static MainForm Instance { get; } = new MainForm();

        private Form _currentForm;

        private MainForm()
        {
            InitializeComponent();
            SetForm<MainMenuForm>();
        }

        public void SetForm<T>() where T : Form
        {
            if (typeof(T) == typeof(MainForm))
            {
                throw new Exception("MainForm cannot be set.");
            }

            // form 인스턴스 생성
            var form = Activator.CreateInstance<T>();

            // 테두리를 없애고 패널에 맞추기
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;

            // 이전 form과 위에서 생성한 form 교체
            var previousForm = _currentForm;
            _currentForm = form;

            container.Controls.Add(_currentForm);
            _currentForm.Show();

            if (previousForm != null)
            {
                previousForm.Close();
                GC.Collect(); // buffer, graphics같은 쓰레기 객체들 수집
            }
        }

    }
}
