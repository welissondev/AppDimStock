using System.Windows.Forms;

namespace DimStock.Controls
{
    public class CustomPictureBoxOne : PictureBox
    {
        private string selectedDirectory = "";
        public string SelectedDirectory
        {
            get { return selectedDirectory; }
            set { selectedDirectory = value; }
        }
        
        private string identificationPhotoNumber = "";
        public string IndentificationPhotoNumber
        {
            get { return identificationPhotoNumber; }
            set { identificationPhotoNumber = value; }
        }

        private string pathOfLastSelectedPhoto = "";

        public string PathOfLastSelectedPhoto
        {
            get { return pathOfLastSelectedPhoto; }
            set { pathOfLastSelectedPhoto = value; }
        }
    }
}
