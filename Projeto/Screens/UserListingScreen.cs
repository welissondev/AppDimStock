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
        private DataGridViewLinkColumn buttonView;
        private DataGridViewLinkColumn buttonDelete;
        private UserLoginListingPresenter presenter;
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
                InitializePresenter();
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
                    case "ButtonView":
                        presenter.GetDetails(sender, e);
                        UserLoginAddScreen.SetDetails(this);
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

                GridList.Columns["YourName"].HeaderText = "Nome";
                GridList.Columns["YourName"].ReadOnly = true;
                GridList.Columns["YourName"].Width = 280;
                GridList.Columns["YourName"].DisplayIndex = 1;

                GridList.Columns["Login"].HeaderText = "Login";
                GridList.Columns["Login"].ReadOnly = true;
                GridList.Columns["Login"].Width = 150;
                GridList.Columns["Login"].DisplayIndex = 2;

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

        private void ShowParanteScreen(object sender, EventArgs e)
        {
            UserLoginAddScreen.ShowScreen();
        }

        private void InitializeEvents()
        {
            try
            {

                Load += new EventHandler(ScreenLoad);
                Resize += new EventHandler(ScreenResize);
                ButtonNew.Click += new EventHandler(ShowParanteScreen);
                ButtonListGrid.Click += new EventHandler(presenter.SearchData);
                ButtonScreenClear.Click += new EventHandler(presenter.ClearView);
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
        private void InitializePresenter()
        {
            try
            {
                presenter = new UserLoginListingPresenter(this);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
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
    }
}
