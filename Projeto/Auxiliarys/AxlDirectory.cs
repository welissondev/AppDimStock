using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DimStock.Auxiliarys
{
    public class AxlDirectory
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

        public bool CheckIfFolderExists(string path)
        {
            return Directory.Exists(path).Equals(true);
        }

        public void CreateNewFolder(string rootDirectory, string folderName)
        {
            var directory = new DirectoryInfo(rootDirectory);
            directory.CreateSubdirectory(folderName);
        }

        public void CreateFoldersList(string rootDirectory, List<string> listFolders)
        {
            for (int i = 0; i < listFolders.Count; i++)
            {
                var folderName = listFolders[i];
                var subDirectory = rootDirectory + @"\" + folderName;

                if (CheckIfFolderExists(subDirectory) == false)
                    CreateNewFolder(rootDirectory, folderName);
            }
        }
    }
}
