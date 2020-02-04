using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DimStock.Auxiliarys;
using DimStock.Business;

namespace DimStock.UserForms
{
    public partial class ProductCategoryRegistrationForm : Form
    {
        public ProductCategoryRegistrationForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == true)
                {
                    var category = new ProductCategory()
                    {
                        Description = Description.Text
                    };

                    if (category.Register() == false)
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "ERRO");
                        return;
                    }

                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Description.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            Description.Text = string.Empty;
        }

        private bool ValidateData()
        {
            if (Description.Text == string.Empty || Description.Text == null)
            {
                MessageBox.Show("Descreva a categoria!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
