using System;
using System.Diagnostics;

namespace DimStock.AuxilyTools
{
    /// <summary>
    /// Abri uma página web com url especificada
    /// </summary>
    public class PageWebViewer
    {
        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
