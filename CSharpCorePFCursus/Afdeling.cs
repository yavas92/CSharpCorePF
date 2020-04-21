using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Afdeling
    {
        // Constructor
        public Afdeling(string naam, int verdieping)
        {
            Naam = naam;
            Verdieping = verdieping;
        }

        // Properties
        public const int Verdiepingen = 10;
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set
            {
                if (value != "")
                    naamValue = value;
            }
        }

        private int verdiepingValue;

        public int Verdieping
        {
            get { return verdiepingValue; }
            set
            {
                if (value >= 0 && value <= Verdiepingen)
                    verdiepingValue = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return $"Afdeling: {Naam} op verdieping {Verdieping}";
        }
    }
}
