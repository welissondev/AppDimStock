using System.Windows.Forms;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public static class MdiClosingAll
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
