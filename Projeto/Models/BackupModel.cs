using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Diagnostics;

namespace DimStock.Models
{
    public class BackupModel
    {
        public string FolderPath { get => AppSettingModel.GetMainAppDirectory() + @"\DataBaseBackUp"; }
        public string FileName { get; set; }

        public BackupModel() { }
        
        public BackupModel(string fileName)
        {
            FileName = fileName;
        }
        
        public void Generate()
        {
            var dataBackup = DateTime.Now.ToString("dd'-'MM'-'yyyy'_'HH'.'mm'.'ss");

            var filePathToCopy = AppSettingModel.GetMainAppDirectory() + @"\" + AppSettingModel.GetDataBaseName();
            var filePathToSave = AppSettingModel.GetMainAppDirectory() + @"\DataBaseBackUp\" + dataBackup + "_dimStockBackup.mdb";

            new AuxiliaryFileManager().CopyFromDirectory(filePathToCopy, filePathToSave);
        }

        public void Restore()
        {
            var filePathToImport = AppSettingModel.GetMainAppDirectory() + @"\DataBaseBackUp\" + FileName;
            var filePathToRestore = AppSettingModel.GetMainAppDirectory() + @"\" + AppSettingModel.GetDataBaseName();

            new AuxiliaryFileManager().CopyFromDirectory(filePathToImport, filePathToRestore);
        }

        public void OpenFolder()
        {
            Process.Start("Explorer", FolderPath);
        }
    }
}
