using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductCategoryRegistrationForm : Form
    {
        public int Id = 0;

        public ProductCategoryRegistrationForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id > 0)
                {
                    Modify();
                }
                else
                {
                    Register();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            CallAllResets();
        }

        private void Register()
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

        private void Modify()
        {
            if (ValidateData() == true)
            {
                var category = new ProductCategory()
                {
                    Description = Description.Text
                };

                if (category.Modify(Id) == false)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "ERRO");
                    return;
                }

                MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetVariables()
        {
            Id = 0;
        }

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                Description.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void CallAllResets()
        {
            ResetVariables();
            ResetControls();
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
