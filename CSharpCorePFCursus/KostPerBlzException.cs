using System;

namespace Firma.Materiaal
{
    public partial class Fotokopiemachine
    {
        public class KostPerBlzException : Exception
        {
            public decimal VerkeerdeKost { get; set; }
            public KostPerBlzException(string message, decimal verkeerdeKost) 
                : base(message)
            {
                VerkeerdeKost = verkeerdeKost;
            }
        }
    }
}
