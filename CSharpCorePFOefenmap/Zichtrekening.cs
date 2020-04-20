using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Zichtrekening : Rekening
    {
        // Constructor
        public Zichtrekening(string rekeningNummer,decimal saldo, DateTime creatieDatum, decimal maxKrediet) : base(rekeningNummer, saldo, creatieDatum)
        {
            MaxKrediet = maxKrediet;
        }

        // Properties
        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get { return maxKredietValue; }
            set
            {
                if (value <= 0m)
                    maxKredietValue = value;
            }
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Max krediet: {MaxKrediet}");
        }
    }
}
