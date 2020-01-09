using DimStock.Auxiliary;
using System;

namespace DimStock.Business
{
    public class ProductPhoto
    {
        public string GetDirectoryPeth()
        {
            var peth = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Images\FotoProdutos\";

            return peth;
        }

        public string GetIndentificationNumber()
        {
            var image = new ImageAssistant();
            return image.GenerateGuidCode();
        }

        public void CopyToDirectory(string source, string path)
        {
            ImageAssistant image = new ImageAssistant();

            if (FindInDirectory(source) == true && FindInDirectory(path) == false)
            {
                image.CopyToDirectory(source,path);
            }

        }

        public bool FindInDirectory(string path)
        {
            var image = new ImageAssistant();

            var fileFound = image.CheckFileInDirectory(path);

            return fileFound;
        }

        public void DeleteFromDirectory(string path)
        {
            var image = new ImageAssistant();

            if (FindInDirectory(path) == true)
                image.DeleteFromDirectory(path);
        }
    }
}
