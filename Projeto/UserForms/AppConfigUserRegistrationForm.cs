using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliarys;

namespace DimStock.UserForms
{
    public partial class AppConfigUserRegistrationForm : Form
    {
        public AppConfigUserRegistrationForm()
        {
            InitializeComponent();
        }

        private void SalvarSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text == string.Empty)
                {
                    MessageBox.Show("Informe um nome de usuário!");
                    return;
                }

                if (Login.Text == string.Empty)
                {
                    MessageBox.Show("Informe um login de acesso!");
                    return;
                }

                if (PassWord.Text == string.Empty)
                {
                    MessageBox.Show("Informe uma senha!");
                    return;
                }

                if (PassWordConfirmation.Text == string.Empty)
                {
                    MessageBox.Show("Confirme a senha!");
                    return;
                }

                if (PassWord.Text != PassWordConfirmation.Text)
                {
                    MessageBox.Show("As senhas não conferem!");
                    return;
                }

                var user = new User()
                {
                    Name = UserName.Text,
                    Email = Email.Text,
                    Login = Login.Text,
                    PassWord = PassWord.Text,
                };

                if (user.CreateNewLogin() == false)
                {
                    MessageBox.Show(MessageNotifier.Message);
                    return;
                }

                AppConfigFinalizationForm.ShowForm();

                Close();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public static void ShowForm()
        {
            var form = new AppConfigUserRegistrationForm()
            {
                MdiParent = AppConfigHomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };

            form.Show();
        }
    }
}
