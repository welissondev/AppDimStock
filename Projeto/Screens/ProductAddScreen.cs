using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa o formulário de cadastro dos produtos
    /// </summary>
    public partial class ProductAddScreen : IProductAddView
    {
        private ProductAddPresenter presenter;

        public int Id { get; set; }
        public string InternalCode { get => TextInternalCode.Text; set => TextInternalCode.Text = value; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
        public double CostPrice { get => double.Parse(TextCostPrice.DecimalValue.ToString()); set => double.Parse(TextCostPrice.Text = value.ToString()); }
        public double SalePrice { get => double.Parse(TextSalePrice.DecimalValue.ToString()); set => double.Parse(TextSalePrice.Text = value.ToString()); }
        public string BarCode { get => TextBarCode.Text; set => TextBarCode.Text = value; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get => BoxCategoryDescription.Text; set => BoxCategoryDescription.Text = value; }
        public object CategoryDataList { get => GridCategory.DataSource; set => GridCategory.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class ProductAddScreen : MetroForm
    {
        public ProductAddScreen()
        {
            InitializeComponent();
            InitializePresenter();
            InitializeEvents();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
                TextInternalCode.Select();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ScreenResize(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            Close();
        }
        public void ScreenShow(object sender, EventArgs e)
        {
            using (var screen = new ProductAddScreen())
            {
                ShowInTaskbar = false;
                ShowIcon = false;
                ControlBox = false;
                Owner = HomeScreen.He;
                ShowDialog();
            };
        }

        private void GridCategoryCellClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryDescription = GridCategory.CurrentRow.Cells["Description"].Value.ToString();
            presenter.GetCategoryIdByDescription(sender, e);
        }
        private void GridCategorySourceChanged(object sender, EventArgs e)
        {
            try
            {
                var gridList = GridCategory;

                if (gridList.Rows.Count == 0)
                    return;

                gridList.Columns["Id"].Visible = false;

                gridList.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridList.Columns["Description"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void BoxCategoryDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
        }
        private void BoxCategoryDescriptionChanger(object sender, EventArgs e)
        {
            if (BoxCategoryDescription.Text == string.Empty)
                GridCategory.Visible = false;
        }

        private void TimerSearchTick(object sender, EventArgs e)
        {
            TimerSearch.Enabled = false;

            try
            {
                presenter.SearchCategory(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void HideGridCategory(object sender, EventArgs e)
        {
            GridCategory.Visible = false;
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            Click += new EventHandler(HideGridCategory);
            Resize += new EventHandler(ScreenResize);
            PanelShadow.Click += new EventHandler(HideGridCategory);
            ButtonSave.Click += new EventHandler(presenter.Update);
            ButtonDelete.Click += new EventHandler(presenter.Delete);
            ButtonClearView.Click += new EventHandler(presenter.ClearView);
            ButtonClearView.Click += new EventHandler(HideGridCategory);
            ButtonClose.Click += new EventHandler(ScreenClose);
            GridCategory.CellClick += new DataGridViewCellEventHandler(GridCategoryCellClick);
            GridCategory.DataSourceChanged += new EventHandler(GridCategorySourceChanged);
            BoxCategoryDescription.Click += new EventHandler(presenter.ListCategory);
            BoxCategoryDescription.KeyPress += new KeyPressEventHandler(BoxCategoryDescriptionKeyPress);
            BoxCategoryDescription.TextChange += new EventHandler(BoxCategoryDescriptionChanger);
            TimerSearch.Tick += new EventHandler(TimerSearchTick);
        }
        private void InitializePresenter()
        {
            presenter = new ProductAddPresenter(this);
        }

        public void SetDetail(IProductAddView view)
        {
            using (var screen = new ProductAddScreen())
            {
                Id = view.Id;
                InternalCode = view.InternalCode;
                Description = view.Description;
                CostPrice = view.CostPrice;
                SalePrice = view.SalePrice;
                BarCode = view.BarCode;
                CategoryId = view.CategoryId;
                CategoryDescription = view.CategoryDescription;
                ShowIcon = false;
                ShowInTaskbar = false;
                ControlBox = false;
                Owner = HomeScreen.He;
                ShowDialog();
            };
        }
    }
}