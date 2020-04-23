using System.Windows.Forms;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    /// <summary>
    /// Define mensagem de resposta sobre uma solicitação ou ação
    /// </summary>
    public class MessageNotifier
    {
        public static string Message { get; private set; }
        public static string Title { get; private set; }

        public static void Show(string message = "", string title = "")
        {
            Message = message;
            Title = title;

            MessageBox.Show(message, title);
        }

        public static bool Reply(string message, string title)
        {
            bool reply = false;

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) 
                == DialogResult.Yes)
            {
                reply = true;
            }

            return reply;
        }
    }
}
