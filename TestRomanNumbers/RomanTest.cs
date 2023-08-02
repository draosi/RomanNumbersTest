using Convertisseur;

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
    }
}