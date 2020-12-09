using System;
using System.Windows.Forms;

namespace ShootingStar
{
    internal static class Program
    {
        public const int Width = 650;
        public const int Height = 900;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm.Instance);
        }
    }
}
