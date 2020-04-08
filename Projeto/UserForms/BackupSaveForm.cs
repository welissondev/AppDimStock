using DimStock.Auxiliarys;
using DimStock.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class BackupSaveForm : Form
    {
        #region Builder

        public BackupSaveForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form
        
        private void BackupSaveForm_Load(object sender, EventArgs e)
        {
            try
            {
                MainTabControl.Appearance = TabAppearance.Normal;
                MainTabControl.ItemSize = new Size(0, 1);
                MainTabControl.SizeMode = TabSizeMode.Fixed;

                TextBackupFolderPath.Text = AppSettingModel.GetMainAppDirectory() + @"\DataBaseBackUp";

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void ButtonGenerateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var appSetting = new AppSettingModel();
                appSetting.SaveBackup();

                MessageBox.Show("Backup gerado com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonOpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Explorer", TextBackupFolderPath.Text);
            }
            catch(Exception ex)
            {
                AxlException.Message.Show(ex);
            }       
        }

        #endregion
    }
}
