using DimStock.Auxiliarys;
using DimStock.Properties;
using System;
using System.Collections.Generic;

namespace DimStock.Models
{
    public class AppSetting
    {
        public void TransferDataBaseToMainDirectory()
        {
            var sourcePath = GetDirectoryOfExe() +
            @"Resources\dimstockdatabase.mdb";

            var destPath = Settings.Default.MainAppDirectory +
            @"\dimstockdatabase.mdb";

            var dataBase = new AxlFile();

            if (dataBase.CheckIfExists(destPath) == false)
                dataBase.CopyFromDirectory(sourcePath, destPath);
        }

        public void TransferCompanyLogoToMainDirectory(string sourcePath)
        {
            var destPath = GetMainAppDirectory() + @"\CompanyLogo\CompanyLogo.jpg";

            var logoImage = new AxlFile();

            if (logoImage.CheckIfExists(destPath) == false)
                logoImage.CopyFromDirectory(
                sourcePath, destPath);
        }

        public void SaveBackup()
        {
            var backup = new AxlFile();

            var day = DateTime.Now.Day;
            var month = DateTime.Now.Month;
            var year = DateTime.Now.Year;

            var hor = DateTime.Now.Hour;
            var min = DateTime.Now.Minute;
            var sec = DateTime.Now.Second;

            var date = day + "." + month + "." + year;

            var hour = hor + "." + min + "." + sec;

            var sourcePath = GetMainAppDirectory() + @"\dimstockdatabase.mdb";

            var destPath = GetMainAppDirectory() + @"\DataBaseBackUp\dimStockBackup " 
            + date + " " + hour + ".mdb";

            backup.CopyFromDirectory(sourcePath, destPath);
        }

        public void ImportBackUp(string dataBaseBackUpName)
        {
            var sourcePath = GetMainAppDirectory() + @"\DataBaseBackUp\" + dataBaseBackUpName;

            var destPath = GetMainAppDirectory() + @"\dimstockdatabase.mdb";

            var backup = new AxlFile();

            backup.CopyFromDirectory(sourcePath, destPath);
        }

        public void CreateFoldersInTheMainDirectory()
        {
            var directory = new AxlDirectory();

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

        public void SaveAsMainDirectory(string path)
        {
            Settings.Default.MainAppDirectory = path;
            Settings.Default.Save();
        }

        public static void FinalizeConfiguration()
        {
            Settings.Default.AppSettingsState = true;
            Settings.Default.Save();
        }
    }
}
