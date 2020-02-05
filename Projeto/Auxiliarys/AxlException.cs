using System;
using System.Windows.Forms;
using DimStock.Auxiliarys;

namespace DimStock.Auxiliarys
{
    public static class AxlException
    {
        public static class Message
        {
            public static void Show(Exception ex)
            {
                var numberErr = ex.HResult;
                var messageRelp = string.Empty;

                messageRelp = "Se você estiver enfrentando dificuldades com esse erro, acesse " +
                "nosso site, e solicite ajuda ao nosso suporte. Capture um print da tela, envie " +
                "o anexo do erro para nossa central \n \n" +
                "Acesse: www.diarioexcel.com.br \n \n" +
                "" +
                "Deseja solicitar o suporte agora?";

                if (MessageBox.Show(ex.Message + "\n \n" + messageRelp, "Desculpe, ocorreu um erro :(",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    AxlPageWeb.OpenUrl("https://diarioexcel.com.br/contato-diario-excel/");
                }
            }
        }
    }
}
