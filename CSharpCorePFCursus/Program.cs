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
            Overuren mijnOveruren = new Overuren();
            mijnOveruren[0] = 4;
            mijnOveruren["apr"] = 2;
            Console.WriteLine("Overuren januari: " + mijnOveruren["jan"]);
            Console.WriteLine("Overuren april: " + mijnOveruren[3]);
            Console.WriteLine("Totaal overuren: " + mijnOveruren.Totaal);
        }
    }
}
