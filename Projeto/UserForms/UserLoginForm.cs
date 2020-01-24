using System;
using System.Windows.Forms;
using DimStock.Auxiliarys;
using DimStock.Business;

namespace DimStock.UserForms
{
    public partial class UserLoginForm : Form
    {
        #region Constructs
        public UserLoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Get e Set

        public static UserLoginForm He { get; set; }

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
                    MessageBox.Show(AxlMessageNotifier.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                AxlLogin.Id = user.Id;
                AxlLogin.Name = user.Name;
                AxlLogin.Login = user.Login;

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

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            He = this;
        }

        public static void ShowForm()
        {
            var form = new UserLoginForm();
            form.Show();
        }
    }
}
