using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public sealed class Manager : Bediende
    {
        // Properties
        private decimal bonusValue;

        public decimal Bonus
        {
            get { return bonusValue; }
            set
            {
                if (value >= 0m)
                    bonusValue = value;
            }
        }

        public override decimal Premie
        {
            get
            {
                return Bonus * 3m;
            }
        }

        // Constructor
        public Manager(string naam, DateTime inDienst, Geslacht geslacht, decimal wedde, decimal bonus)
            : base(naam, inDienst, geslacht, wedde)
        {
            Bonus = bonus;
        }

        // Methods
        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Bonus: {Bonus}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: {Bonus}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Werknemer)
            {
                Werknemer deAndere = (Werknemer)obj;
                return this.Naam == deAndere.Naam;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }
    }
}
