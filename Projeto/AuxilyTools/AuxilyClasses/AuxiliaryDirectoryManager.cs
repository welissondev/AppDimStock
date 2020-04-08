using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    /// <summary>
    /// Pode executar e gerenciar atividades de manipulação para um diretório
    /// como por exemplo, criar pastas em um diretório especificado
    /// </summary>
    public class AuxiliaryDirectoryManager
    {
        public string SelectPath()
        {
            FolderBrowserDialog dialog;
            string path = string.Empty;

            using (dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                    path = dialog.SelectedPath;
            }

            return path;
        }

        public bool CheckIfFolderExists(string path)
        {
            return Directory.Exists(path).Equals(true);
        }

        public void CreateNewFolder(string path, string folderName)
        {
            var directory = new DirectoryInfo(path);
            directory.CreateSubdirectory(folderName);
        }

        public void CreateFoldersList(string path, List<string> listFolders)
        {
            for (int i = 0; i < listFolders.Count; i++)
            {
                var folderName = listFolders[i];
                var subDirectory = path + @"\" + folderName;

                if (CheckIfFolderExists(subDirectory) == false)
                    CreateNewFolder(path, folderName);
            }
        }

        public List<string> ListFile(string path)
        {
            var folder = new DirectoryInfo(path);

            FileInfo[] files = folder.GetFiles("*.*");

            var list = new List<string>();

            foreach (FileInfo fileinfo in files)
            {
                list.Add(fileinfo.Name);
            }

            return list;
        }
    }
}
