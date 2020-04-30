using System;

namespace Firma.Materiaal
{
    public partial class Fotokopiemachine
    {
        public class AantalGekopieerdeBlzException : Exception
        {
            public int VerkeerdAantalBlz { get; set; }
            public AantalGekopieerdeBlzException(string message, int verkeerdAantalBlz) 
                : base(message)
            {
                VerkeerdAantalBlz = verkeerdAantalBlz;
            }
        }


    }
}
