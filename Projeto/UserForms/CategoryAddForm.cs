using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class CategoryAddForm : Form
    {
        #region Builder

        public CategoryAddForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public int Id = 0;

        #endregion

        #region Button

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Id > 0)
                {
                    Edit();
                }
                else
                {
                    Save();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            CallAllResets();
        }

        #endregion

        #region Function

        private void Save()
        {
            if (ValidateData() == true)
            {
                var category = new Category()
                {
                    Description = TextDescription.Text
                };

                if (category.Save() == false)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "ERRO");
                    return;
                }

                MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                TextDescription.Text = string.Empty;
            }
        }

        private void Edit()
        {
            if (ValidateData() == true)
            {
                var category = new Category()
                {
                    Description = TextDescription.Text
                };

                if (category.Edit(Id) == false)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "ERRO");
                    return;
                }

                MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetProperties()
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

                TextDescription.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void CallAllResets()
        {
            ResetProperties();
            ResetControls();
        }

        private bool ValidateData()
        {
            if (TextDescription.Text == string.Empty || TextDescription.Text == null)
            {
                MessageBox.Show("Descreva a categoria!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        #endregion
    }
}
