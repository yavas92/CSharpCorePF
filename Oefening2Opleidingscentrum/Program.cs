using System;

namespace Oefening2Opleidingscentrum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaraties vd objecten
            Instructeur instructeurOntwikkeling = new Instructeur(1, "Janssen", "Jan", 1500f, Vakgebied.Ontwikkeling, "");
            Instructeur instructeurNetwerkbeheer = new Instructeur(2, "Roosen", "Roos", 1600f, Vakgebied.Netwerkbeheer, "roos.roosen@vdab.be");
            Medewerker medewerker = new Medewerker(3, "Peeters", "Piet", 1550, 10);


            Verlofperiode[] verplichteVerlofperiodes = new Verlofperiode[2];
            
            verplichteVerlofperiodes[0] = new Verlofperiode("Zomervakantie", new DateTime(2020, 7, 1), new DateTime(2020, 7, 31));
            verplichteVerlofperiodes[1] = new Verlofperiode("Kerstmis", new DateTime(2020, 12, 25), new DateTime(2021, 1, 1));

            Infrastructuur gebouw1 = new Infrastructuur("Einstein", 1500f);
            Infrastructuur gebouw2 = new Infrastructuur("Newton", 2500f);

            IKost[] kosten = new IKost[5];
            kosten[0] = instructeurOntwikkeling;
            kosten[1] = instructeurNetwerkbeheer;
            kosten[2] = medewerker;
            kosten[3] = gebouw1;
            kosten[4] = gebouw2;

            float totaleMaandkost = 0f;

            // Uitlezen naar console
            Console.WriteLine("Collectieve verlofperiodes:");
            Console.WriteLine("---------------------------");

            foreach (Verlofperiode verlofperiode in verplichteVerlofperiodes)
                Console.WriteLine(verlofperiode.ToString());

            Console.WriteLine();
            Console.WriteLine("Kosten personeel en infrastructuur:");
            Console.WriteLine("-----------------------------------");

            foreach (IKost kost in kosten)
            {
                kost.GegevensTonen();
                totaleMaandkost += kost.Maandkost;
            }

            Console.WriteLine($"Totale maandkost (personeel + infrastructuur): {totaleMaandkost} euro");
        }
    }
}
