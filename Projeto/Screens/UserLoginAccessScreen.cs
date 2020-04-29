using System.Windows.Forms;
using DimStock.Views;
using DimStock.Presenters;
using System;
using DimStock.AuxilyTools.AuxilyClasses;
using System.Drawing;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa a tela de acesso do usuário
    /// </summary>
    public partial class UserLoginAccessScreen : Form, IUserLoginAccessView
    {
        private UserLoginAccessPresenter presenter;

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
            InitializePresenter();
            InitializeEvents();
            MaximizeScreen();
        }

        private void ScreenClose(object sender, EventArgs e)
        {
            try
            {
                var homeScreen = HomeScreen.GetScreen();
                if (homeScreen != null)
                    homeScreen.Close();

                Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void UserAccess(object sender, EventArgs e)
        {
            try
            {
                if (presenter.Access(sender, e) == true)
                {
                    var homeScreen = HomeScreen.GetScreen();
                    if (homeScreen != null)
                        homeScreen.Show();

                    Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void MaximizeScreen()
        {
            try
            {
                Width = Screen.PrimaryScreen.Bounds.Width;
                Height = Screen.PrimaryScreen.Bounds.Height - 40;
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
                presenter = new UserLoginAccessPresenter(this);
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
                ButtonEnter.Click += new EventHandler(UserAccess);
                ButtonExit.Click += new EventHandler(ScreenClose);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
