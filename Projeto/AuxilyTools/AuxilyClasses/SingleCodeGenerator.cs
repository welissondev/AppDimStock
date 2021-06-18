using System;
using System.Linq;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    /// <summary>
    /// Gera código único de 7 digitos
    /// </summary>
    public class SingleCodeGenerator
    {
        private readonly int seed;

        public SingleCodeGenerator(int seed){ this.seed = seed;}

        public string GetCode()
        {
            var chars = "0123456789";
            var random = new Random(seed);
            return new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
