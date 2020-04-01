using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using System;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm : IProductAddView
    {
        public int Id { get; set; }
        public string InternalCode { get => TextInternalCode.Text; set => TextInternalCode.Text = value; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
        public double CostPrice { get => double.Parse(TextCostPrice.DecimalValue.ToString()); set => TextCostPrice.DecimalValue = decimal.Parse(value.ToString()); }
        public double SalePrice { get => double.Parse(TextSalePrice.DecimalValue.ToString()); set => TextSalePrice.DecimalValue = decimal.Parse(value.ToString()); }
        public string BarCode { get => TextBarCode.Text; set => TextBarCode.Text = value; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get => TextCategoryDescription.Text; set => TextCategoryDescription.Text = value; }
        public object CategoryList { get => DataGridCategory.DataSource; set => DataGridCategory.DataSource = value; }
    }
}

/// <summary>
/// Eventos da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm : Form
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ProductAddForm_Click(object sender, EventArgs e)
        {
            DataGridCategory.Visible = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var actionResult = false;
                var presenter = new ProductAddPresenter(this);

                if (Id == 0)
                    actionResult = presenter.Insert();

                if (Id > 0)
                    actionResult = presenter.Update();

                switch (actionResult)
                {
                    case true:
                        MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case false:
                        SetRiqueridField();
                        break;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var actionResult = false;
                var presenter = new ProductAddPresenter(this);

                actionResult = presenter.Delete();

                switch (actionResult)
                {
                    case true:
                        MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case false:
                        MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonClear_View_Click(object sender, EventArgs e)
        {
            try
            {
                ClearView();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonShow_CategoryAddForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CategoryAddForm.ShowForm();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CategoryDescription = DataGridCategory.CurrentRow.Cells["Description"].Value.ToString();

                var presenter = new ProductAddPresenter(this);
                CategoryId = presenter.GetIdByDescription();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void DataGridCategory_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                var dataGrid = DataGridCategory;

                if (dataGrid.Rows.Count == 0)
                    return;

                dataGrid.Columns["Id"].Visible = false;

                dataGrid.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns["Description"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void TextCategoryDescription_Click(object sender, EventArgs e)
        {
            var presenter = new ProductAddPresenter(this);
            presenter.ListAllCategoryData();
        }
        private void TextCategoryDescription_TextChanged(object sender, EventArgs e)
        {
            if (TextCategoryDescription.Text == string.Empty)
                DataGridCategory.Visible = false;
        }
        private void TextCategoryDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }

        private void TimerSearch_Tick(object sender, EventArgs e)
        {
            TimerSearch.Enabled = false;

            try
            {
                var presenter = new ProductAddPresenter(this);
                presenter.FetchCategoryData();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    }
}

/// <summary>
/// Métodos Auxiliares da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm
    {
        public static void ShowForm()
        {
            var productAddForm = new ProductAddForm()
            {
                ShowInTaskbar = false,
                ShowIcon = false,
                MinimizeBox = false,
                MaximizeBox = false
            };

            productAddForm.Show();
        }

        public static void SetDetail(IProductAddView view)
        {
            var productAddForm = new ProductAddForm()
            {
                Id = view.Id,
                InternalCode = view.InternalCode,
                Description = view.Description,
                CostPrice = view.CostPrice,
                SalePrice = view.SalePrice,
                BarCode = view.BarCode,
                CategoryId = view.CategoryId,
                CategoryDescription = view.CategoryDescription,
                ShowIcon = false,
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            productAddForm.ShowDialog();
        }

        private void SetRiqueridField()
        {
            foreach (Control ctl in BuniCard.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if (Convert.ToString(ctl.Tag) == "required" && ctl.Text == string.Empty)
                {
                    SetErrorProvider(ctl);
                    return;
                }

                if (Convert.ToString(ctl.Tag) == "required" && ctl.Text == "R$ 0,00")
                {
                    SetErrorProvider(ctl);
                    return;
                }
            }
        }

        private void SetErrorProvider(Control ctl)
        {
            MessageError.Clear();
            MessageError.SetError(ctl, MessageNotifier.Message);
        }

        private void ClearView()
        {
            var presenter = new ProductAddPresenter(this);
            presenter.ClearView();

            TextInternalCode.Select();
            DataGridCategory.Visible = false;
            ButtonShow_CategoryAddForm.Visible = false;
        }
    }
}
