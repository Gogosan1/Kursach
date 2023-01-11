using ModelMainForm.MVP.Controller;
using ModelMainForm.MVP.Model;
using System;
using System.Windows.Forms;

namespace ModelMainForm
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var salon = new HeardressingSalon();
            var controller = new MainFormController(salon);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(controller));
        }
    }
}
