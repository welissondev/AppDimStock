using System;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public class SingleCodeGenerator
    {
        public static int GetNumber(int numberRef)
        {
            var random = new Random(numberRef);
            return random.Next();
        }
    }
}
