using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class UserResgistrationForm : Form
    {
        #region Get & Set

        public static UserResgistrationForm Form { get; set; }

        #endregion

        #region Variables
        private int id = 0;
        #endregion

        #region Constructs

        private UserResgistrationForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Form

        private void UserResgistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form = null;
        }

        #endregion

        #region Button

        private void RegisterNew_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void Save_Click(object sender, EventArgs e)
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

        #region CheckBox

        private void AllPermissions_OnChange(object sender, EventArgs e)
        {
            EnableAllPermissions();
        }

        #endregion 

        #region Methods

        public static void Init()
        {
            if (Form == null)
            {
                var form = new UserResgistrationForm
                {
                    WindowState = FormWindowState.Maximized,
                    MdiParent = HomeScreenForm.Form
                };
                form.Show();

                Form = form;
            }
            else
            {
                Form.WindowState = FormWindowState.Maximized;
                Form.MdiParent = HomeScreenForm.Form;
                Form.Show();
            }
        }

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

                UserName.Select();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void EnableAllPermissions()
        {
            try
            {
                if (AllPermissons.Checked == true)
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Register()
        {
            try
            {
                if (ValidadeData() == true)
                {
                    var user = new User
                    {
                        Name = UserName.Text.TrimStart().TrimEnd(),
                        Email = Email.Text.TrimStart().TrimEnd(),
                        Login = Login.Text.Trim(),
                        PassWord = PassWord.Text.Trim(),
                        PermissionToRegister = PermissionToRegister.Checked,
                        PermissionToEdit = PermissionToEdit.Checked,
                        PermissionToDelete = PermissionToDelete.Checked,
                        PermissionToView = PermissionToView.Checked,
                        AllPermissions = AllPermissons.Checked
                    };

                    if (user.Register() == true)
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Edit()
        {
            try
            {
                if (ValidadeData() == true)
                {
                    var user = new User
                    {
                        Name = UserName.Text,
                        Email = Email.Text,
                        Login = Login.Text,
                        PassWord = PassWord.Text,
                        PermissionToRegister = PermissionToRegister.Checked,
                        PermissionToEdit = PermissionToEdit.Checked,
                        PermissionToDelete = PermissionToDelete.Checked,
                        PermissionToView = PermissionToView.Checked,
                        AllPermissions = AllPermissons.Checked
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public void ViewDetails(int id)
        {
            try
            {
                var user = new User();
                user.ViewDetails(id);

                Form.id = id;
                Form.UserName.Text = user.Name;
                Form.Email.Text = user.Email;
                Form.Login.Text = user.Login;
                Form.PassWord.Text = user.PassWord;
                Form.PassWordConfirmation.Text = user.PassWord;
                Form.PermissionToRegister.Checked = user.PermissionToRegister;
                Form.PermissionToEdit.Checked = user.PermissionToEdit;
                Form.PermissionToDelete.Checked = user.PermissionToDelete;
                Form.PermissionToView.Checked = user.PermissionToView;
                Form.AllPermissons.Checked = user.AllPermissions;
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private bool ValidadeData()
        {
            if (UserName.Text == "")
            {
                MessageBox.Show("O nome é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                UserName.Select();

                return false;
            }

            else if (Email.Text == "")
            {
                MessageBox.Show("E-mail é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Email.Select();

                return false;
            }

            else if (PassWord.Text == "")
            {
                MessageBox.Show("A senha é obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PassWord.Select();

                return false;
            }

            else if (PassWordConfirmation.Text == "")
            {
                MessageBox.Show("Confirme a senha!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PassWordConfirmation.Select();

                return false;
            }

            else if (PassWordConfirmation.Text != PassWord.Text)
            {
                MessageBox.Show("A senhas não conferem!", "NÃO CONFERE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                PassWordConfirmation.Select();

                return false;
            }

            else
            {
                return true;
            }
        }

        private void InitializeSettings()
        {
            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();
        }

        #endregion
    }
}
