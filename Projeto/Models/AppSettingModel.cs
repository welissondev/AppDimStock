using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Properties;
using System;
using System.Collections.Generic;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de configuração da aplicação
    /// </summary>
    public class AppSettingModel
    {
        public void PassDataBaseToMainDirectory()
        {
            var sourcePath = GetDirectoryOfExe() +
            @"Resources\dimstockdatabase.mdb";

            var destPath = Settings.Default.MainAppDirectory +
            @"\dimstockdatabase.mdb";

            var dataBase = new AuxiliaryFileManager();

            if (dataBase.CheckIfExists(destPath) == false)
                dataBase.CopyFromDirectory(sourcePath, destPath);
        }
        public void PassBrandLogoToMainDirectory(string sourcePath)
        {
            var destPath = GetMainAppDirectory() + @"\CompanyLogo\CompanyLogo.jpg";

            var logoImage = new AuxiliaryFileManager();

            if (logoImage.CheckIfExists(destPath) == false)
                logoImage.CopyFromDirectory(
                sourcePath, destPath);
        }

        public void SaveBackup()
        {
            var backup = new AuxiliaryFileManager();

            var day = DateTime.Now.Day;
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;

            var hor = DateTime.Now.Hour;
            var min = DateTime.Now.Minute;
            var sec = DateTime.Now.Second;

            var date = day + "." + month + "." + year;

            var hour = hor + "." + min + "." + sec;

            var sourcePath = GetMainAppDirectory() + @"\" + GetDataBaseName();

            var destPath = GetMainAppDirectory() + @"\DataBaseBackUp\dimStockBackup "
            + date + " " + hour + ".mdb";

            backup.CopyFromDirectory(sourcePath, destPath);
        }
        public void ImportBackUp(string dataBaseBackUpName)
        {
            var sourcePath = GetMainAppDirectory() + @"\DataBaseBackUp\" + dataBaseBackUpName;

            var destPath = GetMainAppDirectory() + @"\" + GetDataBaseName();

            var backup = new AuxiliaryFileManager();

            backup.CopyFromDirectory(sourcePath, destPath);
        }

        public void CreateFoldersMainDirectory()
        {
            var directory = new AuxiliaryDirectoryManager();

            var listFolders = new List<string>()
            {
                "DataBaseBackUp",
                "CompanyLogo"
            };

            var rootDirectory = GetMainAppDirectory();

            directory.CreateFoldersList(
            rootDirectory, listFolders);
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
            var connectionString = @"Provider = Microsoft.jet.oledb.4.0; Data Source =" +
            GetMainAppDirectory() + @"\" + GetDataBaseName() + @";" +
            @"jet oledb:database password=#admin#";

            return connectionString;
        }

        public void SaveAsMainDirectory(string path)
        {
            Settings.Default.MainAppDirectory = path;
            Settings.Default.Save();
        }

        public static void FinalizeSettings()
        {
            Settings.Default.AppSettingsState = true;
            Settings.Default.Save();
        }
    }
}
