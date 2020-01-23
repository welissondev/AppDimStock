using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;
using DimStock.Properties;
using DimStock.AppSettings;

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
                    MessageBox.Show(MessageNotifier.Message, "NÃO ENCONTRADO",
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

        private bool CheckAppConfigurationState()
        {
            return Settings.Default.AppSettingsState.Equals(true);
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            He = this;

            if(CheckAppConfigurationState() == false)
            {
                Hide();
                var form = new MainConfigurationForm();
                form.Show();
            }
        }
    }
}
