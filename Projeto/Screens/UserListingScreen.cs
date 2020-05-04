using DimStock.AuxilyTools.AuxilyClasses;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using DimStock.Presenters;
using DimStock.Views;
using System.Drawing;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa a tela de listagem de login dos usuários
    /// </summary>
    public partial class UserListingScreen : IUserLoginListingView
    {
        private DataGridViewLinkColumn buttonViewDetails;
        private DataGridViewLinkColumn buttonDelete;
        private static MetroForm thisScreen;

        //Implementados pela interface de adição
        public int Id { get; set; }
        public string YourName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string AccessPassWord { get; set; }
        public string PassWordCheck { get; set; }
        public bool InsertAllowed { get; set; }
        public bool UpdateAllowed { get; set; }
        public bool DeleteAllowed { get; set; }

        //Implementados pela interface de listagem
        public string SearchYourName { get => TextSearchYourName.Text; set => TextSearchYourName.Text = value; }
        public string SearchLogin { get => TextSearchLogin.Text; set => TextSearchLogin.Text = value; }
        public string SearchEmail { get => TextSearchEmail.Text; set => TextSearchEmail.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class UserListingScreen : MetroForm
    {
        public UserListingScreen()
        {
            try
            {
                InitializeComponent();
                InitializeEvents();
                SetScreen();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
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
                UserLoginAddScreen.ShowScreen();
        }

        public static void ShowScreen(Form fatherScreen = null)
        {
            try
            {
                var screen = new UserListingScreen();

                if (fatherScreen != null)
                {
                    screen.MdiParent = fatherScreen;
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
        public static MetroForm GetScreen()
        {
            return thisScreen;
        }

        private void SetScreen()
        {
            thisScreen = this;
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

                YourName = GridList.CurrentRow.
                Cells["YourName"].Value.ToString();

                Login = GridList.CurrentRow.
                Cells["Login"].Value.ToString();

                Email = GridList.CurrentRow.
                Cells["Email"].Value.ToString();

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

                GridList.Columns["YourName"].HeaderText = "Nome";
                GridList.Columns["YourName"].ReadOnly = true;
                GridList.Columns["YourName"].Width = 280;

                GridList.Columns["Login"].HeaderText = "Login";
                GridList.Columns["Login"].ReadOnly = true;
                GridList.Columns["Login"].Width = 150;

                GridList.Columns["Email"].HeaderText = "Email";
                GridList.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridList.Columns["Email"].ReadOnly = true;
                GridList.Columns["Email"].DisplayIndex = 3;

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
                ButtonNew.Click += new EventHandler(ShowRelatedScreen);
                ButtonListGrid.Click += new EventHandler(PresenterSearchData);
                ButtonScreenClear.Click += new EventHandler(PresenterClear);
                ButtonCloseScreen.Click += new EventHandler(ScreenClose);
                GridList.DataSourceChanged += new EventHandler(GridSourceChanged);
                GridList.CellMouseEnter += new DataGridViewCellEventHandler(GridCellEnter);
                GridList.CellClick += new DataGridViewCellEventHandler(GridCellClick);
                TextSearchYourName.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchLogin.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchEmail.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TimerSearch.Tick += new EventHandler(TimerTick);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        //Eventos para chamada dos métodos do apresentador
        private void PresenterDelete(object sender, EventArgs e)
        {
            try
            {
                new UserLoginListingPresenter(this).Delete();
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
                new UserLoginListingPresenter(this).GetDetails();
                UserLoginAddScreen.SetDetails(this);
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
                new UserLoginListingPresenter(this).Clear();
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
                new UserLoginListingPresenter(this).SearchData();
            }
            catch (Exception ex)

            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
