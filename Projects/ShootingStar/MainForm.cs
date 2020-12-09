using System;
using System.Windows.Forms;

namespace ShootingStar
{
    public partial class MainForm : Form
    {
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

            var form = Activator.CreateInstance<T>();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;

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
