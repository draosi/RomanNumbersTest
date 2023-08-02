using Convertisseur;

namespace TestRomanNumbers
{
    public class RomanTest
    {
        [Fact(DisplayName = "ETANT DONNE le chiffre 1" +
            "QUAND je le convertis en nombre romains" +
            "ALORS j'obtiens 1 fois 1")]
        public void TestUn()
        {
            const uint chiffre = 1;
            var nombreRomain = ConvertisseurRoman.Transforme(chiffre);
            Assert.Equal("I", nombreRomain);
        }
    }
}