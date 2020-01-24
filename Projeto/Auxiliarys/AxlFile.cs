using System.IO;
using System.Windows.Forms;

namespace DimStock.Auxiliarys
{

    public class AxlFile
    {

        #region Get e Set
        public string DirectoryPath { get; set; }
        #endregion

        #region Methods

        public string GetDirectoryPath()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "jpeg files|*.jpg";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DirectoryPath = openFile.FileName;
                }

                return DirectoryPath;
            }
        }

        public string GetNumberId()
        {
            return System.Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
        }

        public void CopyFromDirectory(string sourcePath, string destPath, bool overwrite = true)
        {
            File.Copy(sourcePath, destPath, overwrite);
        }

        public void DeleteFromDirectory(string path)
        {
            File.Delete(path);
        }

        public bool CheckIfExtits(string path)
        {
            return File.Exists(path).Equals(true);

        }

        #endregion
    }
}
