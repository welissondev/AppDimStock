using DimStock.Auxiliary;
using System;

namespace DimStock.Business
{
    public static class BllProductPhotho
    {
        #region GetPeth()
        public static string GetPeth()
        {
            var peth = AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Images\FotoProdutos\";

            return peth;
        }
        #endregion

        #region GetGuid()
        public static string GetGuid()
        {
            var image = new AxlImage();
            return image.GenerateGuidCode();
        }
        #endregion

        #region CopyToDiretory()
        public static void CopyToDirectory(string dirSource, string DirDest)
        {
            AxlImage image = new AxlImage();

            if (FindFile(dirSource).Equals(true) && FindFile(DirDest).Equals(false))
                image.CopyToDirectory(dirSource, DirDest);
        }
        #endregion

        #region FindFile()
        public static bool FindFile(string photoDirectoryPath)
        {
            var image = new AxlImage();

            bool fileFound = image.CheckFileInDirectory(photoDirectoryPath);

            return fileFound;
        }
        #endregion

        #region DeleteFile()
        public static void DeleteFile(string photoDirectoryPath)
        {
            var image = new AxlImage();

            if (FindFile(photoDirectoryPath).Equals(true))
                image.DeleteFromDirectory(photoDirectoryPath);
        }
        #endregion
    }
}
