using System.Runtime.CompilerServices;

namespace Convertisseur
{
    public class ConvertisseurRoman
    {
        public static string Transforme(uint chiffreArabe)
        => chiffreArabe switch
        {
            <= 3 => new string('I', (int)chiffreArabe),
        };
    }
}