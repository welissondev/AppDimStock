using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class ProductAddScreen : MetroForm, IProductAddView
    {
        private static MetroForm thisScreen;

        public int Id { get; set; }
        public string InternalCode { get => TextInternalCode.Text; set => TextInternalCode.Text = value; }
        public string Description { get => TextDescription.Text; set => TextDescription.Text = value; }
        public double CostPrice { get => double.Parse(TextCostPrice.DecimalValue.ToString()); set => double.Parse(TextCostPrice.Text = value.ToString()); }
        public double SalePrice { get => double.Parse(TextSalePrice.DecimalValue.ToString()); set => double.Parse(TextSalePrice.Text = value.ToString()); }
        public string BarCode { get => TextBarCode.Text; set => TextBarCode.Text = value; }
        public int StockMin { get => int.Parse(TextStockMin.Text); set => TextStockMin.Text = value.ToString(); }
        public int StockMax { get => int.Parse(TextStockMax.Text); set => TextStockMax.Text = value.ToString(); }
        public int CategoryId { get; set; }
        public string CategoryDescription { get => BoxCategoryDescription.Text; set => BoxCategoryDescription.Text = value; }
        public object CategoryDataList { get => GridCategory.DataSource; set => GridCategory.DataSource = value; }

        public ProductAddScreen()
        {
            InitializeComponent();
            InitializeEvents();
            SetScreen();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
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

        private void ShowRelatedScreen(object sender, EventArgs e)
        {
            if (sender.Equals(LinkShowCategoryAddScreen))
                CategoryAddScreen.ShowScreen(null, this);
        }
        private void SetScreen()
        {
            thisScreen = this;
        }

        public static void ShowScreen(Form mdi = null, MetroForm owner = null)
        {
            try
            {
                var screen = new ProductAddScreen();

                if (mdi != null)
                {
                    screen.MdiParent = mdi;
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.Dock = DockStyle.Fill;
                    screen.Style = MetroColorStyle.White;
                    screen.Movable = false;
                    screen.Show();
                }
                else
                {
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.ShowIcon = false;
                    screen.Style = MetroColorStyle.Blue;

                    if (owner != null)
                        screen.Owner = owner;

                    screen.ShowDialog();
                    screen.Dispose();
                }
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
        public static void SetDetails(IProductAddView view, MetroForm ownerScreen = null)
        {
            try
            {
                var screen = new ProductAddScreen
                {
                    Id = view.Id,
                    InternalCode = view.InternalCode,
                    Description = view.Description,
                    CostPrice = view.CostPrice,
                    SalePrice = view.SalePrice,
                    BarCode = view.BarCode,
                    CategoryId = view.CategoryId,
                    CategoryDescription = view.CategoryDescription,
                    StockMin = view.StockMin,
                    StockMax = view.StockMax                
                };

                if (ownerScreen != null)
                    screen.Owner = ownerScreen;

                screen.ShowIcon = false;
                screen.ShowInTaskbar = false;
                screen.ControlBox = false;
                screen.Style = MetroColorStyle.Blue;

                screen.ShowDialog();
                screen.Dispose();
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
                PresenterGetCategoryIdByDescription(sender, e);
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
                gridList.SetControlSize(270);

                if (gridList.Rows.Count == 0)
                {
                    GridCategoryHide(sender, e);
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
        private void GridCategoryHide(object sender, EventArgs e)
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

        private void BoxCategoryDescriptionKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                TimerPause();
                TimerStart();
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

        private void InitializeEvents()
        {
            try
            {
                Load += new EventHandler(ScreenLoad);
                Click += new EventHandler(GridCategoryHide);
                Resize += new EventHandler(ScreenResize);
                PanelShadow.Click += new EventHandler(GridCategoryHide);
                ButtonSave.Click += new EventHandler(PresenterUpdate);
                ButtonDelete.Click += new EventHandler(PresenterDelete);
                ButtonClearView.Click += new EventHandler(PresenterClear);
                ButtonClearView.Click += new EventHandler(GridCategoryHide);
                ButtonClose.Click += new EventHandler(ScreenClose);
                LinkShowCategoryAddScreen.Click += new EventHandler(ShowRelatedScreen);
                GridCategory.CellClick += new DataGridViewCellEventHandler(GridCategoryCellClick);
                GridCategory.DataSourceChanged += new EventHandler(GridCategorySourceChanged);
                BoxCategoryDescription.Click += new EventHandler(PresenterSearchCategory);
                BoxCategoryDescription.KeyPress += new KeyPressEventHandler(BoxCategoryDescriptionKeyPress);
                BoxCategoryDescription.TextChange += new EventHandler(BoxCategoryDescriptionChanger);
                TimerSearch.Tick += new EventHandler(TimerTick);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void TimerStart()
        {
            TimerSearch.Enabled = true;
        }
        private void TimerPause()
        {
            TimerSearch.Enabled = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            try
            {
                TimerPause();
                PresenterSearchCategory(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void PresenterUpdate(object sender, EventArgs e)
        {
            try
            {
                new ProductAddPresenter(this).Update();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterDelete(object sender, EventArgs e)
        {
            try

            {
                new ProductAddPresenter(this).Delete();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterClear(object sender, EventArgs e)
        {
            try
            {
                new ProductAddPresenter(this).Clear();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterGetCategoryIdByDescription(object sender, EventArgs e)
        {
            try
            {
                new ProductAddPresenter(this).GetCategoryIdByDescription();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterSearchCategory(object sender, EventArgs e)
        {
            try
            {
                new ProductAddPresenter(this).SearchCategory();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterListCategory(object sender, EventArgs e)
        {
            try
            {
                new ProductAddPresenter(this).ListCategory();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

    }
}