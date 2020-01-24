using DimStock.Properties;
using System;
using System.Windows.Forms;
using DimStock.Business;

namespace DimStock.UserForms
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            //Settings.Default.Reset();

            if (AppConfigDirectory.GetAppSettingsState() == false)
            {
                Application.Run(new AppConfigHomeScreenForm());
            }
            else
            {
                Application.Run(new UserLoginForm());
            }
        }

    }
}
