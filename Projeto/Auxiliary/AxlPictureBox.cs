using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{
    public class AxlPictureBox : PictureBox
    {
        private string arquivoDiretorioSelecionado = "";
        public string ArquivoDiretorioSelecionado
        {
            get { return arquivoDiretorioSelecionado; }
            set { arquivoDiretorioSelecionado = value; }
        }
        
        private string fotoNome = "";
        public string FotoNome
        {
            get { return fotoNome; }
            set { fotoNome = value; }
        }

        private string ultimaFoto = "";

        /// <summary>
        /// OldPhoto ou "Foto Antiga", guarda o caminho da última foto registrada na pasta diretório.
        /// </summary>
        public string UltimaFoto
        {
            get { return ultimaFoto; }
            set { ultimaFoto = value; }
        }
    }
}
