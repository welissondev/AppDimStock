using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class UserLoginScreen : Form
    {
        #region Builder
        public UserLoginScreen()
        {
            InitializeComponent();
        }
        #endregion

        #region Get e Set

        public static UserLoginScreen He { get; set; }

        #endregion

        #region UserForm

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            He = this;
        }

        #endregion

        #region Button

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserLoginModel
                {
                    Login = TextLogin.Text,
                    PassWord = TextPassWord.Text
                };

                if (user.SignIn() == false)
                {
                    MessageBox.Show(MessageNotifier.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                UserLoginState.Id = user.Id;
                UserLoginState.Name = user.Name;
                UserLoginState.Login = user.Login;

                HomeScreen.He.Show();

                Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonExists_Click(object sender, EventArgs e)
        {
            Close();
            HomeScreen.He.Close();
        }

        #endregion

        #region Function

        public static void ShowForm()
        {
            var form = new UserLoginScreen();
            form.Show();
        }

        #endregion
    }
}
