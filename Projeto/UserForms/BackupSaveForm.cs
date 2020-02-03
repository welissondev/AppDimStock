using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class BackupSaveForm : Form
    {
        #region Constructs

        public BackupSaveForm()
        {
            InitializeComponent();
        }

        #endregion

        #region UserForm
        
        private void BackupSaveForm_Load(object sender, EventArgs e)
        {
            try
            {
                MainTabControl.Appearance = TabAppearance.Normal;
                MainTabControl.ItemSize = new Size(0, 1);
                MainTabControl.SizeMode = TabSizeMode.Fixed;

                BackupFolderPath.Text = AppSetting.GetMainAppDirectory() + @"\DataBaseBackUp";

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void GenerateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                var appSetting = new AppSetting();
                appSetting.SaveBackup();

                MessageBox.Show("Backup gerado com sucesso!", "Sucesso");
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void OpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Explorer", BackupFolderPath.Text);
            }
            catch(Exception ex)
            {
                AxlException.Message.Show(ex);
            }       
        }

        #endregion
    }
}
