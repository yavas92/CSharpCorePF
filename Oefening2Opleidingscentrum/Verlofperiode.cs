using System;

namespace Oefening2Opleidingscentrum
{
    public class Verlofperiode
    {
        // Constructor
        public Verlofperiode(string naam, DateTime beginDatum, DateTime eindDatum)
        {
            Naam = naam;
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
        }

        // Properties
        public string Naam { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }

        // Methods
        public override string ToString()
        {
            return $"Verlofperiode {Naam}: {BeginDatum:dd/MM/yyyy} - {EindDatum:dd/MM/yyyy}";
        }
    }
}