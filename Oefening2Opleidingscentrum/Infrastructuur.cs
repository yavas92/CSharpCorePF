using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2Opleidingscentrum
{
    class Infrastructuur:IKost
    {
        // Constructor
        public Infrastructuur(string naam, float huurprijsPerMaand)
        {
            Naam = naam;
            HuurprijsPerMaand = huurprijsPerMaand;
        }

        // Properties
        public string Naam { get; set; }
        private float huurprijsPerMaandValue;

        public float HuurprijsPerMaand
        {
            get { return huurprijsPerMaandValue; }
            set
            {
                if (value >= 0f)
                    huurprijsPerMaandValue = value;
            }
        }

        public float Maandkost
        {
            get
            {
                return HuurprijsPerMaand;
            }
        }

        // Methods
        public void GegevensTonen()
        {
            Console.WriteLine($"Gebouw {Naam} - Huurprijs per maand: {HuurprijsPerMaand} euro");
            Console.WriteLine($"Maandelijkse kost {Maandkost} euro");
            Console.WriteLine();
        }
    }
}
