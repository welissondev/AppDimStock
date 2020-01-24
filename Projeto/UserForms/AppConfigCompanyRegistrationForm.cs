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
using DimStock.Auxiliarys;

namespace DimStock.UserForms
{
    public partial class AppConfigCompanyRegistrationForm : Form
    {
        public AppConfigCompanyRegistrationForm()
        {
            InitializeComponent();
        }

        private void SalvarSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var company = new Company
                {
                    Name = Company.Text,
                    CPF_CNPJ = CPF_CNPJ.Text,
                    RG_IE = RG_IE.Text,
                    Address = Address.Text,
                    District = District.Text,
                    City = City.Text,
                    State = State.Text,
                    Cep = Cep.Text,
                    StrieetNumber = StrieetNumber.Text
                };

                if (company.Register() == true)
                {
                    AppConfigUserRegistrationForm.ShowForm();
                    Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public static void ShowForm()
        {
            var form = new AppConfigCompanyRegistrationForm()
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
