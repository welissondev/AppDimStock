using System;
using System.Windows.Forms;
using DimStock.Business;

namespace DimStock.UserForms
{
    public partial class AppConfigFinalizationForm : Form
    {
        public AppConfigFinalizationForm()
        {
            InitializeComponent();
        }

        private void FinalizeSettings_Click(object sender, EventArgs e)
        {
            AppConfigDirectory.FinalizeSettings();

            UserLoginForm.ShowForm();

            AppConfigHomeScreenForm.He.Close();
        }

        public static void ShowForm()
        {
            var form = new AppConfigFinalizationForm()
            {
                MdiParent = AppConfigHomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };

            form.Show();
        }
    }
}
