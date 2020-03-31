using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using System;
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
        private void ButtonPresenter_ResetView_Click(object sender, EventArgs e)
        {
            try
            {
                var presenter = new ProductAddPresenter(this);
                presenter.ResetView();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonSearch_Category_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var presenter = new ProductAddPresenter(this);

                if (presenter.FetchCategoryData().Rows.Count > 0)
                    ApplySettingsToDataGridCategory();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ButtonExit_Click(object sender, EventArgs e)
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

        private void TextCategoryDescription_Click(object sender, EventArgs e)
        {
            var presenter = new ProductAddPresenter(this);

            if (presenter.ListAllCategoryData().Rows.Count > 0)
                ApplySettingsToDataGridCategory();
        }
        private void TextCategoryDescription_TextChanged(object sender, EventArgs e)
        {
            if (TextCategoryDescription.Text == string.Empty)
                DataGridCategory.Visible = false;
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

        private void ApplySettingsToDataGridCategory()
        {
            try
            {
                DataGridCategory.Columns["Id"].Visible = false;

                DataGridCategory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridCategory.Columns["Description"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    }
}
