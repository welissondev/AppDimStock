using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SysEstoque.AXL
{
    /// <summary>
    /// Uma classe statica para manipulação de imagens que pode ser usada globalmente no sistema.
    /// </summary>
    public class AxiImage
    {

        private string arquivoCaminhoSelecionado;
        private string numeroIdentification;

        public string ArquivoCaminhoSelecionado { get => arquivoCaminhoSelecionado; set => arquivoCaminhoSelecionado = value; }
        public string NumeroIdentification { get => numeroIdentification; set => numeroIdentification = value; }

        /// <summary>
        /// Um método para abrir um OpenFileDialog para selecionar uma image.
        /// </summary>
        public void OpenFileDialog()
        {
            var FD = new OpenFileDialog
            {
                Filter = "jpeg files|*.jpg"
            };

            if (FD.ShowDialog() == DialogResult.OK)
            {
                arquivoCaminhoSelecionado  =  FD.FileName;
            }
            else
            {
                arquivoCaminhoSelecionado = "";
            }

            FD.Dispose();
        }


        /// <summary>
        /// Um método para gerar o número de indentificação para a image.
        /// </summary>
        /// <returns></returns>
        public void GerarImageIndentification()
        {
            numeroIdentification = System.Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
        }

        public void SalvarImageDiretory(string pastaDiretorio, string pastaDestino)
        {
            System.IO.File.Copy(pastaDiretorio, pastaDestino, true);
        }


        public void DeletarImageDiretorio(string arquivoDiretorio)
        {
            System.IO.File.Delete(arquivoDiretorio);
        }

        public bool VerificarArquivoNoDiretorio(string imageCaminhoDiretorio)
        {
            return System.IO.File.Exists(imageCaminhoDiretorio).Equals(true);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}
