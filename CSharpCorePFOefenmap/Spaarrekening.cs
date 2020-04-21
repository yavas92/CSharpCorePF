using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Spaarrekening : Rekening
    {
        // Properties
        private static float intrestValue;

        public static float Intrest
        {
            get { return intrestValue; }
            set
            {
                if (value >= 0f)
                    intrestValue = value;
            }
        }

        // Constructor
        public Spaarrekening(Klant eigenaar, string rekeningNummer, decimal saldo, DateTime creatieDatum) : base(eigenaar, rekeningNummer, saldo, creatieDatum)
        {
            
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Intrest: {Intrest}");
        }

    }
}
