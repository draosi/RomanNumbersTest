using System.Runtime.CompilerServices;

namespace Convertisseur
{
    public class ConvertisseurRoman
    {
        public static string Transforme(uint chiffreArabe)
        {
            if (chiffreArabe == 1)
            {
                return "I";
            }
            else if (chiffreArabe == 2)
            {
                return "II";
            }
            else
            {
                return "Non pris en charge";
            }
        }
    }
}