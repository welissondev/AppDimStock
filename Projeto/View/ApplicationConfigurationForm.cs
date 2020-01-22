using DimStock.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class ApplicationConfigurationForm : Form
    {
        public ApplicationConfigurationForm()
        {
            InitializeComponent();
        }

        private void StartNewConfiguration_Click(object sender, EventArgs e)
        {
            TabControlConfigureMenege.SelectedIndex = 1;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveDefaultDirectory(string path)
        {
            Settings.Default.ApplicationFileDirectory = path;
            Settings.Default.ProductPhotosDirectory = path;
            Settings.Default.CompanyLogoDirectory = path;
            Settings.Default.Save();
        }

        private void CopyDataBaseToSelectedPath()
        {
            var directorySource = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Padrao\dbestoque.mdb";
            var directoryPath = Settings.Default.ApplicationFileDirectory + @"\dimstock-database.mdb";

            if (CheckIfFileExists(directoryPath) == false)
            {
                System.IO.File.Copy(directorySource, directoryPath);
            }
        }

        private void CopyCompanyLogoToSelectedPath()
        {

        }

        private void CreateFoldersInDirectory()
        {
            //Cria pasta de backUp do banco de dados
            var folderDataBaseBackUp = Settings.Default.ApplicationFileDirectory + @"\DataBaseBackUp";

            if (CheckIfDirectoryExists(folderDataBaseBackUp) == false)
            {
                var root = new DirectoryInfo(Settings.Default.ApplicationFileDirectory);
                root.CreateSubdirectory("DataBaseBackUp");
            }

            //Cria pasta de fotos dos produtos
            var folderProductPhotos = Settings.Default.ApplicationFileDirectory + @"\ProductPhotos";

            if (CheckIfDirectoryExists(folderProductPhotos) == false)
            {
                var root = new DirectoryInfo(Settings.Default.ApplicationFileDirectory);
                root.CreateSubdirectory("ProductPhotos");
            }

            //Cria pasta de fotos das logos da empresa
            var folderCompanyLogo = Settings.Default.ApplicationFileDirectory + @"\CompanyLogo";

            if (CheckIfDirectoryExists(folderCompanyLogo) == false)
            {
                var root = new DirectoryInfo(Settings.Default.ApplicationFileDirectory);
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

        private string SelectFilePath()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "jpeg files|*.jpg";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    return openFile.FileName;
                }

                return string.Empty;
            }
        }
    }
}
