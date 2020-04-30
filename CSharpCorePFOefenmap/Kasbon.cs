using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Kasbon : ISpaarmiddel
    {
        // Constructor
        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, float intrest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }

        // Properties
        private DateTime aankoopDatumValue;
        private decimal bedragValue;
        private int looptijdValue;
        private float intrestValue;
        public Klant Eigenaar { get; set; }
        public DateTime AankoopDatum
        {
            get { return aankoopDatumValue; }
            set
            {
                if (value < new DateTime(1900, 1, 1))
                    throw new Exception($"De aankoopdatum mag niet voor {new DateTime(1900, 1, 1).ToShortDateString()} zijn!");
                aankoopDatumValue = value;
            }
        }

        public decimal Bedrag
        {
            get { return bedragValue; }
            set
            {
                if (value < 0)
                    throw new Exception("Het bedrag moet positief zijn!");
                bedragValue = value;
            }
        }

        public int Looptijd
        {
            get { return looptijdValue; }
            set
            {
                if (value < 0)
                    throw new Exception("De looptijd moet positief zijn!");
                looptijdValue = value;
            }
        }

        public float Intrest
        {
            get { return intrestValue; }
            set
            {
                if (value < 0)
                    throw new Exception("Intrest moet positief zijn!");
                intrestValue = value;
            }
        }

        // Methods
        public void Afbeelden()
        {
            if (Eigenaar != null)
                Console.WriteLine($"Eigenaar: {Eigenaar.ToString()}");
            Console.WriteLine($"Aankoopdatum: {AankoopDatum.ToShortDateString()}");
            Console.WriteLine($"Bedrag: {Bedrag}");
            Console.WriteLine($"Looptijd: {Looptijd}");
            Console.WriteLine($"Intrest: {Intrest}");

        }
    }
}
