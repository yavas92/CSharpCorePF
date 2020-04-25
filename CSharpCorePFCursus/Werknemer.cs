using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public abstract partial class Werknemer : IKost
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

        public abstract decimal Premie
        {
            get;
        }

        private Afdeling afdelingValue;

        public Afdeling Afdeling
        {
            get { return afdelingValue; }
            set { afdelingValue = value; }
        }

        public WerkRegime Regime { get; set; }


        // Constructors
        public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        {

        }
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

        public DateTime[] Verlofdagen { get; set; }
        public DateTime[] Ziektedagen { get; set; }

        // Methods
        public bool VerjaarAncien
        {
            get
            {
                return InDienst.Month == DateTime.Today.Month && InDienst.Day == DateTime.Today.Day;
            }
        }

        public abstract decimal Bedrag
        {
            get;
        }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine($"Naam: {Naam}");
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst.ToShortDateString()}");
            Console.WriteLine($"Personeelsfeest: {PersoneelsFeest.ToShortDateString()}");
            if (Afdeling != null)
                Console.WriteLine(Afdeling);
        }

        public override string ToString()
        {
            return $"{Naam} {Geslacht}";
        }
    }
}
