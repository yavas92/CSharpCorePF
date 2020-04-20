using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Spaarrekening : Rekening
    {
        // Properties
        private float intrestValue;

        public float Intrest
        {
            get { return intrestValue; }
            set
            {
                if (value >= 0f)
                    intrestValue = value;
            }
        }

        // Constructor
        public Spaarrekening(string rekeningNummer, decimal saldo, DateTime creatieDatum, float intrest) : base(rekeningNummer, saldo, creatieDatum)
        {
            Intrest = intrest;
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Intrest: {Intrest}");
        }

    }
}
