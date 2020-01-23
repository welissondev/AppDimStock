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
using DimStock.AppSettings;

namespace DimStock.AppSettings
{
    public partial class MainConfigurationForm : Form
    {
        public static MainConfigurationForm He {get;set;}

        public MainConfigurationForm()
        {
            InitializeComponent();
        }

        private void MainConfigurationForm_Load(object sender, EventArgs e)
        {
            He = this;

            this.WindowState = FormWindowState.Maximized;

            var form = new ConfigurationDefinationForm
            {
                FormBorderStyle = FormBorderStyle.None,
                MdiParent = this,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false              
            };
            form.Show();
        }
    }
}
