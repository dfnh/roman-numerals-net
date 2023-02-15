using System;
using System.Threading;
using System.Windows.Forms;

namespace roman_numerals_net
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalException);
            Application.Run(new Form1());
        }

        private static void GlobalException(object sender, ThreadExceptionEventArgs e)
        {
#if DEBUG
            MessageBox.Show(e.Exception.ToString(), "error occurred");
#else
            MessageBox.Show(e.Exception?.Message.ToString() ?? "some error", "error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
        }
    }
}