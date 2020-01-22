using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DimStock.Auxiliary;

namespace DimStock.ViewSettings
{
    public partial class ConfigurationDefinationForm : Form
    {
        public ConfigurationDefinationForm()
        {
            InitializeComponent();
        }

        private void StartNewConfiguration_Click(object sender, EventArgs e)
        {
            FormAssistant.CloseAllForms();

            var form = new DirectoryDefinationForm
            {
                MdiParent = MainConfigurationForm.He,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false
            };

            form.Show();
        }
    }
}
