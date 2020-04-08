using DimStock.Auxiliarys;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductListingForm : IProductListingView
    {
        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public object CategoryList { get; set; }
        public string SearchInternalCode { get => TextSearch_InternalCode.Text; set => TextSearch_InternalCode.Text = value; }
        public string SearchDescription { get => TextSearch_Description.Text; set => TextSearch_Description.Text = value; }
        public object ProductList { get => DatagridProduct.DataSource; set => DatagridProduct.DataSource = value; }
    }
}

namespace DimStock.UserForms
{
    public partial class ProductListingForm : MetroForm
    {
        public ProductListingForm()
        {
            InitializeComponent();
            AddButtonColumnInDataGrid();
        }

        private void ProductListingForm_Load(object sender, EventArgs e)
        {
            try
            {
                SearchProduct();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        private void ProductListingForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ButtonUpdate_DataGridProduct_Click(object sender, EventArgs e)
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
        private void ButtonShow_ProductAddForm_Click(object sender, EventArgs e)
        {
            ProductAddForm.ShowForm();
        }
        private void ButtonClear_SearchFields_Click(object sender, EventArgs e)
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

        private void TextSearch_InternalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImageLoading.Visible = true;
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }
        private void TextSearch_Description_TextChanged(object sender, EventArgs e)
        {
            ImageLoading.Visible = true;
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }

        private void DatagridProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        private void DatagridProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridProduct.Rows[e.RowIndex].Selected = true;
            }
        }
        private void DatagridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DatagridProduct.Rows.Count != 0)
                {
                    Id = int.Parse(DatagridProduct.CurrentRow.
                    Cells["Id"].Value.ToString());

                    var selectedButton = DatagridProduct.Columns
                    [e.ColumnIndex].Name;

                    switch (selectedButton)
                    {
                        case "ButtonView":
                            GetProductDetail();
                            break;

                        case "ButtonDelete":
                            DeleteProduct();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void TimerSearch_Tick(object sender, EventArgs e)
        {
            TimerSearch.Enabled = false;
            ImageLoading.Visible = false;

            try
            {
                SearchProduct();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    }
}

/// <summary>
/// Métodos auxiliares da classe
/// </summary>
namespace DimStock.UserForms
{
    public partial class ProductListingForm
    {
        public static void ShowForm()
        {
            var productListingForm = new ProductListingForm()
            {
                ShowIcon = false,
                ShowInTaskbar = false,
                ControlBox = false,
                Owner = HomeScreenForm.He
            };
            productListingForm.ShowDialog();
        }

        private void ApplySettingsToDataGrid()
        {
            try
            {
                var grid = DatagridProduct;

                grid.Columns["Id"].Visible = false;
                grid.Columns["Id"].ReadOnly = true;
                grid.Columns["Id"].DisplayIndex = 0;

                grid.Columns["InternalCode"].ReadOnly = true;
                grid.Columns["InternalCode"].DisplayIndex = 1;
                grid.Columns["InternalCode"].HeaderText = "Código";
                grid.Columns["InternalCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                grid.Columns["InternalCode"].Width = 170;

                grid.Columns["Description"].HeaderText = "Descrição";
                grid.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grid.Columns["Description"].ReadOnly = true;
                grid.Columns["Description"].DisplayIndex = 2;

                grid.Columns["CostPrice"].HeaderText = "Preço Custo";
                grid.Columns["CostPrice"].DefaultCellStyle.Format = "c2";
                grid.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grid.Columns["CostPrice"].Width = 120;

                grid.Columns["SalePrice"].HeaderText = "Preço Venda";
                grid.Columns["SalePrice"].DefaultCellStyle.Format = "c2";
                grid.Columns["SalePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grid.Columns["SalePrice"].Width = 120;

                grid.Columns["ButtonView"].HeaderText = string.Empty;
                grid.Columns["ButtonView"].Width = 100;
                grid.Columns["ButtonView"].DisplayIndex = 6;
                grid.Columns["ButtonView"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns["ButtonDelete"].Width = 100;
                grid.Columns["ButtonDelete"].HeaderText = string.Empty;
                grid.Columns["ButtonDelete"].DisplayIndex = 6;
                grid.Columns["ButtonView"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                grid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                grid.AllowUserToAddRows = false;
                grid.MultiSelect = false;

                DatagridProduct.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro em tempo de execução",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonColumnInDataGrid()
        {
            try
            {
                var buttonView = new DataGridViewLinkColumn
                {
                    Name = "ButtonView",
                    Text = "Visualizar",
                    TrackVisitedState = false,
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Black,
                    ActiveLinkColor = Color.Black,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 100,
                };
                DatagridProduct.Columns.Add(buttonView);


                var buttonDelete = new DataGridViewLinkColumn
                {
                    Name = "ButtonDelete",
                    Text = "Deletar",
                    TrackVisitedState = false,
                    UseColumnTextForLinkValue = true,
                    LinkColor = Color.Black,
                    ActiveLinkColor = Color.Black,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 100,
                };
                DatagridProduct.Columns.Add(buttonDelete);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void GetProductDetail()
        {
            var actionResult = false;

            var presenter = new ProductListingPresenter(this);
            actionResult = presenter.GetDetail();

            switch (actionResult)
            {
                case true:
                    ProductAddForm.SetDetail(this);
                    break;

                case false:
                    MessageBox.Show(MessageNotifier.Message, MessageNotifier.Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void DeleteProduct()
        {
            if (MessageBox.Show("Confirma a exclusão desse produto?", "IMPORTANTE",
            MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) ==
            DialogResult.No) return;

            var presenter = new ProductListingPresenter(this);
            var actionResult = presenter.Delete();

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

        private void SearchProduct()
        {
            var presenter = new ProductListingPresenter(this);

            if (presenter.FetchData().Rows.Count > 0)
                ApplySettingsToDataGrid();
        }

        private void ClearView()
        {
            var presenter = new ProductListingPresenter(this);
            presenter.ResetView();

            SearchProduct();

            TextSearch_InternalCode.Select();
        }
    }
}


