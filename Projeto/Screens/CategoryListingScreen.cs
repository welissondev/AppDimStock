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
    /// Representa a tela de listagem das categorias
    /// </summary>
    public partial class CategoryListingScreen : MetroForm, ICategoryListingView
    {
        private static MetroForm thisScreen;

        private CategoryListingPresenter presenter;
        private DataGridViewLinkColumn buttonView;
        private DataGridViewLinkColumn buttonDelete;

        public int Id { get; set; }
        public string Description { get => TextSearchDescription.Text; set => TextSearchDescription.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class CategoryListingScreen
    {
        public CategoryListingScreen()
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
                presenter.SearchData(sender, e);
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
        private void ShowChildScreen(object sender, EventArgs e)
        {
            if (sender.Equals(ButtonNew))
            {
                CategoryAddScreen.ShowScreen();
            }
        }

        private void TimerTick(object sender, EventArgs e)
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

        private void GridCellEnter(object sender, DataGridViewCellEventArgs e)
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
        private void GridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = int.Parse(GridList.CurrentRow.
                Cells["Id"].Value.ToString());

                Description = GridList.CurrentRow.
                Cells["Description"].Value.ToString();

                var selectedButton = GridList.Columns
                [e.ColumnIndex].Name;

                switch (selectedButton)
                {
                    case "ButtonView":
                        presenter.GetDetails(sender, e);
                        new CategoryAddScreen().SetDetails(this);
                        break;

                    case "ButtonDelete":
                        presenter.Delete(sender, e);
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void GridRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
        private void GridSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridList.Rows.Count == 0)
                    return;

                GridList.Columns["Id"].Visible = false;
                GridList.Columns["Id"].ReadOnly = true;
                GridList.Columns["Id"].DisplayIndex = 0;

                GridList.Columns["Description"].HeaderText = "Descrição";
                GridList.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridList.Columns["Description"].ReadOnly = true;
                GridList.Columns["Description"].DisplayIndex = 1;

                GridList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                GridList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                GridList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                GridList.AllowUserToAddRows = false;
                GridList.MultiSelect = false;
                GridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                if (buttonView == null)
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
                }

                if (buttonDelete == null)
                {
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

                GridList.Columns["ButtonView"].HeaderText = string.Empty;
                GridList.Columns["ButtonView"].Width = 70;

                GridList.Columns["ButtonDelete"].Width = 70;
                GridList.Columns["ButtonDelete"].HeaderText = string.Empty;
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
                TimerSearch.Enabled = false;
                TimerSearch.Enabled = true;
                ImageLoading.Visible = true;
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
                GridList.DataSourceChanged += new EventHandler(GridSourceChanged);
                GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridCellEnter);
                GridList.CellClick += new DataGridViewCellEventHandler(GridCellClick);
                ButtonNew.Click += new EventHandler(ShowChildScreen);
                ButtonListGrid.Click += new EventHandler(TimerTick);
                ButtonCloseScreen.Click += new EventHandler(ScreenClose);
                ButtonScreenClear.Click += new EventHandler(presenter.ClearView);
                TimerSearch.Tick += new EventHandler(TimerTick);
                TextSearchDescription.KeyPress += new KeyPressEventHandler(TextKeyPress);
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
                presenter = new CategoryListingPresenter(this);
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
            try
            {
                MdiClosingAll.CloseAllForms();

                var screen = new CategoryListingScreen();

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

                    var homeScreen = HomeScreen.GetScreen();
                    if (homeScreen != null)
                        screen.Owner = homeScreen;

                    screen.ShowDialog();
                    screen.Dispose();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}