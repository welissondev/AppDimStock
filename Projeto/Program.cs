using DimStock.Business;
using DimStock.Properties;
using System;
using System.Windows.Forms;

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

            if (AppConfig.GetAppSettingsState() == true)
            {
                Application.Run(new UserLoginForm());
                Settings.Default.Reset();
            }
            else
            {
                Application.Run(new AppConfigForm());
            }
        }
    }
}
