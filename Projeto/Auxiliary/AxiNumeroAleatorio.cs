using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysEstoque.Properties;

namespace SysEstoque.AXL
{
    public static class AxiNumeroAleatorio
    {
        public static int GerarNumero()
        {
            Settings.Default.ValorNumerico += 1; Settings.Default.Save();

            Random GenerateRandom = new Random(Settings.Default.ValorNumerico);

            var numeroAleatorio = GenerateRandom.Next();

            return numeroAleatorio;
        }
    }
}
