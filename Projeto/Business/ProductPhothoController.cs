using DimStock.Auxiliary;
using System;

namespace DimStock.Business
{
    public class ProductPhothoController
    {
        public string GetDirectoryPeth()
        {
            var peth = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Images\FotoProdutos\";

            return peth;
        }

        public string GetIndentificationNumber()
        {
            var image = new AxlImage();
            return image.GenerateGuidCode();
        }

        public void CopyToDirectory(string source, string path)
        {
            AxlImage image = new AxlImage();

            if (FindInDirectory(source) == true && FindInDirectory(path) == false)
            {
                image.CopyToDirectory(source,path);
            }

        }

        public bool FindInDirectory(string path)
        {
            var image = new AxlImage();

            var fileFound = image.CheckFileInDirectory(path);

            return fileFound;
        }

        public void DeleteFromDirectory(string path)
        {
            var image = new AxlImage();

            if (FindInDirectory(path) == true)
                image.DeleteFromDirectory(path);
        }
    }
}
