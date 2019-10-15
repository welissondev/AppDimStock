using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{

    public class AxlImage 
    {

        #region Get e Set
        public string DirectoryFile { get; set; }
        #endregion

        #region Métodos
        /// <summary>
        /// OpenFileDialog() Ou "Caixa de diálogo abrir arquivo", exibe caixa de diálago para selecionar arquivo.
        /// </summary>
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

        /// <summary>
        /// Gerar código guid
        /// </summary>
        public string GenerateGuidCode()
        {
            return System.Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
        }

        /// <summary>
        /// Copiar para o diretório
        /// </summary>
        public void CopyToDirectory(string dirSource, string dirDest)
        {
            System.IO.File.Copy(dirSource, dirDest, true);
        }

        /// <summary>
        /// Excluir do diretório
        /// </summary>
        public void DeleteFromDirectory(string dir)
        {
            System.IO.File.Delete(dir);
        }

        /// <summary>
        /// Verificar arquivo no diretório
        /// </summary>
        public bool CheckFileInDirectory(string dir)
        {
            return System.IO.File.Exists(dir).Equals(true);

        }
        #endregion
    }
}
