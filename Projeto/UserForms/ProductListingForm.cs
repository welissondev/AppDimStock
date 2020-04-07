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
        }
        private void ProductListingForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ButtonUpdate_DataGridProduct_Click(object sender, EventArgs e)
        {
            var presenter = new ProductListingPresenter(this);
            presenter.FetchData();
        }

        private void DatagridProduct_DataSourceChanged(object sender, EventArgs e)
        {
            if (DatagridProduct.Rows.Count > 0)
            {
                ApplySettingsToDataGrid();
            }
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
                MinimizeBox = false,
                MaximizeBox = false
            };
            productListingForm.ShowDialog();
        }

        private void ApplySettingsToDataGrid()
        {
            try
            {
                DatagridProduct.Columns["Id"].Visible = false;
                DatagridProduct.Columns["Id"].ReadOnly = true;
                DatagridProduct.Columns["Id"].DisplayIndex = 0;

                DatagridProduct.Columns["Description"].HeaderText = "Descrição";
                DatagridProduct.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DatagridProduct.Columns["Description"].ReadOnly = true;
                DatagridProduct.Columns["Description"].DisplayIndex = 1;

                DatagridProduct.Columns["ButtonView"].HeaderText = string.Empty;
                DatagridProduct.Columns["ButtonView"].Width = 70;

                DatagridProduct.Columns["ButtonDelete"].Width = 70;
                DatagridProduct.Columns["ButtonDelete"].HeaderText = string.Empty;

                DatagridProduct.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                DatagridProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                DatagridProduct.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                DatagridProduct.AllowUserToAddRows = false;
                DatagridProduct.MultiSelect = false;
                DatagridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

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
    }
}


