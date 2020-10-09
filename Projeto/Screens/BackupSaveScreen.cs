using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Presenters;
using DimStock.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class BackupSaveScreen : Form, IBackupSaveView
    {
        public string FolderPath { get => TextFolderPath.Text; set => TextFolderPath.Text = value; }
    }
}

namespace DimStock.Screens
{
    public partial class BackupSaveScreen
    {
        public BackupSaveScreen()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
                ConfigureTabeControl();
                PresenterGetFolderPath(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void InitializeEvents()
        {
            try
            {
                Load += new EventHandler(ScreenLoad);
                ButtonGenerate.Click += new EventHandler(PresenterGenerate);
                ButtonOpenFolder.Click += new EventHandler(PresenterOpenFolder);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ConfigureTabeControl()
        {
            MainTabControl.Appearance = TabAppearance.Normal;
            MainTabControl.ItemSize = new Size(0, 1);
            MainTabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void PresenterOpenFolder(object sender, EventArgs e)
        {
            try
            {
                new BackupSavePresenter(this).OpenFolder();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterGenerate(object sender, EventArgs e)
        {
            try
            {
                new BackupSavePresenter(this).Generate();

                MessageBox.Show("Backup gerado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterGetFolderPath(object sender, EventArgs e)
        {
            new BackupSavePresenter(this).GetFolderPath();
        }
    }
}
