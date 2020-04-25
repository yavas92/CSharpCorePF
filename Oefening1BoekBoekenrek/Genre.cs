namespace Oefening1BoekBoekenrek
{
    public class Genre
    {
        // Constructor
        public Genre(string naam, Doelgroep doelgroep)
        {
            Naam = naam;
            Doelgroep = doelgroep;
        }

        // Properties
        public string Naam { get; set; }
        public Doelgroep Doelgroep { get; set; }
    }
}