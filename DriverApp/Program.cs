using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDriverPresenter driverPresenter = new DriverPresenter();
            LoginForm loginForm = new LoginForm(driverPresenter);

            DialogResult result = loginForm.ShowDialog();
            if (DialogResult.OK == result)
            {
                Application.Run(new DriverAppForm(driverPresenter));
            }
        }
    }
}
