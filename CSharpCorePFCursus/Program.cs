using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace CSharpCorePFCursus
{
    class Program
    {
        delegate bool Filter(int getal);

        static void Main(string[] args)
        {
            Action<int> kwadraat = getal => Console.WriteLine(getal * getal);
            kwadraat(10);

            Action<string, int> tekstDeel = (tekst, vanaf) => Console.WriteLine(tekst.Substring(vanaf));
            tekstDeel("VDAB", 2);

            Func<int, int, int> som = (getal1, getal2) => getal1 + getal2;
            Console.WriteLine(som(3, 6));
        }

        private static void ToonGetallen(Filter filter)
        {
            var getallen = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var getal in getallen)
                if (filter(getal))
                    Console.WriteLine(getal);
        }

        static Filter MaakLambda()
        {
            Console.Write("Geef een getal: ");
            var deelbaarDoor = int.Parse(Console.ReadLine());
            return getal => getal % deelbaarDoor == 0;
        }
    }
}
