using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa a tela de acesso do usuário
    /// </summary>
    public partial class UserLoginAccessScreen : Form, IUserLoginAccessView
    {
        public int Id { get; set; }
        public string YourName { get; set; }
        public string Email { get; set; }
        public string Login { get => TextLogin.Text; set => TextLogin.Text = value; }
        public string AccessPassWord { get => TextPassWord.Text; set => TextPassWord.Text = value; }
        public string PassWordCheck { get; set; }
        public bool InsertAllowed { get; set; }
        public bool UpdateAllowed { get; set; }
        public bool DeleteAllowed { get; set; }
    }
}

namespace DimStock.Screens
{
    public partial class UserLoginAccessScreen
    {
        public UserLoginAccessScreen()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void ShowRelatedScreen(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(ButtonEnter))
                    PresenterResquestAccess(sender, e);
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
                ButtonEnter.Click += new EventHandler(ShowRelatedScreen);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static void ShowScreen(Form mdi = null, MetroForm owner = null)
        {
            try
            {
                var screen = new UserLoginAccessScreen();

                if (mdi != null)
                {
                    screen.MdiParent = mdi;
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.Dock = DockStyle.Fill;
                    screen.FormBorderStyle = FormBorderStyle.None;
                    screen.BuniTransation.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
                    screen.BuniTransation.Show(screen);
                    screen.BackgroundImage = Properties.Resources.ImageScreenLoginBackgroud;
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        //Eventos para chamada dos métodos do apresentador
        private void PresenterResquestAccess(object sender, EventArgs e)
        {
            if (new UserLoginAccessPresenter(this).ResquestAccess() == true)
            {
                Close();
                HomeScreen.GetScreen().ShowMenuPanel();
            }
        }
    }
}
