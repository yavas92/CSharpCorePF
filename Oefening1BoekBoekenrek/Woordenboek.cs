using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1BoekBoekenrek
{
    class Woordenboek : Boek
    {
        // Constructor
        public Woordenboek(string titel, string auteur, Eigenaar eigenaar, float aankoopprijs, Genre genre, string taal)
            : base(titel, auteur, eigenaar, aankoopprijs, genre)
        {
            Taal = taal;
        }

        // Properties
        public string Taal { get; set; }

        // Methods
        public override float Winst
        {
            get
            {
                return Aankoopprijs * 1.75f;
            }
        }

        public override void GegevensTonen()
        {
            Console.WriteLine("Woordenboek");
            Console.WriteLine("-----------");
            base.GegevensTonen();
            Console.WriteLine($"Taal: {Taal}");
        }

    }
}
