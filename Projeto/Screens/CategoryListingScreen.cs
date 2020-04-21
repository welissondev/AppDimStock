using DimStock.Presenters;
using DimStock.Views;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace DimStock.Screens
{
    public partial class CategoryListingScreen : MetroForm, ICategoryListingView
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public string SearchDescription { get => TextSearchDescription.Text; set => TextSearchDescription.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }

        private CategoryListingPresenter presenter;
    }
}

namespace DimStock.Screens
{
    public partial class CategoryListingScreen
    {
        public CategoryListingScreen()
        {
            InitializeComponent();
            presenter = new CategoryListingPresenter(this);
            InitializeEvents();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            GridListAddButtons(sender, e);
            presenter.SearchData(sender, e);
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            Dispose();
        }
        private void ScreenResize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimerSearch.Enabled = false;
            ImageLoading.Visible = false;
            presenter.SearchData(sender, e);
        }

        private void GridListEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridList.Rows[e.RowIndex].Selected = true;
            }
        }
        private void GridListClick(object sender, DataGridViewCellEventArgs e)
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
                    new CategoryAddScreen(this).ShowDialog();
                    break;

                case "ButtonDelete":
                    presenter.Delete(sender, e);
                    break;
            }

        }
        private void GridListRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        private void GridListSettings(object sender, EventArgs e)
        {
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

            GridList.Columns["ButtonView"].HeaderText = string.Empty;
            GridList.Columns["ButtonView"].Width = 70;

            GridList.Columns["ButtonDelete"].Width = 70;
            GridList.Columns["ButtonDelete"].HeaderText = string.Empty;
        }
        private void GridListAddButtons(object sender, EventArgs e)
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
            GridList.Columns.Add(buttonView);

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
            GridList.Columns.Add(buttonDelete);
        }

        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
            ImageLoading.Visible = true;
        }

        public static void ShowScreen(object sender, EventArgs e)
        {
            var screen = new CategoryListingScreen()
            {
                ShowIcon = false,
                ShowInTaskbar = false,
                ControlBox = false,
                Owner = HomeScreen.He
            };
            screen.ShowDialog();
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            Resize += new EventHandler(ScreenResize);
            GridList.DataSourceChanged += new EventHandler(GridListSettings);
            GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridListEnter);
            GridList.CellClick += new DataGridViewCellEventHandler(GridListClick);
            ButtonNew.Click += new EventHandler(CategoryAddScreen.ShowScreen);
            ButtonUpdateGridList.Click += new EventHandler(TimerTick);
            ButtonCloseScreen.Click += new EventHandler(ScreenClose);
            TimerSearch.Tick += new EventHandler(TimerTick);
            TextSearchDescription.KeyPress += new KeyPressEventHandler(TextKeyPress);
        }
    }
}