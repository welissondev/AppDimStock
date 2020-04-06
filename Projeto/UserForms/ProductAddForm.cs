using Bunifu.UI.WinForms.BunifuTextbox;
using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using Syncfusion.Windows.Forms.Tools;
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
        public double CostPrice { get => double.Parse(TextCostPrice.DecimalValue.ToString()); set => double.Parse(TextCostPrice.Text = value.ToString()); }
        public double SalePrice { get => double.Parse(TextSalePrice.DecimalValue.ToString()); set => double.Parse(TextSalePrice.Text = value.ToString()); }
        public string BarCode { get => TextBarCode.Text; set => TextBarCode.Text = value; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get => BoxCategoryDescription.Text; set => BoxCategoryDescription.Text = value; }
        public object CategoryList { get => DataGridCategory.DataSource; set => DataGridCategory.DataSource = value; }
    }
}

/// <summary>
/// Eventos da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductAddForm : MetroForm
    {
        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            try
            {
                TextInternalCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ProductAddForm_Click(object sender, EventArgs e)
        {
            DataGridCategory.Visible = false;
        }
        private void ProductAddForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var actionResult = true;
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

                if (MessageBox.Show("Confirma a exclusão desse produto?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) ==
                DialogResult.No) return;

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
        private void ButtonClearView_Click(object sender, EventArgs e)
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
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ButtonShow_CategoryAddForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryAddForm.ShowForm();
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

        private void BoxCategoryDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }
        private void BoxCategoryDescription_Click(object sender, EventArgs e)
        {
            SetErrorProvider();

            var presenter = new ProductAddPresenter(this);
            presenter.ListAllCategoryData();
        }
        private void BoxCategoryDescription_TextChanged(object sender, EventArgs e)
        {
            if (BoxCategoryDescription.Text == string.Empty)
                DataGridCategory.Visible = false;
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

        private void SetErrorProvider(Control ctl = null)
        {
            if (ctl == null)
            {
                ErrorProvider.Clear();
                return;
            }

            ErrorProvider.Clear();
            ErrorProvider.SetError(ctl, MessageNotifier.Message);
        }

        private void ClearView()
        {
            var presenter = new ProductAddPresenter(this);
            presenter.ClearView();

            TextInternalCode.Focus();
            DataGridCategory.Visible = false;
            SetErrorProvider();
        }
    }
}
