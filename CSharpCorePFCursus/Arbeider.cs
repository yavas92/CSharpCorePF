using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Arbeider : Werknemer
    {
        // Properties
        private decimal uurloonValue;

        public decimal Uurloon
        {
            get { return uurloonValue; }
            set
            {
                if (value >= 0m)
                    uurloonValue = value;
            }
        }
        private byte ploegenstelselValue;

        public byte Ploegenstelsel
        {
            get { return ploegenstelselValue; }
            set
            {
                if (value >= 1 && value <= 3)
                    ploegenstelselValue = value;
            }
        }

        public override decimal Premie
        {
            get
            {
                return Uurloon * 150m;
            }
        }

        public override decimal Bedrag
        {
            get
            {
                return Uurloon * 2000;
            }
        }

        // Constructors
        public Arbeider(string naam, DateTime inDienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) : base(naam, inDienst, geslacht)
        {
            Uurloon = uurloon;
            Ploegenstelsel = ploegenstelsel;
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Uurloon: {Uurloon}");
            Console.WriteLine($"Ploegenstelsel: {Ploegenstelsel}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Uurloon} euro/uur";
        }
    }
}
