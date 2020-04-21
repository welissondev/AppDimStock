using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class AppSettingsScreen : Form
    {
        #region Properties

        private AppSettingModel appSetting = new AppSettingModel();

        #endregion

        #region Builder

        public AppSettingsScreen()
        {
            InitializeComponent();

            MainTabControl.Appearance = TabAppearance.Normal;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
        }

        #endregion

        #region Button

        private void ButtonChooseMainDirectory_Click(object sender, EventArgs e)
        {
            var folder = new AuxiliaryDirectoryManager();

            var path = folder.SelectPath();

            if (path == string.Empty)
                return;

            TextMainDirectoryPath.Text = path;
        }

        private void ButtonChooseBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var folderBackup = new AuxiliaryDirectoryManager();

                var path = folderBackup.SelectPath();

                if (path == string.Empty)
                    return;

                TextBackupPath.Text = path;

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

                TextBackupPath.Text = string.Empty;
            }
        }

        private void ButtonCloseAssistant_Click(object sender, EventArgs e)
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

        private void PictureCompanyLogo_Click(object sender, EventArgs e)
        {
            var logoType = new AuxiliaryFileManager();

            var path = logoType.SelectPath("jpeg files|*.jpg");

            if (path == string.Empty)
                return;

            PictureCompanyLogo.ImageLocation = path;
        }

        #endregion

        #region LabelLink

        private void ButtonNextPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (CheckBoxNewConfiguration.Checked == true)
                {
                    switch (MainTabControl.SelectedTab.Name)
                    {
                        case "PageConfigType":

                            MainTabControl.SelectTab("PageChooseDirectory");
                            ButtonBackPage.Visible = true;

                            break;

                        case "PageChooseDirectory":

                            if (TextMainDirectoryPath.Text == string.Empty)
                                return;

                            appSetting.SaveAsMainDirectory(
                            TextMainDirectoryPath.Text);

                            appSetting.PassDataBaseToMainDirectory();

                            appSetting.CreateFoldersMainDirectory();

                            MainTabControl.SelectTab(
                            "PageCompanyLogo");

                            break;

                        case "PageCompanyLogo":

                            if (PictureCompanyLogo.ImageLocation == null)
                            {
                                var path = AppSettingModel.GetDirectoryOfExe() + 
                                @"Resources\DimStockLogoType.png";
                                
                                appSetting.PassBrandLogoToMainDirectory(path);
                            }
                            else
                            {
                                appSetting.PassBrandLogoToMainDirectory(
                                PictureCompanyLogo.ImageLocation);
                            }

                            MainTabControl.SelectTab("PageLogin");

                            break;

                        case "PageLogin":

                            if (RegisterUser() == true)
                            {
                                MainTabControl.SelectTab("PageFinalize");

                                ButtonNextPage.Visible = false;
                                ButtonBackPage.Visible = false;

                                Await(18000);
                                LabelPageFinalizeTitle.Text = "Salvo Com Sucesso!";
                                LabelPageFinalizeSubTitle.Text = "Reiniciando o sistema...";
                                Await(8000);

                                AppSettingModel.FinalizeSettings();

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
                            ButtonBackPage.Visible = true;

                            break;

                        case "PageBackUp":

                            if (ImportBackUp() == true)
                            {
                                MainTabControl.SelectTab("PageFinalize");

                                ButtonNextPage.Visible = false;
                                ButtonBackPage.Visible = false;

                                LabelPageFinalizeTitle.Text = "Ok, Aguarde Um Instante";
                                LabelPageFinalizeSubTitle.Text = "Estamos importando seus dados...";
                                Await(18000);
                                LabelPageFinalizeTitle.Text = "Importado Com Sucesso!";
                                LabelPageFinalizeSubTitle.Text = "Reiniciando o sistema...";
                                Await(8000);

                                AppSettingModel.FinalizeSettings();

                                Application.Restart();
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonBackPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                        ButtonBackPage.Visible = false;

                        break;
                }
            }

            if (CheckBoxRestoureBackup.Checked == true)
            {
                switch (MainTabControl.SelectedTab.Name)
                {
                    case "PageBackUp":

                        MainTabControl.SelectTab("PageConfigType");
                        ButtonBackPage.Visible = false;

                        break;
                }
            }
        }

        #endregion

        #region Function

        private void Await(int time)
        {
            PictureLoading.Visible = true;

            DateTime dateTimeTarget = DateTime.Now.AddMilliseconds(time);

            while (DateTime.Now < dateTimeTarget)
            {
                Application.DoEvents();
            }

            PictureLoading.Visible = false;
        }

        private bool RegisterUser()
        {
            if (TextUserName.Text == string.Empty)
            {
                MessageBox.Show("Informe um nome de usuário!");
                return false;
            }

            if (TextLogin.Text == string.Empty)
            {
                MessageBox.Show("Informe um login de acesso!");
                return false;
            }

            if (TextPassWord.Text == string.Empty)
            {
                MessageBox.Show("Informe uma senha!");
                return false;
            }

            if (TextPasswordConfirmation.Text == string.Empty)
            {
                MessageBox.Show("Confirme a senha!");
                return false;
            }

            if (TextPassWord.Text != TextPasswordConfirmation.Text)
            {
                MessageBox.Show("As senhas não conferem!");
                return false;
            }

            var user = new UserLoginModel()
            {
                Name = TextUserName.Text,
                Email = TextEmail.Text,
                Login = TextLogin.Text,
                PassWord = TextPassWord.Text,
            };

            if (user.CreateNewLogin() == false)
            {
                MessageBox.Show(MessageNotifier.Message);
                return false;
            }

            return true;
        }

        private bool ImportBackUp()
        {
            if (ListviewBackup.Items.Count == 0)
            {
                MessageBox.Show("Não foi encontrado arquivos de backup " +
                "a serem restaurados no diretório raiz. Gere um novo " +
                "backup ou faça uma nova configuração!", "BackUp Não Encontrado");

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
