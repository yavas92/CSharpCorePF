using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Vrachtwagen : Voertuig
    {
        // Constructor
        public Vrachtwagen(float maxLading = 10000) : base()
        {
            MaxLading = maxLading;
        }
        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, float maxLading = 10000) : base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            MaxLading = maxLading;
        }

        // Properties
        private float maxLadingValue;

        public float MaxLading
        {
            get { return maxLadingValue; }
            set
            {
                if (value >= 0f)
                    maxLadingValue = value;
            }
        }

        // Methods
        public override void Afbeelden()
        {
            Console.WriteLine("Vrachtwagen");
            base.Afbeelden();
            Console.WriteLine($"Maximum lading: {MaxLading}");
        }
    }
}
