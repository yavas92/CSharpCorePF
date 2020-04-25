using System;

namespace Oefening1BoekBoekenrek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array van IVoorwerpen aanmaken
            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];

            // Array vullen met Leesboek, Woordenboek en Boekenrek
            voorwerpen[0] = new Leesboek("Harry Potter", "J.K. Rowling", Eigenaar.VDAB, 20f, new Genre("fictie", new Doelgroep(15)), "toveren");
            voorwerpen[1] = new Woordenboek("Vandale", "Kramers", Eigenaar.VDAB, 100f, new Genre("vreemd", new Doelgroep(20)), "NL-E");
            voorwerpen[2] = new Boekenrek(3f, 2.5f, 200f);

            // Variabele totaleWinst declareren
            float totaleWinst = 0f;

            foreach (IVoorwerpen voorwerp in voorwerpen)
            {
                voorwerp.GegevensTonen(); // Gegevens tonen per voorwerp
                Console.WriteLine();
                totaleWinst += voorwerp.Winst; // Winst optellen bij totaleWinst variabele
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Totale winst: {totaleWinst} euro"); // totaleWinst variabele afbeelden
            Console.WriteLine();

        }
    }
}
