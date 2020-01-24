using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class AppConfigHomeScreenForm : Form
    {
        public AppConfigHomeScreenForm()
        {
            InitializeComponent();
        }

        public static AppConfigHomeScreenForm He { get; set; }

        private void AppConfigHomeScreenForm_Load(object sender, EventArgs e)
        {
            He = this;

            AppConfigTypeForm.ShowForm();
        }
    }
}
