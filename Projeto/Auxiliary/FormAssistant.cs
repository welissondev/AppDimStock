using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimStock.Auxiliary
{
    public static class FormAssistant
    {

        public static void CloseAllForms()
        {
            // percorre todos os formulários abertos
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                // se o formulário for filho
                if (Application.OpenForms[i].IsMdiChild)
                {
                    // fecha o formulário
                    Application.OpenForms[i].Close();
                }
            }
        }
    }
}
