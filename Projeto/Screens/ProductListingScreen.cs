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
    public partial class ProductListingScreen : MetroForm, IProductListingView
    {
        private static MetroForm thisScreen;
        private DataGridViewLinkColumn buttonViewDetails;
        private DataGridViewLinkColumn buttonDelete;

        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public int StockMin { get ; set ; }
        public int StockMax { get ; set ; }
        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public object CategoryDataList { get; set; }
        public string SearchInternalCode { get => TextSearchInternalCode.Text; set => TextSearchInternalCode.Text = value; }
        public string SearchDescription { get => TextSearchDescription.Text; set => TextSearchDescription.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }


        public ProductListingScreen()
        {
            InitializeComponent();
            InitializeEvents();
            SetScreen();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
                TimerStart();
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
            if (sender.Equals(ButtonNew))
                ProductAddScreen.ShowScreen(null, this);
        }

        private void SetScreen()
        {
            thisScreen = this;
        }

        public static MetroForm GetScreen()
        {
            return thisScreen;
        }
        public static void ShowScreen(Form mdi = null, MetroForm owner = null)
        {
            MdiClosingAll.CloseAllForms();

            var screen = new ProductListingScreen();

            if (mdi != null)
            {
                screen.MdiParent = mdi;
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

                if (owner != null)
                    screen.Owner = owner;

                screen.ShowDialog();
                screen.Dispose();
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
                Id = int.Parse(GridList.CurrentRow.
                Cells["Id"].Value.ToString());

                var selectedButton = GridList.Columns
                [e.ColumnIndex].Name;

                switch (selectedButton)
                {
                    case "ButtonViewDetails":
                        PresenterGetDetails(sender, e);
                        break;

                    case "ButtonDelete":
                        PresenterDelete(sender, e);
                        break;
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

                if (gridList.Rows.Count == 0)
                    return;

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

                if (buttonViewDetails == null && buttonDelete == null)
                {
                    buttonViewDetails = new DataGridViewLinkColumn
                    {
                        Name = "ButtonViewDetails",
                        Text = "Visualizar",
                        TrackVisitedState = false,
                        UseColumnTextForLinkValue = true,
                        LinkColor = Color.Black,
                        ActiveLinkColor = Color.Black,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                        Width = 100,
                    };
                    GridList.Columns.Add(buttonViewDetails);


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

                gridList.Columns["ButtonViewDetails"].HeaderText = string.Empty;
                gridList.Columns["ButtonViewDetails"].Width = 70;
                gridList.Columns["ButtonViewDetails"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                gridList.Columns["ButtonDelete"].Width = 70;
                gridList.Columns["ButtonDelete"].HeaderText = string.Empty;
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

        private void TimerStart()
        {
            TimerSearch.Enabled = true;
            ImageLoading.Visible = true;
        }
        private void TimerPause()
        {
            TimerSearch.Enabled = false;
            ImageLoading.Visible = false;
        }
        private void TimerTick(object sender, EventArgs e)
        {
            try
            {
                TimerPause();
                PresenterSearchData(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void TextKeyPress(object sender, KeyPressEventArgs e)
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

        private void InitializeEvents()
        {
            try
            {
                Load += new EventHandler(ScreenLoad);
                Resize += new EventHandler(ScreenResize);
                ButtonNew.Click += new EventHandler(ShowRelatedScreen);
                ButtonUpdateGridList.Click += new EventHandler(PresenterSearchData);
                ButtonClear.Click += new EventHandler(PresenterClear);
                ButtonClose.Click += new EventHandler(ScreenClose);
                GridList.DataSourceChanged += new EventHandler(GridListSourceChanged);
                GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridListCellMouseEnter);
                GridList.CellClick += new DataGridViewCellEventHandler(GridListCellClick);
                GridList.RowPrePaint += new DataGridViewRowPrePaintEventHandler(GridListRowPrePaint);
                TimerSearch.Tick += new EventHandler(TimerTick);
                TextSearchInternalCode.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchDescription.KeyPress += new KeyPressEventHandler(TextKeyPress);
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
                new ProductListingPresenter(this).Delete();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterGetDetails(object sender, EventArgs e)
        {
            try
            {
                new ProductListingPresenter(this).GetDetails();
                ProductAddScreen.SetDetails(this);
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
                new ProductListingPresenter(this).Clear();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterSearchData(object sender, EventArgs e)
        {
            try
            {
                new ProductListingPresenter(this).SearchData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}


