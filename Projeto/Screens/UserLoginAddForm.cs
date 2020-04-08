using Bunifu.Framework.UI;
using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class UserLoginAddForm : Form
    {
        #region Builder

        public UserLoginAddForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties
        private int id = 0;
        #endregion

        #region Button

        private void ClearFields_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Save();
            }
            else
            {
                Edit();
            }
        }

        #endregion

        #region CheckBox

        private void AllPermissions_OnChange(object sender, EventArgs e)
        {
            EnableAllPermissions();
        }

        #endregion 

        #region Function

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in FrameEditPermission.Controls)
                {
                    Application.DoEvents();
                    if (ctl is BunifuCheckbox)
                        ((BunifuCheckbox)ctl).Checked = false;
                }

                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                    {
                        ctl.Text = "";
                    }
                }

                TextUserName.Select();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void EnableAllPermissions()
        {
            try
            {
                if (CheckAllPermissons.Checked == true)
                {
                    foreach (Control ctl in FrameEditPermission.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = true;
                    }
                }
                else
                {
                    foreach (Control ctl in FrameEditPermission.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void Save()
        {
            try
            {
                if (ValidadeData() == true)
                {
                    var user = new UserLoginModel
                    {
                        Name = TextUserName.Text.TrimStart().TrimEnd(),
                        Email = TextEmail.Text.TrimStart().TrimEnd(),
                        Login = TextLogin.Text.Trim(),
                        PassWord = TextPassWord.Text.Trim(),
                        PermissionToRegister = CheckPermissionToRegister.Checked,
                        PermissionToEdit = CheckPermissionToEdit.Checked,
                        PermissionToDelete = CheckPermissionToDelete.Checked,
                        PermissionToView = CheckPermissionToView.Checked,
                        AllPermissions = CheckAllPermissons.Checked
                    };

                    if (user.Save() == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show(MessageNotifier.Message, "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void Edit()
        {
            try
            {
                if (ValidadeData() == true)
                {
                    var user = new UserLoginModel
                    {
                        Name = TextUserName.Text,
                        Email = TextEmail.Text,
                        Login = TextLogin.Text,
                        PassWord = TextPassWord.Text,
                        PermissionToRegister = CheckPermissionToRegister.Checked,
                        PermissionToEdit = CheckPermissionToEdit.Checked,
                        PermissionToDelete = CheckPermissionToDelete.Checked,
                        PermissionToView = CheckPermissionToView.Checked,
                        AllPermissions = CheckAllPermissons.Checked
                    };

                    if (user.Edit(id) == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MessageNotifier.Message, "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void GetDetail(int id)
        {
            try
            {
                var user = new UserLoginModel();
                user.GetDetail(id);

                id = user.Id;
                this.id = id;
                TextUserName.Text = user.Name;
                TextEmail.Text = user.Email;
                TextLogin.Text = user.Login;
                TextPassWord.Text = user.PassWord;
                TextPassWordConfirmation.Text = user.PassWord;
                CheckPermissionToRegister.Checked = user.PermissionToRegister;
                CheckPermissionToEdit.Checked = user.PermissionToEdit;
                CheckPermissionToDelete.Checked = user.PermissionToDelete;
                CheckPermissionToView.Checked = user.PermissionToView;
                CheckAllPermissons.Checked = user.AllPermissions;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private bool ValidadeData()
        {
            if (TextUserName.Text == "")
            {
                MessageBox.Show("O nome é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextUserName.Select();

                return false;
            }

            else if (TextEmail.Text == "")
            {
                MessageBox.Show("E-mail é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextEmail.Select();

                return false;
            }

            else if (TextPassWord.Text == "")
            {
                MessageBox.Show("A senha é obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextPassWord.Select();

                return false;
            }

            else if (TextPassWordConfirmation.Text == "")
            {
                MessageBox.Show("Confirme a senha!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextPassWordConfirmation.Select();

                return false;
            }

            else if (TextPassWordConfirmation.Text != TextPassWord.Text)
            {
                MessageBox.Show("A senhas não conferem!", "NÃO CONFERE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextPassWordConfirmation.Select();

                return false;
            }

            else
            {
                return true;
            }
        }

        #endregion
    }
}
