using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpCorePFCursus
{
    class Program
    {
        delegate void WerknemersLijst(Werknemer[] werknemers);
        static void Main(string[] args)
        {
            var persoon = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 };
            var persoon2 = new { Nr = 1, Naam = "Adam", AantalKinderen = 2 };
            Console.WriteLine(persoon.GetType().ToString());
            Console.WriteLine(persoon.GetHashCode());
            Console.WriteLine(persoon2.GetType().ToString());
            Console.WriteLine(persoon2.GetHashCode());
        }
    }
}
