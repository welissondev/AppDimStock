using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class AppConfigForm : Form
    {
        AppConfig app = new AppConfig();

        public AppConfigForm()
        {
            InitializeComponent();

            MainTabControl.Appearance = TabAppearance.Normal;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void ChooseMainDirectory_Click(object sender, EventArgs e)
        {
            var folder = new AxlDirectory();

            var path = folder.SelectPath();

            if (path == string.Empty)
                return;

            MainDirectoryPath.Text = path;
        }

        private void CompanyLogoImage_Click(object sender, EventArgs e)
        {
            var logoType = new AxlFile();

            var path = logoType.SelectPath();

            if (path == string.Empty)
                return;

            CompanyLogoImage.ImageLocation = path;
        }

        private void CloseAssistant_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar?", "IMPORTANTE",
            MessageBoxButtons.YesNo, MessageBoxIcon.None,
            MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void NextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (CheckBoxNewConfiguration.Checked == true)
                {
                    switch (MainTabControl.SelectedTab.Name)
                    {
                        case "PageConfigType":

                            MainTabControl.SelectTab("PageChooseDirectory");
                            BackPage.Visible = true;

                            break;

                        case "PageChooseDirectory":

                            if (MainDirectoryPath.Text == string.Empty)
                                return;

                            app.SaveAsMainDirectory(MainDirectoryPath.Text);

                            app.TransferDataBaseToMainDirectory();

                            app.CreateFoldersInTheMainDirectory();

                            MainTabControl.SelectTab("PageCompanyLogo");

                            break;

                        case "PageCompanyLogo":

                            app.TransferCompanyLogoToMainDirectory(
                            CompanyLogoImage.ImageLocation);

                            MainTabControl.SelectTab("PageLogin");

                            break;

                        case "PageLogin":

                            if (RegisterUser() == true)
                            {
                                MainTabControl.SelectTab("PageFinalize");

                                NextPage.Visible = false;

                                BackPage.Visible = false;

                                Await(18000);

                                LabelPageFinalizeTitle.Text = "Salvo Com Sucesso!";

                                LabelPageFinalizeSubTitle.Text = "Reiniciando o sistema...";

                                Await(8000);

                                AppConfig.FinalizeSettings();

                                Application.Restart();
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void BackPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckBoxNewConfiguration.Checked == true)
            {
                switch (MainTabControl.SelectedTab.Name)
                {
                    case "PageLogin":

                        MainTabControl.SelectTab("PageCompanyLogo");

                        break;

                    case "PageCompanyLogo":

                        MainTabControl.SelectTab("PageChooseDirectory");

                        break;


                    case "PageChooseDirectory":

                        MainTabControl.SelectTab("PageConfigType");
                        BackPage.Visible = false;

                        break;
                }
            }
        }

        private void Await(int time)
        {
            Loading.Visible = true;

            DateTime dateTimeTarget = DateTime.Now.AddMilliseconds(time);

            while (DateTime.Now < dateTimeTarget)
            {
                Application.DoEvents();
            }

            Loading.Visible = false;
        }

        private bool RegisterUser()
        {
            if (UserName.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome de usuário!");
                return false;
            }

            if (Login.Text == string.Empty)
            {
                MessageBox.Show("Informe um login de acesso!");
                return false;
            }

            if (PassWord.Text == string.Empty)
            {
                MessageBox.Show("Informe uma senha!");
                return false;
            }

            if (PassWordConfirmation.Text == string.Empty)
            {
                MessageBox.Show("Confirme a senha!");
                return false;
            }

            if (PassWord.Text != PassWordConfirmation.Text)
            {
                MessageBox.Show("As senhas não conferem!");
                return false;
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
                return false;
            }

            return true;
        }
    }
}
