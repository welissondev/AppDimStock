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

        #region Button

        private void SingnIn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserController
                {
                    Login = Login.Text,
                    PassWord = PassWord.Text
                };

                if (user.SignIn() == false)
                {
                    MessageBox.Show(NotificationController.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                UserIdentity.Id = user.Id;
                UserIdentity.Name = user.Name;
                UserIdentity.Login = user.Login;

                Hide();
                using (var homeScreen = new HomeScreenForm())
                {
                    homeScreen.Closed += (s, args) => Close();
                    homeScreen.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
