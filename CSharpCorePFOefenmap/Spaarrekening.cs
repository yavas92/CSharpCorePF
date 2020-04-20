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
        public Spaarrekening(string rekeningNummer, decimal saldo, DateTime creatieDatum) : base(rekeningNummer, saldo, creatieDatum) // Parameter intrest is verwijderd wegens aanpassen naar constante
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
