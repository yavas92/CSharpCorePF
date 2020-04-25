using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;
using PersoneelStatus = Firma.Personeel.Status;
using static System.Console;

namespace CSharpCorePFCursus
{

    class Program
    {
        static void Main(string[] args)
        {
            PersoneelStatus statusChef = PersoneelStatus.HogerKader;
            WriteLine(statusChef);
        }

        public static (int aantalVerlofdagen, int aantalZiektedagen) Afwezigheden(Werknemer werknemer)
        {
            (int, int) aantalAfwezigheden = (werknemer.Verlofdagen.Length, werknemer.Ziektedagen.Length);
            return aantalAfwezigheden;
        }
    }

}
