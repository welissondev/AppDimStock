using System;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public class SingleCodeGenerator
    {
        public static int GetNumber(int seed)
        {
            var random = new Random(seed);
            return random.Next();
        }
    }
}
