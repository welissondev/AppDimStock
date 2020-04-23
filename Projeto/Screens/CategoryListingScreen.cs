using DimStock.Presenters;
using DimStock.Views;
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
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            presenter.SearchData(sender, e);
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            Close();
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

        private void GridCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                GridList.Rows[e.RowIndex].Selected = true;
            }
        }
        private void GridCellClick(object sender, DataGridViewCellEventArgs e)
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
        private void GridRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        private void GridSourceChanged(object sender, EventArgs e)
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

        private void ButtonDelete(object sender, EventArgs e)
        {

        }

        private void TextKeyPress(object sender, KeyPressEventArgs e)
        {
            TimerSearch.Enabled = false;
            TimerSearch.Enabled = true;
            ImageLoading.Visible = true;
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            Resize += new EventHandler(ScreenResize);
            GridList.DataSourceChanged += new EventHandler(GridSourceChanged);
            GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridCellEnter);
            GridList.CellClick += new DataGridViewCellEventHandler(GridCellClick);
            ButtonNew.Click += new EventHandler(new CategoryAddScreen().ShowScreen);
            ButtonUpdateGridList.Click += new EventHandler(TimerTick);
            ButtonCloseScreen.Click += new EventHandler(ScreenClose);
            TimerSearch.Tick += new EventHandler(TimerTick);
            TextSearchDescription.KeyPress += new KeyPressEventHandler(TextKeyPress);
        }
        private void InitializePresenter()
        {
            presenter = new CategoryListingPresenter(this);
        }

        public void ShowScreen(object sender, EventArgs e)
        {
            using (var screen = new CategoryListingScreen())
            {
                ShowIcon = false;
                ShowInTaskbar = false;
                ControlBox = false;
                Owner = HomeScreen.He;
                ShowDialog();
            };
        }
    }
}