using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{
    public static class AxlException
    {
        public static class Message
        {
            private static string causaDoErro;
            //private static int linhaDoErro;
            private static string nomeDoMetodo;
            private static string nomeDaClasse;
            private static string nomeDaCamada;

            public static void Show(Exception ex)
            {
                causaDoErro = "Erro: " + ex.Message;
                nomeDaCamada = "Camada : " + ex.TargetSite.Module.Name;
                nomeDaClasse = "Classe : " + ex.TargetSite.ReflectedType.Name;
                nomeDoMetodo = "Método : " + ex.TargetSite.Name;

                string messagemDeErro = string.Format("{0}\n\n\n{1}\n\n{2}\n\n{3}", causaDoErro, nomeDaCamada, nomeDaClasse, nomeDoMetodo);

                MessageBox.Show(causaDoErro = string.Format("{0}", messagemDeErro), "Erro em tempo de execução", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
