using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening1BoekBoekenrek
{
    class Boekenrek : IVoorwerpen
    {
        // Constructor
        public Boekenrek(float hoogte, float breedte, float aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Aankoopprijs = aankoopprijs;
        }

        // Properties
        private float hoogteValue;
        private float breedteValue;
        private float aankoopprijsValue;

        public float Hoogte
        {
            get { return hoogteValue; }
            set
            {
                if (value >= 0f)
                    hoogteValue = value;
            }
        }

        public float Breedte
        {
            get { return breedteValue; }
            set
            {
                if (value >= 0f)
                    breedteValue = value;
            }
        }

        public float Aankoopprijs
        {
            get { return aankoopprijsValue; }
            set
            {
                if (value >= 0f)
                    aankoopprijsValue = value;
            }
        }

        public float Winst
        {
            get
            {
                return Aankoopprijs * 2;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("Boekenrek");
            Console.WriteLine("---------");
            Console.WriteLine($"Breedte: {Breedte}");
            Console.WriteLine($"Hoogte: {Hoogte}");
            Console.WriteLine($"Aankoopprijs: {Aankoopprijs} euro");
            Console.WriteLine($"Winst: {Winst} euro");
        }
    }
}
