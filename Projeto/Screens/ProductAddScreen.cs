using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework;
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
        private static MetroForm thisScreen;

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
            SetScreen();
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
            try
            {
                Refresh();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            try
            {
                Close();
                thisScreen = null;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void GridCategoryCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CategoryDescription = GridCategory.CurrentRow.Cells["Description"].Value.ToString();
                presenter.GetCategoryIdByDescription(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void GridCategorySourceChanged(object sender, EventArgs e)
        {
            try
            {
                var gridList = GridCategory;
                gridList.Visible = true;

                if (gridList.Rows.Count == 0)
                {
                    HideGridCategory(sender, e);
                    return;
                }

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
            try
            {
                TimerSearch.Enabled = false;
                TimerSearch.Enabled = true;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void BoxCategoryDescriptionChanger(object sender, EventArgs e)
        {
            try
            {
                if (BoxCategoryDescription.Text == string.Empty)
                    GridCategory.Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void TimerSearchTick(object sender, EventArgs e)
        {
            try
            {
                TimerSearch.Enabled = false;
                presenter.SearchCategory(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void HideGridCategory(object sender, EventArgs e)
        {
            try
            {
                GridCategory.Visible = false;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }

        }

        private void InitializeEvents()
        {
            try
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
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void InitializePresenter()
        {
            try
            {
                presenter = new ProductAddPresenter(this);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void SetDetail(IProductAddView view)
        {
            try
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
                    Owner = HomeScreen.GetScreen();
                    ShowDialog();
                };
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static MetroForm GetScreen()
        {
            return thisScreen;
        }
        private void SetScreen()
        {
            thisScreen = this;
        }

        public static void ShowScreen(Form fatherScreen = null)
        {
            var screen = new ProductAddScreen();

            if (fatherScreen != null)
            {
                screen.MdiParent = fatherScreen;
                screen.ShowInTaskbar = false;
                screen.ControlBox = false;
                screen.Dock = DockStyle.Fill;
                screen.Style = MetroColorStyle.White;
                screen.Show();
            }
            else
            {
                screen.ShowInTaskbar = false;
                screen.ControlBox = false;
                screen.ShowIcon = false;
                screen.Style = MetroColorStyle.Blue;

                var listingScreen = CategoryListingScreen.GetScreen();
                if (listingScreen != null)
                    screen.Owner = listingScreen;

                screen.ShowDialog();
                screen.Dispose();
            }
        }
    }
}