using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public class Rekening
    {
        // Properties
        private string rekeningNummerValue;
        private DateTime creatieDatum;
        public double Saldo { get; set; }
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

        // Constructor
        public Rekening(string rekeningNummer, DateTime creatieDatum)
        {
            this.Rekeningnummer = rekeningNummer;
            this.CreatieDatum = creatieDatum;
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

        public void Afbeelden()
        {
            Console.WriteLine($"Rekeningnummer: {this.Rekeningnummer}");
            Console.WriteLine($"Creatiedatum: {this.CreatieDatum}");
            Console.WriteLine($"Saldo: {this.Saldo}");
        }

        public void Storten(double stortBedrag)
        {
            this.Saldo += stortBedrag;
        }
    }
}
