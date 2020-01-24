using System;
using System.Windows.Forms;
using DimStock.Business;

namespace DimStock.UserForms
{
    public partial class AppConfigDirectoryForm : Form
    {
        public AppConfigDirectoryForm()
        {
            InitializeComponent();
        }

        private void ExecuteSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var appConfig = new AppConfigDirectory();

                var path = appConfig.SelectPath();

                if (path == string.Empty)
                    return;

                appConfig.SavePath(path);

                appConfig.TransferDataBase();

                appConfig.CreateFolders();

                AppConfigCompanyRegistrationForm.ShowForm();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SowForm()
        {
            var form = new AppConfigDirectoryForm()
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
