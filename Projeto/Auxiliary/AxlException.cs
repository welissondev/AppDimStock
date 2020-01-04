using System;
using System.Windows.Forms;

namespace DimStock.Auxiliary
{
    public static class AxlException
    {
        public static class Message
        {
            private static string causeOfError;
            private static string methodName;
            private static string className;
            private static string layerName;

            public static void Show(Exception ex)
            {
                causeOfError = "Erro: " + ex.Message;
                layerName = "Camada : " + ex.TargetSite.Module.Name;
                className = "Classe : " + ex.TargetSite.ReflectedType.Name;
                methodName = "Método : " + ex.TargetSite.Name;

                string errorMenssage = string.Format("{0}\n\n\n{1}\n\n{2}\n\n{3}", causeOfError, layerName, className, methodName);

                MessageBox.Show(causeOfError = string.Format("{0}", errorMenssage), "Erro em tempo de execução", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
