using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Windows.Forms;

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

        #region UserForm

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            He = this;
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
                    MessageBox.Show(AxlMessageNotifier.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                AxlLogin.Id = user.Id;
                AxlLogin.Name = user.Name;
                AxlLogin.Login = user.Login;

                HomeScreenForm.He.Show();

                Close();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Exists_Click(object sender, EventArgs e)
        {
            Close();
            HomeScreenForm.He.Close();
        }

        #endregion

        #region MethodsAuxiliarys

        public static void ShowForm()
        {
            var form = new UserLoginForm();
            form.Show();
        }

        #endregion
    }
}
