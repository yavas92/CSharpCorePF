using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
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



        // Methods

    }
}
