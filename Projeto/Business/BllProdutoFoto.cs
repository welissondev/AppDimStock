using DimStock.Auxiliary;
using System;

namespace DimStock.Business
{
    public static class BllProdutoFoto
    {
        #region PegarCaminho()
        public static string PegarCaminho()
        {
            return AppDomain.CurrentDomain.BaseDirectory.ToString() + @"Images\FotoProdutos\";
        }
        #endregion

        #region CopiarParaDiretorio()
        public static void CopiarParaDiretorio(string dirSource, string DirDest)
        {
            AxlImage image = new AxlImage();

            if (EncontrarArquivo(dirSource).Equals(true) && EncontrarArquivo(DirDest).Equals(false))
                image.CopyToDirectory(dirSource, DirDest);
        }
        #endregion

        #region PegarGuid()
        public static string PegarGuid()
        {
            AxlImage image = new AxlImage();
            return image.GenerateGuidCode();
        }
        #endregion

        #region EncontrarArquivo()
        public static bool EncontrarArquivo(string dir)
        {
            AxlImage image = new AxlImage();
            return image.CheckFileInDirectory(dir);
        }
        #endregion

        #region DeletarArquivo()
        public static void DeletarArquivo(string dir)
        {
            AxlImage image = new AxlImage();

            if (EncontrarArquivo(dir).Equals(true))
                image.DeleteFromDirectory(dir);
        }
        #endregion
    }
}
