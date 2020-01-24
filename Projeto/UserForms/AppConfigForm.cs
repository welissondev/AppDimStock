using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class AppConfigForm : Form
    {
        public AppConfigForm()
        {
            InitializeComponent();
        }

        //Eventos para nova configuração da aplicação
        private void StartNewConfiguration_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectTab("PageChooseDirectory");
        }

        private void ChooseDirectory_Click(object sender, EventArgs e)
        {
            var folder = new AxlDirectory();

            var path = folder.SelectPath();
            
            if (path == string.Empty)
                return;

            var app = new AppConfig();
            app.SaveAsMainDirectory(path);
            app.TransferDataBaseToMainDirectory();
            app.CreateFoldersInTheMainDirectory();

            MainTabControl.SelectTab("PageCompany");
        }

        private void SaveCompanyData_Click(object sender, EventArgs e)
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
                    MainTabControl.SelectTab("PageLogin");
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ChooseLogo_Click(object sender, EventArgs e)
        {
            var image = new AxlFile();

            var path = image.SelectPath();

            if (path == string.Empty)
                return;

            CompanyLogoImage.ImageLocation = path;
            CompanyLogoPath.Text = path;

            var app = new AppConfig();
            app.TransferCompanyLogoToMainDirectory(path);

            MainTabControl.SelectTab("PageLogin");
        }

        private void SaveUserData_Click(object sender, EventArgs e)
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
                    MessageBox.Show(AxlMessageNotifier.Message);
                    return;
                }

                AppConfig.FinalizeSettings();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        public static void ShowForm()
        {
            var form = new AppConfigForm()
            {
                WindowState = FormWindowState.Maximized
            };

            form.Show();
        }
    }
}
