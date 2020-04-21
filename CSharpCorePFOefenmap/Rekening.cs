using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public abstract class Rekening
    {
        // Constructor
        public Rekening(Klant eigenaar, string rekeningNummer, decimal saldo, DateTime creatieDatum)
        {
            Eigenaar = eigenaar;
            Rekeningnummer = rekeningNummer;
            Saldo = saldo;
            CreatieDatum = creatieDatum;
        }

        // Properties
        private string rekeningNummerValue;
        private DateTime creatieDatum;
        private decimal saldoValue;

        public decimal Saldo
        {
            get { return saldoValue; }
            set
            {
                if (value >= 0m)
                    saldoValue = value;
            }
        }

        public string Rekeningnummer
        {
            get { return rekeningNummerValue; }
            set
            {
                if (RekeningnummerCorrect(value))
                    rekeningNummerValue = value;
                else
                    Console.WriteLine("Ongeldige rekeningnummer");
            }
        }

        public DateTime CreatieDatum
        {
            get { return creatieDatum; }
            set
            {
                if (value > new DateTime(1900, 1, 1))
                    creatieDatum = value;
            }
        }

        private Klant eigenaarValue;

        public Klant Eigenaar
        {
            get { return eigenaarValue; }
            set { eigenaarValue = value; }
        }


        // Methods
        private bool RekeningnummerCorrect(string rekeningnummer)
        {
            if (rekeningnummer.Substring(0, 2) != "BE")
                return false;

            if (!int.TryParse(rekeningnummer.Substring(2, 2), out int derdeVierdeTeken))
                return false;
            if (ulong.Parse(rekeningnummer.Substring(4, 10)) % 97 != ulong.Parse(rekeningnummer.Substring(14, 2)))
                return false;

            return true;
        }

        public virtual void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Console.Write("Eigenaar: ");
                Eigenaar.Afbeelden();
            }
                
            Console.WriteLine($"Rekeningnummer: {this.Rekeningnummer}");
            Console.WriteLine($"Creatiedatum: {this.CreatieDatum.ToShortDateString()}");
            Console.WriteLine($"Saldo: {this.Saldo}");
        }

        public void Storten(decimal stortBedrag)
        {
            this.Saldo += stortBedrag;
        }
    }
}
