using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class DatabasePathDesfinationForm : Form
    {
        public DatabasePathDesfinationForm()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dirDialog = new FolderBrowserDialog())
            {
                DialogResult res = dirDialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string path = dirDialog.SelectedPath;
                    dataBasePath.Text = path;
                }
                else
                {
                }
            }
        }
    }
}
