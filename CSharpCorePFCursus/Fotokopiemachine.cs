using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Materiaal
{
    public delegate void Onderhoudsbeurt(Fotokopiemachine machine);
    public class Fotokopiemachine : IKost
    {
        // Constructor
        public Fotokopiemachine(string serieNr, int aantalGekopieerdeBlz, decimal kostPerBlz)
        {
            SerieNr = serieNr;
            AantalGekopieerdeBlz = aantalGekopieerdeBlz;
            KostPerBlz = kostPerBlz;
        }

        // Properties
        public String SerieNr { get; set; }

        private int aantalGekopieerdeBlzValue;

        public int AantalGekopieerdeBlz
        {
            get { return aantalGekopieerdeBlzValue; }
            set
            {
                if (value >= 0)
                    aantalGekopieerdeBlzValue = value;
            }
        }

        private decimal kostPerBlzValue;

        public decimal KostPerBlz
        {
            get { return kostPerBlzValue; }
            set
            {
                if (value >= 0m)
                    kostPerBlzValue = value;
            }
        }

        public decimal Bedrag
        {
            get
            {
                return AantalGekopieerdeBlz * KostPerBlz;
            }
        }

        public bool Menselijk
        {
            get
            {
                return false;
            }
        }

        private const int AantalBlzTussen2OnderhoudsBeurten = 10;

        // Methods
        public void FotoKopieer(int aantalBlz)
        {
            for(int blz=1; blz<=aantalBlz; blz++)
            {
                Console.WriteLine($"Fotokopiemachine {SerieNr} kopieert blz. {blz} van {aantalBlz}");
                if (++AantalGekopieerdeBlz % AantalBlzTussen2OnderhoudsBeurten == 0)
                    if (OnderhoudNodig != null)
                        OnderhoudNodig(this);
            }
        }
        
        // Events
        public event Onderhoudsbeurt OnderhoudNodig;


    }
}
