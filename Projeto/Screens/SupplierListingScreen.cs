using MetroFramework.Forms;
using DimStock.Views;
using System;
using MetroFramework;
using DimStock.Presenters;
using DimStock.AuxilyTools.AuxilyClasses;
using System.Windows.Forms;
using System.Drawing;

namespace DimStock.Screens
{
    public partial class SupplierListingScreen : ISupplierListingView
    {
        private static MetroForm thisScreen;

        private DataGridViewLinkColumn buttonViewDetails;
        private DataGridViewLinkColumn buttonDelete;

        public int Id { get; set; }
        public string TypeOfRegistration { get; set; }
        public string YourName { get; set; }
        public string FantasyName { get; set; }
        public string IndentyCard_StateRegister { get; set; }
        public string SocialSecurity_NationalRegister { get; set; }
        public string AddressDescription { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string StateLocation { get; set; }
        public string ZipCode { get; set; }
        public int StreetNumber { get; set; }
        public string FixePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }

        public string SearchTypeOfRegistration { get; set; }
        public string SearchYourName { get => TextSearchYourName.Text; set => TextSearchYourName.Text = value; }
        public string SearchIndentyCard_StateRegister { get => TextSearchIndentyCard_StateRegister.Text; set => TextSearchIndentyCard_StateRegister.Text = value; }
        public string SearchSocialSecurity_NationalRegister { get => TextSearchSocialSecurity_NationalRegister.Text; set => TextSearchSocialSecurity_NationalRegister.Text = value; }
        public string SearchEmail { get => TextSearchEmail.Text; set => TextSearchEmail.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class SupplierListingScreen : MetroForm
    {
        public SupplierListingScreen()
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
                SupplierAddScreen.ShowScreen(null, this);
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

                GridList.Columns["typeOfRegistration"].HeaderText = "Tipo";
                GridList.Columns["typeOfRegistration"].ReadOnly = true;
                GridList.Columns["typeOfRegistration"].DisplayIndex = 1;
                GridList.Columns["typeOfRegistration"].Width = 70;

                GridList.Columns["YourName"].HeaderText = "Descrição";
                GridList.Columns["YourName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridList.Columns["YourName"].ReadOnly = true;
                GridList.Columns["YourName"].DisplayIndex = 2;

                GridList.Columns["indentyCard_stateRegister"].HeaderText = "RG/IE";
                GridList.Columns["indentyCard_stateRegister"].ReadOnly = true;
                GridList.Columns["indentyCard_stateRegister"].DisplayIndex = 3;
                GridList.Columns["indentyCard_stateRegister"].Width = 160;


                GridList.Columns["socialSecurity_nationalRegister"].HeaderText = "CPF/CNPJ";
                GridList.Columns["socialSecurity_nationalRegister"].ReadOnly = true;
                GridList.Columns["socialSecurity_nationalRegister"].DisplayIndex = 4;
                GridList.Columns["socialSecurity_nationalRegister"].Width = 160;

                GridList.Columns["email"].HeaderText = "Email";
                GridList.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                GridList.Columns["email"].ReadOnly = true;
                GridList.Columns["email"].DisplayIndex = 5;
                GridList.Columns["email"].Width = 420;

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
                ButtonListGrid.Click += new EventHandler(TimerTick);
                ButtonListGrid.Click += new EventHandler(PresenterClear);
                ButtonClose.Click += new EventHandler(ScreenClose);
                ButtonClose.Click += new EventHandler(PresenterClear);
                TimerSearch.Tick += new EventHandler(TimerTick);
                TextSearchYourName.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchEmail.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchIndentyCard_StateRegister.KeyPress += new KeyPressEventHandler(TextKeyPress);
                TextSearchSocialSecurity_NationalRegister.KeyPress += new KeyPressEventHandler(TextKeyPress);
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
                var screen = new SupplierListingScreen();

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
                new SupplierListingPresenter(this).Delete();
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
                new SupplierListingPresenter(this).GetDetails();
                SupplierAddScreen.SetDetails(this, this);
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
                new SupplierListingPresenter(this).Clear();
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
                new SupplierListingPresenter(this).SearchData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
