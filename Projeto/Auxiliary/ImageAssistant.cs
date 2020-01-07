using System.Windows.Forms;

namespace DimStock.Auxiliary
{

    public class ImageAssistant 
    {

        #region Get e Set
        public string DirectoryFile { get; set; }
        #endregion

        #region Methods

        public void OpenFileDialog()
        {
            using (OpenFileDialog openFile = new OpenFileDialog())    
            {
                openFile.Filter = "jpeg files|*.jpg";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DirectoryFile = openFile.FileName;
                }
                else
                {
                    DirectoryFile = "";
                }   
            }
        }

        public string GenerateGuidCode()
        {
            return System.Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
        }

        public void CopyToDirectory(string dirSource, string dirDest)
        {
            System.IO.File.Copy(dirSource, dirDest, true);
        }

        public void DeleteFromDirectory(string dir)
        {
            System.IO.File.Delete(dir);
        }

        public bool CheckFileInDirectory(string dir)
        {
            return System.IO.File.Exists(dir).Equals(true);

        }

        #endregion
    }
}
