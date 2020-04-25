using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1BoekBoekenrek
{
    class Leesboek : Boek
    {
        // Constructor
        public Leesboek(string titel, string auteur, Eigenaar eigenaar, float aankoopprijs, Genre genre, string onderwerp) 
            : base(titel, auteur, eigenaar, aankoopprijs, genre)
        {
            Onderwerp = onderwerp;
        }

        // Properties
        public string Onderwerp { get; set; }

        // Methods
        public override float Winst
        {
            get
            {
                return Aankoopprijs * 1.5f;
            }
        }

        public override void GegevensTonen()
        {
            Console.WriteLine("Leesboek");
            Console.WriteLine("--------");
            base.GegevensTonen();
            Console.WriteLine($"Onderwerp: {Onderwerp}");
        }
    }
}
