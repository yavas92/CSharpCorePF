using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Persoon
    {
        public Persoon()
        {

        }
        public Persoon(string naam)
        {
            Naam = naam;
        }
        public Persoon(string naam, int aantalKinderen) : this(naam)
        {
            AantalKinderen = aantalKinderen;
        }
        public String Naam { get; set; }
        public int AantalKinderen { get; set; }

    }
}
