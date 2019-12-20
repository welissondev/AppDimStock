using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmUserLogin : Form
    {
        #region Constructs
        public FrmUserLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Button

        #region BtnUserAccess_Click()
        private void BtnUserAccess_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new BllUserLogin
                {
                    Login = TxtLogin.Text,
                    PassWord = TxtPassWord.Text
                };

                if (user.Access() == true)
                {
                    AxlLogin.UserId = user.Id;
                    AxlLogin.UserName = user.Name;
                    AxlLogin.Login = user.Login;
                    AxlLogin.PermissionToRegister = user.PermissionToRegister;
                    AxlLogin.PermissionToEdit = user.PermissionToEdit;
                    AxlLogin.PermissionToDelete = user.PermissionToDelete;
                    AxlLogin.PermissionToView = user.PermissionToView;

                    Hide();
                    using (var mdiPrinciapal = new MdlHomeScreen())
                    {
                        mdiPrinciapal.Closed += (s, args) => Close();
                        mdiPrinciapal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(BllNotification.Message, "NÃO ENCONTRADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #endregion
    }
}
