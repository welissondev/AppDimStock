using System.IO;
using System.Windows.Forms;

namespace DimStock.AuxilyTools
{
    /// <summary>
    /// Pode executar e gerencia atividades de manipulação para um arquivo
    /// como por exemplo, deletar o arquivo de um diretório especificado
    /// </summary>
    public class AuxiliaryFileManager
    {
        public string SelectPath(string fileType)
        {
            OpenFileDialog openFile;
            string path = string.Empty;

            using (openFile = new OpenFileDialog())
            {
                if (fileType != string.Empty)
                    openFile.Filter = fileType;

                if(openFile.ShowDialog() == DialogResult.OK)
                    path = openFile.FileName;
            }

            return path;
        }

        public string GetNumberId()
        {
            return System.Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
        }

        public void CopyFromDirectory(string sourcePath, string destPath, bool overwrite = true)
        {
            if (CheckIfExists(sourcePath) == true)
                File.Copy(sourcePath, destPath, overwrite);
        }

        public void DeleteFromDirectory(string path)
        {
            File.Delete(path);
        }

        public bool CheckIfExists(string path)
        {
            return File.Exists(path).Equals(true);
        }
    }
}
