using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Personenwagen : Voertuig
    {
        // Constructor
        public Personenwagen(int aantalDeuren = 4, int aantalPassagiers = 5) : base()
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }

        public Personenwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, int aantalDeuren = 4, int aantalPassagiers = 5) : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }

        // Properties
        private int aantalDeurenValue;

        public int AantalDeuren
        {
            get { return aantalDeurenValue; }
            set
            {
                if (value > 0)
                    aantalDeurenValue = value;
            }
        }
        private int aantalPassagiersValue;

        public int AantalPassagiers
        {
            get { return aantalPassagiersValue; }
            set
            {
                if (value >= 0)
                    aantalPassagiersValue = value;
            }
        }

        // Methods
        public override void Afbeelden()
        {
            Console.WriteLine("Personenwagen");
            base.Afbeelden();
            Console.WriteLine($"Aantal deuren: {AantalDeuren}");
            Console.WriteLine($"Aantal passagiers: {AantalPassagiers}");
        }
    }
}
