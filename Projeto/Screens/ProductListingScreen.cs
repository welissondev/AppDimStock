using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa o formulário de listagem dos produtos
    /// </summary>
    public partial class ProductListingScreen : IProductListingView
    {
        private static MetroForm thisScreen;

        private DataGridViewLinkColumn buttonView;
        private DataGridViewLinkColumn buttonDelete;
        private ProductListingPresenter presenter;

        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public object CategoryDataList { get; set; }
        public string SearchInternalCode { get => TextSearchInternalCode.Text; set => TextSearchInternalCode.Text = value; }
        public string SearchDescription { get => TextSearchDescription.Text; set => TextSearchDescription.Text = value; }
        public object ProductDataList { get => GridList.DataSource; set => GridList.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class ProductListingScreen : MetroForm
    {
        public ProductListingScreen()
        {
            InitializeComponent();
            InitializePrensenter();
            InitializeEvents();
            SetScreen();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
                presenter.SearchData(sender, e);
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

        private void ShowChildScreen(object sender, EventArgs e)
        {
            if (sender.Equals(ButtonNew))
                ProductAddScreen.ShowScreen();
        }

        private void TextSearchKeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                ImageLoading.Visible = true;
                TimerSearch.Enabled = false;
                TimerSearch.Enabled = true;

            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void GridListRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void GridListCellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    GridList.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void GridListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GridList.Rows.Count != 0)
                {
                    Id = int.Parse(GridList.CurrentRow.
                    Cells["Id"].Value.ToString());

                    var selectedButton = GridList.Columns
                    [e.ColumnIndex].Name;

                    switch (selectedButton)
                    {
                        case "ButtonView":
                            presenter.GetDetails(sender, e);
                            new ProductAddScreen().SetDetail(this);
                            break;

                        case "ButtonDelete":
                            presenter.Delete(sender, e);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void GridListSourceChanged(object sender, EventArgs e)
        {
            try
            {
                var gridList = GridList;
                gridList.Visible = true;

                if (gridList.Rows.Count == 0)
                {
                    gridList.Visible = false;
                    return;
                }

                gridList.Columns["Id"].Visible = false;
                gridList.Columns["Id"].ReadOnly = true;
                gridList.Columns["Id"].DisplayIndex = 0;

                gridList.Columns["InternalCode"].ReadOnly = true;
                gridList.Columns["InternalCode"].DisplayIndex = 1;
                gridList.Columns["InternalCode"].HeaderText = "Código";
                gridList.Columns["InternalCode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridList.Columns["InternalCode"].Width = 170;

                gridList.Columns["Description"].HeaderText = "Descrição";
                gridList.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridList.Columns["Description"].ReadOnly = true;
                gridList.Columns["Description"].DisplayIndex = 2;

                gridList.Columns["CostPrice"].HeaderText = "Preço Custo";
                gridList.Columns["CostPrice"].DefaultCellStyle.Format = "c2";
                gridList.Columns["CostPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                gridList.Columns["CostPrice"].Width = 120;

                gridList.Columns["SalePrice"].HeaderText = "Preço Venda";
                gridList.Columns["SalePrice"].DefaultCellStyle.Format = "c2";
                gridList.Columns["SalePrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                gridList.Columns["SalePrice"].Width = 120;

                if (buttonView == null && buttonDelete == null)
                {
                    buttonView = new DataGridViewLinkColumn
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
                    GridList.Columns.Add(buttonView);


                    buttonDelete = new DataGridViewLinkColumn
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
                    GridList.Columns.Add(buttonDelete);
                }

                gridList.Columns["ButtonView"].HeaderText = string.Empty;
                gridList.Columns["ButtonView"].Width = 100;
                gridList.Columns["ButtonView"].DisplayIndex = 6;
                gridList.Columns["ButtonView"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                gridList.Columns["ButtonDelete"].Width = 100;
                gridList.Columns["ButtonDelete"].HeaderText = string.Empty;
                gridList.Columns["ButtonDelete"].DisplayIndex = 6;
                gridList.Columns["ButtonDelete"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                gridList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                gridList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                gridList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                gridList.AllowUserToAddRows = false;
                gridList.MultiSelect = false;

                GridList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro em tempo de execução",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerSearchTitk(object sender, EventArgs e)
        {
            try
            {
                TimerSearch.Enabled = false;
                ImageLoading.Visible = false;
                presenter.SearchData(sender, e);
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
                Resize += new EventHandler(ScreenResize);
                ButtonNew.Click += new EventHandler(ShowChildScreen);
                ButtonUpdateGridList.Click += new EventHandler(presenter.SearchData);
                ButtonClear.Click += new EventHandler(presenter.ClearView);
                ButtonClose.Click += new EventHandler(ScreenClose);
                GridList.DataSourceChanged += new EventHandler(GridListSourceChanged);
                GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridListCellMouseEnter);
                GridList.CellClick += new DataGridViewCellEventHandler(GridListCellClick);
                TimerSearch.Tick += new EventHandler(TimerSearchTitk);
                TextSearchInternalCode.KeyPress += new KeyPressEventHandler(TextSearchKeyPress);
                TextSearchDescription.KeyPress += new KeyPressEventHandler(TextSearchKeyPress);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void InitializePrensenter()
        {
            try
            {
                presenter = new ProductListingPresenter(this);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void SetScreen()
        {
            thisScreen = this;
        }
        public static MetroForm GetScreen()
        {
            return thisScreen;
        }

        public static void ShowScreen(Form fatherScreen = null)
        {
            MdiClosingAll.CloseAllForms();

            var screen = new ProductListingScreen();

            if (fatherScreen != null)
            {
                screen.MdiParent = fatherScreen;
                screen.ShowInTaskbar = false;
                screen.ControlBox = false;
                screen.Dock = DockStyle.Fill;
                screen.Movable = false;
                screen.Style = MetroColorStyle.White;
                screen.Show();
            }
            else
            {
                screen.ShowInTaskbar = false;
                screen.ControlBox = false;
                screen.ShowIcon = false;
                screen.Style = MetroColorStyle.Blue;

                var homeScreen = HomeScreen.GetScreen();
                if (homeScreen != null)
                    screen.Owner = homeScreen;

                screen.ShowDialog();
                screen.Dispose();
            }
        }
    }
}


