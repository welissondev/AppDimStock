using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.View;
using DimStock.Properties;

namespace DimStock.ViewSettings
{
    public partial class LoginRegistrationForm : Form
    {
        public LoginRegistrationForm()
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

                Close();

               
                UserLoginForm.He.Show();

                MainConfigurationForm.He.Close();

                Settings.Default.AppSettingsState = true;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
    }
}
