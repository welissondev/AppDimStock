using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class AppSettingsForm : Form
    {
        #region Properties

        private AppSetting appSetting = new AppSetting();

        #endregion

        #region Constructs

        public AppSettingsForm()
        {
            InitializeComponent();

            MainTabControl.Appearance = TabAppearance.Normal;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
        }

        #endregion

        #region Button

        private void ChooseMainDirectory_Click(object sender, EventArgs e)
        {
            var folder = new AxlDirectory();

            var path = folder.SelectPath();

            if (path == string.Empty)
                return;

            MainDirectoryPath.Text = path;
        }

        private void ChooseBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var folderBackup = new AxlDirectory();

                var path = folderBackup.SelectPath();

                if (path == string.Empty)
                    return;

                BackupPath.Text = path;

                var fileList = folderBackup.ListFile(path
                + @"\DataBaseBackUp");

                ListviewBackup.Items.Clear();

                for (int i = 0; i < fileList.Count; i++)
                {
                    var item = new ListViewItem(fileList[i]);
                    ListviewBackup.Items.Add(item);
                }

                appSetting.SaveAsMainDirectory(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao importar o backup, verifique " +
                "se você não esta selecionando o subdiretório da pasta raiz. " +
                "Você deve selecionar o diretório raiz, e deixar que o sistema " +
                "importe as subpastas do diretório automaticamente",
                "Erro Ao Importar");

                BackupPath.Text = string.Empty;
            }
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

        #endregion

        #region PictureBox

        private void CompanyLogoImage_Click(object sender, EventArgs e)
        {
            var logoType = new AxlFile();

            var path = logoType.SelectPath();

            if (path == string.Empty)
                return;

            CompanyLogoImage.ImageLocation = path;
        }

        #endregion

        #region LabelLink

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

                            appSetting.SaveAsMainDirectory(
                            MainDirectoryPath.Text);

                            appSetting.TransferDataBaseToMainDirectory();

                            appSetting.CreateFoldersInTheMainDirectory();

                            MainTabControl.SelectTab(
                            "PageCompanyLogo");

                            break;

                        case "PageCompanyLogo":

                            appSetting.TransferCompanyLogoToMainDirectory(
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

                                AppSetting.FinalizeConfiguration();

                                Application.Restart();
                            }

                            break;
                    }
                }

                if (CheckBoxRestoureBackup.Checked == true)
                {
                    switch (MainTabControl.SelectedTab.Name)
                    {
                        case "PageConfigType":

                            MainTabControl.SelectTab("PageBackUp");
                            BackPage.Visible = true;

                            break;

                        case "PageBackUp":

                            if (ImportBackUp() == true)
                            {
                                MainTabControl.SelectTab("PageFinalize");

                                NextPage.Visible = false;
                                BackPage.Visible = false;

                                LabelPageFinalizeTitle.Text = "Ok, Aguarde Um Instante";
                                LabelPageFinalizeSubTitle.Text = "Estamos importando seus dados...";
                                Await(18000);
                                LabelPageFinalizeTitle.Text = "Importado Com Sucesso!";
                                LabelPageFinalizeSubTitle.Text = "Reiniciando o sistema...";
                                Await(8000);

                                AppSetting.FinalizeConfiguration();

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

            if (CheckBoxRestoureBackup.Checked == true)
            {
                switch (MainTabControl.SelectedTab.Name)
                {
                    case "PageBackUp":

                        MainTabControl.SelectTab("PageConfigType");
                        BackPage.Visible = false;

                        break;
                }
            }
        }

        #endregion

        #region MethodsAuxiliarys
        
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

        private bool ImportBackUp()
        {
            if (ListviewBackup.Items.Count == 0)
            {
                MessageBox.Show("Não foi encontrado arquivos de backup " +
                "a serem restaurados no diretório raiz. Gere um novo" +
                "backup ou faça uma nova configuração!", "Não Encontrado");

                return false;
            }

            var itemSelected = false;
            var dataBaseName = string.Empty;

            for (int i = 0; i < ListviewBackup.Items.Count; i++)
            {
                if (ListviewBackup.Items[i].Selected == true)
                {
                    dataBaseName = ListviewBackup.Items[i].Text;
                    itemSelected = true;
                }
            }

            if (itemSelected == false)
            {
                MessageBox.Show("Selecione um item da lista!",
                "ITEM NÃO SELECIONADO");

                return itemSelected;
            }

            appSetting.ImportBackUp(dataBaseName);

            return true;
        }

        #endregion
    }
}
