using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2Opleidingscentrum
{
    class Instructeur : Personeelslid
    {
        // Constructor
        public Instructeur(int nummer, string familienaam, string voornaam, float brutomaandloon, Vakgebied vakgebied, string emailadres)
            : base(nummer, familienaam, voornaam, brutomaandloon)
        {
            Vakgebied = vakgebied;
            Emailadres = emailadres;
        }

        // Properties
        public Vakgebied Vakgebied { get; set; }

        private string emailadresValue;

        public string Emailadres
        {
            get { return emailadresValue; }
            set
            {
                if (value.IndexOf('@') != -1)
                    emailadresValue = value;
                else
                    emailadresValue = "onbekend e-mailadres";
            }
        }


        // Methods
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine($"Instructeur {Vakgebied} (e-mail:{Emailadres}");
            Console.WriteLine($"Maandelijkse kost: {Math.Round(Maandkost*100)/100} euro");
            Console.WriteLine();
        }
    }
}
