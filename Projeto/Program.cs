using DimStock.Models;
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

            if (AppSettingModel.GetAppSettingsState() == true)
            {
                Application.Run(new HomeScreenForm());
            }
            else
            {
                Application.Run(new AppSettingsForm());
            }
        }
    }
}
