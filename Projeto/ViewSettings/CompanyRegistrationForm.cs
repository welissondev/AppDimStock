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
    public partial class CompanyRegistrationForm : Form
    {
        public CompanyRegistrationForm()
        {
            InitializeComponent();
        }

        private void SalvarSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var company = new Company
                {
                    Name = CompanyName.Text,
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
                    var form = new LoginRegistrationForm()
                    {
                        MdiParent = MainConfigurationForm.He,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                        ShowInTaskbar = false
                    };

                    form.Show();
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
    }
}
