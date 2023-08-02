using Convertisseur;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestRomanNumbers
{
    public class RomanTest
    {

        [Theory(DisplayName = "ETANT DONNE le chiffre <nombre> " +
                              "QUAND je le convertis en nombres romains " +
                              "ALORS j'obtiens <nombre> fois I")]

        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestDeUnDeuxTrois(uint nombre)
        {
            var nombreRomain = ConvertisseurRoman.Transforme(nombre);

            var résultatAttendu = new string(Enumerable.Repeat('I', (int)nombre).ToArray());
            Assert.Equal(résultatAttendu, nombreRomain);
        }

        [Fact(DisplayName = "ETANT DONNE le chiffre 4 " +
                            "QUAND je le convertis en nombres romains " +
                            "ALORS j'obtiens IV")]
        public void TestQuatre()
        {
            const uint chiffreArabe = 4;

            var nombreRomain = ConvertisseurRoman.Transforme(chiffreArabe);

            Assert.Equal("IV", nombreRomain);
        }
    }
}