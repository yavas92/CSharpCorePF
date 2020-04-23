using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Klant
    {
        // Constructor
        public Klant(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

        // Properties
        private string voornaamValue;

        public string Voornaam
        {
            get { return voornaamValue; }
            set
            {
                if (value != "")
                    voornaamValue = value;
            }
        }

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


        // Methods
        public void Afbeelden()
        {
            Console.WriteLine($"{Voornaam} {Naam}");
        }

        public override string ToString()
        {
            return $"{Voornaam} {Naam}";
        }
    }
}
