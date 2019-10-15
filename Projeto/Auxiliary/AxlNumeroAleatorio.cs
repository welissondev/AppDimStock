using System;
using SysEstoque.Properties;

namespace SysEstoque.Auxiliary
{
    /// <summary>
    /// Classe statica para geração de id
    /// </summary>
    public static class AxlNumeroAleatorio
    {
        /// <summary>
        /// Gera um número id com a classe <see cref="Random"/>
        /// </summary>
        /// <returns></returns>
        public static int GerarNumero()
        {
            Settings.Default.ValorNumerico += 1; Settings.Default.Save();

            Random GenerateRandom = new Random(Settings.Default.ValorNumerico);

            var numeroAleatorio = GenerateRandom.Next();

            return numeroAleatorio;
        }
    }
}
