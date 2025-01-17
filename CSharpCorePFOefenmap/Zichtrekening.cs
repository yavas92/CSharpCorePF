﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Zichtrekening : Rekening
    {
        // Constructor
        public Zichtrekening(Klant eigenaar, string rekeningNummer, decimal saldo, DateTime creatieDatum, decimal maxKrediet) : base(eigenaar, rekeningNummer, saldo, creatieDatum)
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
                if (value > 0m)
                    throw new Exception("De waarde van MaxKrediet mag niet positief zijn!");
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
