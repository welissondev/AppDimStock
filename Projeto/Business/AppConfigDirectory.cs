using System;
using DimStock.Properties;
using System.IO;
using System.Windows.Forms;

namespace DimStock.Business
{
    public class AppConfigDirectory
    {
        public string SelectPath()
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return dialog.SelectedPath;
                }

                return string.Empty;
            }
        }

        public void SavePath(string path)
        {
            Settings.Default.MainAppDirectory = path;
            Settings.Default.Save();
        }

        public void TransferDataBase()
        {
            var copyFrom = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Padrao\dimstock-database.mdb";

            var TransferTo = Settings.Default.MainAppDirectory + @"\dimstock-database.mdb";

            if (CheckIfFileExists(TransferTo) == false)
            {
                File.Copy(copyFrom, TransferTo);
            }
        }

        public void CreateFolders()
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

        public bool CheckIfDirectoryExists(string directoryPath)
        {
            return Directory.Exists(directoryPath).Equals(true);
        }

        public bool CheckIfFileExists(string directoryFile)
        {
            return File.Exists(directoryFile).Equals(true);
        }

        public static void FinalizeSettings()
        {
            Settings.Default.AppSettingsState = true;
            Settings.Default.Save();
        }

        public static bool GetAppSettingsState()
        {
            return Settings.Default.AppSettingsState;
        }
    }
}
