using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmUserRegister : Form
    {
        #region Variables
        private readonly int id = 0;
        #endregion

        #region Constructs
        public FrmUserRegister()
        {
            InitializeComponent();

            LblToDayIsDay.Text = DateTime.Now.ToLongDateString();
        }

        public FrmUserRegister(int id)
        {
            InitializeComponent();

            LblToDayIsDay.Text = DateTime.Now.ToLongDateString();

            this.id = id;
        }
        #endregion

        #region Button

        #region BtnNew_Click()
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
        #endregion 

        #region BtnSave_Click()
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Register();
            }
            else
            {
                Edit();
            }
        }
        #endregion

        #endregion

        #region CheckBox

        #region ChkAllPermissions_OnChange()
        private void ChkAllPermissions_OnChange(object sender, EventArgs e)
        {
            EnableAllPermissions();
        }
        #endregion 

        #endregion 

        #region Methods

        #region ResetControls()
        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in GbxEditPermission.Controls)
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

                TxtName.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region EnableAllPermissions()
        private void EnableAllPermissions()
        {
            try
            {
                if (ChkAllPermissions.Checked == true)
                {
                    foreach (Control ctl in GbxEditPermission.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = true;
                    }
                }
                else
                {
                    foreach (Control ctl in GbxEditPermission.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Register()
        private void Register()
        {
            try
            {
                if (ValidateInputData() == true)
                {
                    var user = new BllUserLogin
                    {
                        Name = TxtName.Text.TrimStart().TrimEnd(),
                        Email = TxtEmail.Text.TrimStart().TrimEnd(),
                        Login = TxtLogin.Text.Trim(),
                        PassWord = TxtPassWord.Text.Trim(),
                        PermissionToRegister = ChkPermissionToRegister.Checked,
                        PermissionToEdit = ChkPermissionToEdit.Checked,
                        PermissionToDelete = ChkPermissionToDelete.Checked,
                        PermissionToView = ChkPermissionToView.Checked,
                        AllPermissions = ChkAllPermissions.Checked
                    };

                    if (user.Register() == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ResetControls();
                    }
                    else
                    {
                        MessageBox.Show(BllNotification.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Edit()
        private void Edit()
        {
            try
            {
                if (ValidateInputData() == true)
                {
                    var user = new BllUserLogin
                    {
                        Name = TxtName.Text,
                        Email = TxtEmail.Text,
                        Login = TxtLogin.Text,
                        PassWord = TxtPassWord.Text,
                        PermissionToRegister = ChkPermissionToRegister.Checked,
                        PermissionToEdit = ChkPermissionToEdit.Checked,
                        PermissionToDelete = ChkPermissionToDelete.Checked,
                        PermissionToView = ChkPermissionToView.Checked,
                        AllPermissions = ChkAllPermissions.Checked
                    };

                    if (user.Edit(id) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(BllNotification.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ValidateInputData()
        private bool ValidateInputData()
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("O nome é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtName.Select();

                return false;
            }

            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("E-mail é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtEmail.Select();

                return false;
            }

            else if (ValidateEmail(TxtEmail.Text).Equals(false))
            {
                MessageBox.Show("O email informado não é válido, verifique " +
                "e tente novamente! ", "EMAIL INVÁLIDO", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                TxtEmail.Select();

                return false;

            }
            else if (TxtPassWord.Text == "")
            {
                MessageBox.Show("A senha é obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtPassWord.Select();

                return false;
            }

            else if (TxtConfirmPassWord.Text == "")
            {
                MessageBox.Show("Confirme a senha!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtConfirmPassWord.Select();

                return false;
            }

            else if (TxtConfirmPassWord.Text != TxtPassWord.Text)
            {
                MessageBox.Show("A senhas não conferem!", "NÃO CONFERE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtConfirmPassWord.Select();

                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region ValidateEmail()
        private bool ValidateEmail(string email)
        {
            var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 

        #endregion
    }
}
