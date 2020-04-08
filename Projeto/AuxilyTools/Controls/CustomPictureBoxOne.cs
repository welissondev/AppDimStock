using System.Windows.Forms;

namespace DimStock.AuxilyTools.Controls
{
    public class CustomPictureBoxOne : PictureBox
    {
        private string selectedDirectory = "";
        public string SelectedDirectory
        {
            get { return selectedDirectory; }
            set { selectedDirectory = value; }
        }
        
        private string imageId = "";
        public string ImageId
        {
            get { return imageId; }
            set { imageId = value; }
        }

        private string pathOfLastSelectedImage = "";

        public string PathOfLastSelectedImage
        {
            get { return pathOfLastSelectedImage; }
            set { pathOfLastSelectedImage = value; }
        }
    }
}
