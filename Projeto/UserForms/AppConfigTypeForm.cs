using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class AppConfigTypeForm : Form
    {
        public AppConfigTypeForm()
        {
            InitializeComponent();
        }

        private void StartNewConfiguration_Click(object sender, EventArgs e)
        {
            AppConfigDirectoryForm.SowForm();

            Close();
        }

        public static void ShowForm()
        {
            var form = new AppConfigTypeForm()
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
