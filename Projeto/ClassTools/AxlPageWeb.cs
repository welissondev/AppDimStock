using System;
using System.Diagnostics;

namespace DimStock.ClassTools
{
    public class AxlPageWeb
    {
        public static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    }
}
