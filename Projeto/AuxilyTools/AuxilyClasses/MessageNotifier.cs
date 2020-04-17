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

        public static void Set(string message = "", string title = "")
        {
            Message = message;
            Title = title;
        }
    }
}
