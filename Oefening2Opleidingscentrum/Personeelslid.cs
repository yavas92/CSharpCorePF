using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2Opleidingscentrum
{
    abstract class Personeelslid : IKost
    {
        // Constructor
        public Personeelslid(int nummer, string familienaam, string voornaam, float brutomaandloon)
        {
            nummerValue = nummer;
            Familienaam = familienaam;
            Voornaam = voornaam;
            Brutomaandloon = brutomaandloon;
        }

        // Properties
        private int nummerValue;
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }
        private float brutomaandloonValue;

        public int Nummer
        {
            get { return nummerValue; }
        }

        public float Brutomaandloon
        {
            get { return brutomaandloonValue; }
            set
            {
                if (value > 0f)
                    brutomaandloonValue = value;
            }
        }

        public float Maandkost
        {
            get
            {
                return Brutomaandloon * 0.6f;
            }
        }

        // Methods
        public virtual void GegevensTonen()
        {
            Console.WriteLine($"Personeelsnummer: {Nummer}");
            Console.WriteLine($"Naam: {Voornaam} {Familienaam}");
            Console.WriteLine($"Brutomaandloon: {Brutomaandloon} euro");
        }
    }
}
