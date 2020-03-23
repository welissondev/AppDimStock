using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductAddForm : Form
    {
        #region Builder

        public ProductAddForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private AxlDataPage pagination = new AxlDataPage();

        #endregion 

        #region Get & Set

        public int Id { get; set; }

        public int CategoryId { get; set; }

        #endregion

        #region Form

        private void ProductAddForm_Click(object sender, EventArgs e)
        {
            ListviewCategory.Visible = false;
        }

        #endregion

        #region Button

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var user = new UserLogin();
            user.GetDetail(AxlLogin.Id);

            if (Id == 0)
            {
                if (user.PermissionToRegister == false)
                {
                    MessageBox.Show("Você não tem permissão para cadastrar!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Save();
            }

            if (Id > 0)
            {
                if (user.PermissionToEdit == false)
                {
                    MessageBox.Show("Você não tem permissão para editar!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Edit();
            };
        }

        private void ButtonClearFields_Click_1(object sender, EventArgs e)
        {
            CallAllResets();
        }

        #endregion

        #region ListBox

        private void ListviewCategory_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CategoryId = Convert.ToInt32(ListviewCategory.
                SelectedItems[0].SubItems[0].Text);

                ComboBoxCategoryList.Text = ListviewCategory.
                SelectedItems[0].SubItems[1].Text;

                ListviewCategory.Visible = false;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region ComboBox

        private void ComboBoxCategoryList_Click(object sender, EventArgs e)
        {
            if (ListviewCategory.Visible == false)
            {
                if (ComboBoxCategoryList.Text == string.Empty)
                {
                    ListviewCategory.Visible = true;
                    ComboBoxCategoryList.DroppedDown = false;
                    StartSearchTimer();
                }
            }
            else
            {
                ListviewCategory.Visible = false;
            }
        }

        private void ComboBoxCategoryList_KeyPress(object sender, KeyPressEventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region LabelLink

        private void ButtonShow_GategoryRegistrationForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var categoryForm = new CategoryAddForm()
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            categoryForm.ShowDialog();
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            FillBoxCategory();
        }

        #endregion

        #region Function

        private void Save()
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var product = new Product
                {
                    InternalCode = TextInternalCode.Text,
                    Description = TextDescription.Text,
                    CostPrice = Convert.ToDouble(TextCostPrice.DecimalValue),
                    SalePrice = Convert.ToDouble(TextSalePrice.DecimalValue),
                    BarCode = TextBarCode.Text,
                };

                product.Category.Id = CategoryId;

                if (product.Save() == false)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                CallAllResets();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Edit()
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var product = new Product()
                {
                    InternalCode = TextInternalCode.Text,
                    Description = TextDescription.Text,
                    CostPrice = Convert.ToDouble(TextCostPrice.DecimalValue),
                    SalePrice = Convert.ToDouble(TextSalePrice.DecimalValue),
                    BarCode = TextBarCode.Text,
                };
                product.Category.Id = CategoryId;

                if (product.Edit(Id) == false)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private bool ValidateData()
        {
            if (CategoryId == 0)
            {
                MessageBox.Show("Informe a categoria do produto!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                ComboBoxCategoryList.Select();

                return false;
            }

            if (TextDescription.Text == string.Empty)
            {
                MessageBox.Show("Campo descrição é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextDescription.Select();

                return false;
            }

            return true;
        }

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(CurrencyTextBox))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(IntegerTextBox))
                    {
                        ctl.Text = string.Empty;
                    }
                }

                TextInternalCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetProperties()
        {
            Id = 0;
            CategoryId = 0;
        }

        private void CallAllResets()
        {
            ResetControls();
            ResetProperties();
        }

        public void FillBoxCategory()
        {
            try
            {
                var category = new Category(pagination)
                {
                    Description = ComboBoxCategoryList.Text
                };
                category.FetchData();

                ListviewCategory.Items.Clear();
                ListviewCategory.Height = 250;
                ListviewCategory.Visible = true;

                foreach (var item in category.List)
                {
                    ListviewCategory.Items.Add(new ListViewItem(
                    new string[] { item.Id.ToString(),
                    item.Description}));
                }

                PauseSearchTimer();
            }
            catch (Exception ex)
            {
                PauseSearchTimer();
                AxlException.Message.Show(ex);
            }
        }

        private void StartSearchTimer()
        {
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void PauseSearchTimer()
        {
            SearchTimer.Enabled = false;
        }

        #endregion
    }
}


