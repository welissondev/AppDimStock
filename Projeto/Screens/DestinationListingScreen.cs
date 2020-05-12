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
    public partial class DestinationListingScreen : MetroForm, IDestinationListingView
    {
        private static MetroForm thisScreen;

        //São "botões" de link adicionados na coluna do grid
        private DataGridViewLinkColumn buttonViewDetails;
        private DataGridViewLinkColumn buttonDelete;

        //Implementado pela interface de listagem
        public string SearchLocationDescription { get => TextSearchLoctionDescription.Text; set => TextSearchLoctionDescription.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }

        //Implementado pela interface de adição
        public int Id { get; set; }
        public string LocationDescription { get; set; }
    }
}

namespace DimStock.Screens
{
    public partial class DestinationListingScreen
    {
        public DestinationListingScreen()
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
                DestinationAddScreen.ShowScreen(null, this);
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

                LocationDescription = GridList.CurrentRow.
                Cells["LocationDescription"].Value.ToString();

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

                GridList.Columns["LocationDescription"].HeaderText = "Descrição";
                GridList.Columns["LocationDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridList.Columns["LocationDescription"].ReadOnly = true;
                GridList.Columns["LocationDescription"].DisplayIndex = 1;

                GridList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(38, 100, 148);
                GridList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 100, 148);
                GridList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 220, 236);

                GridList.AllowUserToAddRows = false;
                GridList.MultiSelect = false;
                GridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                if (buttonViewDetails == null)
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

                GridList.Columns["ButtonViewDetails"].HeaderText = string.Empty;
                GridList.Columns["ButtonViewDetails"].Width = 70;

                GridList.Columns["ButtonDelete"].Width = 70;
                GridList.Columns["ButtonDelete"].HeaderText = string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void TextSearchKeyPress(object sender, KeyPressEventArgs e)
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

        private void InitializeEvents()
        {
            try
            {
                Load += new EventHandler(ScreenLoad);
                Resize += new EventHandler(ScreenResize);
                GridList.DataSourceChanged += new EventHandler(GridSourceChanged);
                GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridCellEnter);
                GridList.CellClick += new DataGridViewCellEventHandler(GridCellClick);
                GridList.RowPrePaint += new DataGridViewRowPrePaintEventHandler(GridRowPrePaint);
                ButtonNew.Click += new EventHandler(ShowRelatedScreen);
                ButtonListGrid.Click += new EventHandler(PresenterClear);
                ButtonListGrid.Click += new EventHandler(TimerTick);
                ButtonCloseScreen.Click += new EventHandler(ScreenClose);
                ButtonScreenClear.Click += new EventHandler(PresenterClear);
                TimerSearch.Tick += new EventHandler(TimerTick);
                TextSearchLoctionDescription.KeyPress += new KeyPressEventHandler(TextSearchKeyPress);
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

        public static void ShowScreen(Form mdi = null, MetroForm owner = null)
        {
            try
            {
                var screen = new DestinationListingScreen();

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

        //Eventos que chamam métodos do apresentador
        private void PresenterDelete(object sender, EventArgs e)
        {
            try
            {
                new DestinationListingPresenter(this).Delete();
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
                new DestinationListingPresenter(this).GetDetails();
                DestinationAddScreen.SetDetails(this, this);
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
                new DestinationListingPresenter(this).Clear();
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
                new DestinationListingPresenter(this).SearchData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
