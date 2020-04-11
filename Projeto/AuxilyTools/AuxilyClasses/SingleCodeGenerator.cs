using System;
using System.Linq;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    /// <summary>
    /// Gera código único de 7 digitos
    /// </summary>
    public class SingleCodeGenerator
    {
        public static string GetCode()
        {
            var chars = "0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
