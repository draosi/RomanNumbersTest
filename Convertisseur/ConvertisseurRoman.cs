using System.Runtime.CompilerServices;

namespace Convertisseur
{
    public class ConvertisseurRoman
    {
        public static string Transforme(uint chiffreArabe)
        {
            if (chiffreArabe == 1)
            {
                return new string('I', (int)chiffreArabe);
            }
            else
            {
                return "Non pris en charge";
            }
        }
    }
}