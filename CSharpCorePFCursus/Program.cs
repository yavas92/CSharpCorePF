using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;

namespace CSharpCorePFCursus
{
    class Program
    {
        delegate void WerknemersLijst(Werknemer[] werknemers);
        static void Main(string[] args)
        {
            Arbeider asterix = new Arbeider("Asterix", DateTime.Today, Geslacht.Man, 10m, 1); 
            string afdelingsnaam;
            afdelingsnaam = asterix.Afdeling?.Naam??"onbekend";
            Console.WriteLine($"{asterix.Naam} werkt op de afdeling {afdelingsnaam}.");
        }
    }
}
