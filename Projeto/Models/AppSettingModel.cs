using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Properties;
using System;
using System.Collections.Generic;

namespace DimStock.Models
{
    public class AppSettingModel
    {
        public void PassDataBaseToMainDirectory()
        {
            var filePathToCopy = GetDirectoryOfExe() + @"Resources\dimstockdatabase.mdb";
            var filePathToSave = GetMainAppDirectory() + @"\dimstockdatabase.mdb";

            var fileManager = new AuxiliaryFileManager();

            if (fileManager.CheckIfExists(filePathToCopy) == false)
            {
                fileManager.CopyFromDirectory(filePathToCopy, filePathToSave);
            }
        }

        public void PassBrandLogoToMainDirectory(string filePathToCopy)
        {
            var filePathToSave = GetMainAppDirectory() + @"\CompanyLogo\CompanyLogo.jpg";

            var fileManager = new AuxiliaryFileManager();

            if (fileManager.CheckIfExists(filePathToSave) == false)
            {
                fileManager.CopyFromDirectory(filePathToCopy, filePathToSave);
            }
        }

        public void CreateFoldersMainDirectory()
        {
            var listFolders = new List<string>()
            {
                "DataBaseBackUp",
                "CompanyLogo"
            };

            var rootDirectory = GetMainAppDirectory();

            new AuxiliaryDirectoryManager().CreateFoldersList(rootDirectory, listFolders);
        }

        public void SaveAsMainDirectory(string path)
        {
            Settings.Default.MainAppDirectory = path;
            Settings.Default.Save();
        }

        public static bool GetAppSettingsState()
        {
            return Settings.Default.AppSettingsState;
        }

        public static string GetMainAppDirectory()
        {
            return Settings.Default.MainAppDirectory;
        }
        public static string GetDirectoryOfExe()
        {
            return AppDomain.CurrentDomain.BaseDirectory.ToString();
        }

        public static string GetDataBaseName()
        {
            return Settings.Default.DataBaseName;
        }
        public static string GetConnectionString()
        {
            var connectionString = @"Provider = Microsoft.jet.oledb.4.0; 
            Data Source =" + GetMainAppDirectory() + @"\" + GetDataBaseName() + 
            @";" + @"jet oledb:database password=#admin#";

            return connectionString;
        }

        public static void FinalizeSettings()
        {
            Settings.Default.AppSettingsState = true;
            Settings.Default.Save();
        }
    }
}
