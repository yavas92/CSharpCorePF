using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2Opleidingscentrum
{
    class Medewerker : Personeelslid
    {
        // Constructor
        public Medewerker(int nummer, string familienaam, string voornaam, float brutomaandloon, int beheerdAantalCursisten) 
            : base(nummer, familienaam, voornaam, brutomaandloon)
        {
            BeheerdAantalCursisten = beheerdAantalCursisten;
        }

        // Properties
        private int beheerdAantalCursistenValue;

        public int BeheerdAantalCursisten
        {
            get { return beheerdAantalCursistenValue; }
            set
            {
                if (value >= 0)
                    beheerdAantalCursistenValue = value;
            }
        }

        // Methods
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Medewerker: {BeheerdAantalCursisten} cursisten");
            Console.WriteLine($"Maandelijkse kost: {Math.Round(Maandkost*100)/100} euro");
            Console.WriteLine();
        }
    }
}
