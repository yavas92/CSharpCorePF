using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1BoekBoekenrek
{
    abstract class Boek : IVoorwerpen
    {
        // Constructor
        public Boek(string titel, string auteur, Eigenaar eigenaar, float aankoopprijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            Eigenaar = eigenaar;
            Aankoopprijs = aankoopprijs;
            Genre = genre;
        }

        // Properties
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public Eigenaar Eigenaar { get; set; }

        private float aankoopprijsValue;
        public Genre Genre { get; set; }

        public float Aankoopprijs
        {
            get { return aankoopprijsValue; }
            set
            {
                if (value >= 0f)
                    aankoopprijsValue = value;
            }
        }

        // Methods
        public abstract float Winst
        {
            get;
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Eigenaar: {Eigenaar}");
            Console.WriteLine($"Prijs: {Aankoopprijs} euro");
            Console.WriteLine($"Winst: {Winst} euro");
            Console.WriteLine("Genregegevens:");
            Console.WriteLine($"  Genrenaam: {Genre.Naam}");
            Console.WriteLine("Doelgroepgegevens:");
            Console.WriteLine($"  Leeftijd: {Genre.Doelgroep.Leeftijd}");
            Console.WriteLine($"  Categorie: {Genre.Doelgroep.Categorie}");
        }
    }
}
