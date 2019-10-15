
using System.Windows.Forms;

namespace SysEstoque.Auxiliary
{
    public static class AxlMessageBox 
    {
        public static void Sucesso(string message)
        {
            MessageBox.Show(message, "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Aviso(string message)
        {
            MessageBox.Show(message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void Erro(string message)
        {
            MessageBox.Show(message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Pergunta(string message)
        {
            MessageBox.Show(message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
