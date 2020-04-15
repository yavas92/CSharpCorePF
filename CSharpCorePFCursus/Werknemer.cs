using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public class Werknemer
    {
        // Properties
        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                {
                    naamValue = value;
                }
            }
        }
        public DateTime InDienst { get; set; }
        public Geslacht Geslacht { get; set; }
        private decimal salarisValue;

        public decimal Salaris
        {
            get
            {
                return salarisValue;
            }
            private set
            {
                if (value >= 0m)
                    salarisValue = value;
            }
        }

        private static DateTime personeelsFeestValue;

        public static DateTime PersoneelsFeest
        {
            get { return personeelsFeestValue; }
            set { personeelsFeestValue = value; }
        }


        // Constructors
        //public Werknemer():this("Onbekend", DateTime.Today, Geslacht.Man)
        //{

        //}
        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            Naam = naam;
            InDienst = inDienst;
            Geslacht = geslacht;
        }

        static Werknemer()
        {
            PersoneelsFeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (PersoneelsFeest.DayOfWeek != DayOfWeek.Friday)
            {
                PersoneelsFeest = PersoneelsFeest.AddDays(1);
            }
        }

        // Methods
        public bool VerjaarAncien
        {
            get
            {
                return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
            }
        }


        public void Afbeelden()
        {
            LijnenTrekker lijnenTrekker = new LijnenTrekker();
            lijnenTrekker.TrekLijn(40, '=');
            Console.WriteLine();
            Console.WriteLine($"Naam: \t\t\t{Naam}");
            Console.WriteLine($"Geslacht: \t\t{Geslacht}");
            Console.WriteLine($"In dienst: \t\t{InDienst.ToShortDateString()}");
            Console.WriteLine($"Personeelsfeest: \t{PersoneelsFeest.ToShortDateString()}");
            Console.WriteLine();
        }

    }
}
