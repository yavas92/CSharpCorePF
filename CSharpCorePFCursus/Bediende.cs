using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public class Bediende : Werknemer
    {
        // Properties
        private decimal weddeValue;

        public decimal Wedde
        {
            get { return weddeValue; }
            set
            {
                if (value >= 0m)
                    weddeValue = value;
            }
        }

        public override decimal Premie
        {
            get
            {
                return Wedde * 2m;
            }
        }

        public override decimal Bedrag
        {
            get
            {
                return Wedde * 12;
            }
        }

        // Constructors
        public Bediende(string naam, DateTime inDienst, Geslacht geslacht, decimal wedde)
            : base(naam, inDienst, geslacht)
        {
            Wedde = wedde;
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Wedde: {Wedde}");
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Wedde} euro/maand";
        }
    }
}

