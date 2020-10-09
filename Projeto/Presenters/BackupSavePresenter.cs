using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class BackupSavePresenter
    {
        IBackupSaveView view;

        public  BackupSavePresenter(IBackupSaveView view)
        {
            this.view = view;
        }

        public void Generate()
        {
            new BackupModel().Generate();
        }

        public void GetFolderPath()
        {
            view.FolderPath = new BackupModel().FolderPath;
        }

        public void OpenFolder()
        {
            new BackupModel().OpenFolder();
        }
    }
}
