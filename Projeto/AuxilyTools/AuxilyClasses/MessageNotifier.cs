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

        public static void Show(string message = "", string title = "", string iconType = "")
        {
            MessageBoxIcon icon = MessageBoxIcon.None;

            switch (iconType)
            {
                case "!":
                    icon = MessageBoxIcon.Information;
                    break;

                case "?":
                    icon = MessageBoxIcon.Exclamation;
                    break;
            }

            Message = message;
            Title = title;

            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        public static bool Reply(string message = "", string title = "")
        {
            bool reply = false;

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                reply = true;
            }

            return reply;
        }
    }
}
