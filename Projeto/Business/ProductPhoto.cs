using DimStock.Auxiliarys;
using DimStock.Properties;

namespace DimStock.Business
{
    public class ProductPhoto
    {
        public string GetDirectoryPeth()
        {
            var peth = Settings.Default.MainAppDirectory + @"\ProductPhotos\";

            return peth;
        }

        public string GetNumberId()
        {
            var photo = new AxlFile();
            return photo.GetNumberId();
        }

        public void CopyFromDirectory(string sourcePath, string destPath)
        {
            var photo = new AxlFile();

            if (CheckIfExtits(sourcePath) == true && CheckIfExtits(destPath) == false)
            {
                photo.CopyFromDirectory(sourcePath,destPath);
            }

        }

        public bool CheckIfExtits(string path)
        {
            var photo = new AxlFile();

            var fileFound = photo.CheckIfExtits(path);

            return fileFound;
        }

        public void DeleteFromDirectory(string path)
        {
            var photo = new AxlFile();

            if (photo.CheckIfExtits(path) == true)
                photo.DeleteFromDirectory(path);
        }
    }
}
