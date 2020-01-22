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
                var user = new User()
                {
                    Name = UserName.Text,
                    Email = Email.Text,
                    Login = Login.Text,
                    PassWord = PassWord.Text,
                };

                if(user.CreateNewLogin() == false)
                {
                    MessageBox.Show(MessageNotifier.Message);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
    }
}
