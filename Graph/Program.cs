using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
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
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Exception);
            Application.Run(new Form1());
        }
        private static void Exception(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message.ToString() + "\n\n\n" + e.Exception.ToString(), "ОШИБКА");
        }
    }
}
