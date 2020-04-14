using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            Werknemer ik = new Werknemer("Asterix", new DateTime(2019,1,1), Geslacht.Man);
            ik.Afbeelden();

            LijnenTrekker lijnenTrekker = new LijnenTrekker();
            lijnenTrekker.TrekLijn(30);

            Werknemer jij = new Werknemer("Obelix", new DateTime(2019,1,2), Geslacht.Man);
            jij.Afbeelden();
        }
    }
}
