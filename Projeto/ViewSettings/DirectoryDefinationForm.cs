﻿using DimStock.Properties;
using DimStock.Auxiliary;
using System;
using System.IO;
using System.Windows.Forms;

namespace DimStock.ViewSettings
{
    public partial class DirectoryDefinationForm : Form
    {
        public DirectoryDefinationForm()
        {
            InitializeComponent();
        }

        private void ExecuteSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedDirectory = SelectDirectoryFolder();

                if (selectedDirectory == string.Empty)
                    return;

                SaveDefaultDirectory(selectedDirectory);

                CopyDataBaseToSelectedPath();

                CreateFoldersInDirectory();

                FormAssistant.CloseAllForms();
                var form = new CompanyRegistrationForm()
                {
                    MdiParent = MainConfigurationForm.He,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    ShowInTaskbar = false
                };

                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveDefaultDirectory(string path)
        {
            Settings.Default.MainAppDirectory = path;
            Settings.Default.Save();
        }

        private void CopyDataBaseToSelectedPath()
        {
            var directorySource = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Padrao\dimstock-database.mdb";
            var directoryPath = Settings.Default.MainAppDirectory + @"\dimstock-database.mdb";

            if (CheckIfFileExists(directoryPath) == false)
            {
                System.IO.File.Copy(directorySource, directoryPath);
            }
        }

        private void CreateFoldersInDirectory()
        {
            //Cria pasta de backUp do banco de dados
            var folderDataBaseBackUp = Settings.Default.MainAppDirectory + @"\DataBaseBackUp";

            if (CheckIfDirectoryExists(folderDataBaseBackUp) == false)
            {
                var root = new DirectoryInfo(Settings.Default.MainAppDirectory);
                root.CreateSubdirectory("DataBaseBackUp");
            }

            //Cria pasta de fotos dos produtos
            var folderProductPhotos = Settings.Default.MainAppDirectory + @"\ProductPhotos";

            if (CheckIfDirectoryExists(folderProductPhotos) == false)
            {
                var root = new DirectoryInfo(Settings.Default.MainAppDirectory);
                root.CreateSubdirectory("ProductPhotos");
            }

            //Cria pasta de fotos das logos da empresa
            var folderCompanyLogo = Settings.Default.MainAppDirectory + @"\CompanyLogo";

            if (CheckIfDirectoryExists(folderCompanyLogo) == false)
            {
                var root = new DirectoryInfo(Settings.Default.MainAppDirectory);
                root.CreateSubdirectory("CompanyLogo");
            }
        }

        private bool CheckIfDirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath).Equals(true);
        }

        private bool CheckIfFileExists(string directoryFile)
        {
            return File.Exists(directoryFile).Equals(true);
        }

        private string SelectDirectoryFolder()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    fieldDataBasePath.Text = selectedPath;

                    return selectedPath;
                }

                return string.Empty;
            }
        }

        private void FinalizeSettings()
        {
            Settings.Default.AppSettingsState = true;
            Settings.Default.Save();
        }
    }
}
