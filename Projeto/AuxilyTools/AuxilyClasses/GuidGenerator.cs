using System;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public class GuidGenerator
    {
        public string GetGuid(bool withCharacter = false)
        {
            var guidGenerated = string.Empty;

            switch (withCharacter)
            {
                case true:
                    guidGenerated = Guid.NewGuid().ToString();
                    break;

                case false:
                    guidGenerated = Guid.NewGuid().ToString().Replace("{", "").Replace("}", "").Replace("-", "");
                    break;
            }
            return guidGenerated;
        }
    }
}
