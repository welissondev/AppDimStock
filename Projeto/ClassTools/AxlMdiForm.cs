using System.Windows.Forms;

namespace DimStock.ClassTools
{
    public static class AxlMdiForm
    {
        public static void CloseAllForms()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
