using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class UserLoginForm : Form
    {
        #region Constructs
        public UserLoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Buttons

        private void SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User
                {
                    Login = Login.Text,
                    PassWord = PassWord.Text
                };

                if (user.SignIn() == false)
                {
                    MessageBox.Show(Notification.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                LoginAssistant.Id = user.Id;
                LoginAssistant.Name = user.Name;
                LoginAssistant.Login = user.Login;

                Hide();
                using (var homeScreen = new HomeScreenForm())
                {
                    homeScreen.Closed += (s, args) => Close();
                    homeScreen.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
