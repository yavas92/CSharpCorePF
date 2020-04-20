using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public abstract class Voertuig
    {
        // Constructors
        public Voertuig() : this("Onbepaald", 0m, 0, 0f, "Onbepaald")
        {

        }

        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            this.Polishouder = polishouder;
            this.Kostprijs = kostprijs;
            this.Pk = pk;
            this.GemiddeldVerbruik = gemiddeldVerbruik;
            this.Nummerplaat = nummerplaat;
        }

        // Properties
        public string Polishouder { get; set; }
        private decimal kostprijsValue;

        public decimal Kostprijs
        {
            get { return kostprijsValue; }
            set
            {
                if (value > 0m)
                    kostprijsValue = value;
            }
        }

        private int pkValue;

        public int Pk
        {
            get { return pkValue; }
            set
            {
                if (value > 0)
                    pkValue = value;
            }
        }

        private float gemiddeldVerbruikValue;

        public float GemiddeldVerbruik
        {
            get { return gemiddeldVerbruikValue; }
            set
            {
                if (value >= 0f)
                    gemiddeldVerbruikValue = value;
            }
        }

        public string Nummerplaat { get; set; }

        // Methods
        public virtual void Afbeelden()
        {
            Console.WriteLine($"Polishouder: {Polishouder}");
            Console.WriteLine($"Kostprijs: {Kostprijs} euro");
            Console.WriteLine($"Vermogen: {Pk} Pk");
            Console.WriteLine($"Gemmideld verbruik: {GemiddeldVerbruik} L/100km");
            Console.WriteLine($"Nummerplaat: {Nummerplaat}");
        }

        public abstract double GetKyotoScore();
        
    }
}
