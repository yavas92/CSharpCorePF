using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Voertuig
    {
        // Properties
        public string Polishouder { get; set; }
        public decimal Kostprijs { get; set; }
        public int Pk { get; set; }
        public float GemiddeldVerbruik { get; set; }
        public string Nummerplaat { get; set; }

        // Constructors
        public Voertuig() : this("Onbepaald", 0.0m, 0, 0.0f, "Onbepaald")
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

        // Methods
        public void Afbeelden()
        {
            Console.WriteLine($"Polishouder: {Polishouder}");
            Console.WriteLine($"Kostprijs: {Kostprijs} euro");
            Console.WriteLine($"Vermogen: {Pk} Pk");
            Console.WriteLine($"Gemmideld verbruik: {GemiddeldVerbruik} L/100km");
            Console.WriteLine($"Nummerplaat: {Nummerplaat}\n");
        }
    }
}
