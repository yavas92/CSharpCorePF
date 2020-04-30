using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    public delegate void Transactie(Rekening rekening);
    public abstract class Rekening : ISpaarmiddel
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
        public Klant Eigenaar { get; set; }

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
                if (!RekeningnummerCorrect(value))
                    throw new Exception("Ongeldige rekeningnummer!");
                rekeningNummerValue = value;

            }
        }

        public DateTime CreatieDatum
        {
            get { return creatieDatum; }
            set
            {
                if (value < new DateTime(1900, 1, 1))
                    throw new Exception($"De creatiedatum mag niet voor {new DateTime(1900, 1, 1).ToShortDateString()} zijn!");
                creatieDatum = value;
            }
        }

        public decimal VorigSaldo { get; private set; }




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

            Console.WriteLine($"Rekeningnummer: {Rekeningnummer}");
            Console.WriteLine($"Creatiedatum: {CreatieDatum.ToShortDateString()}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        public void Storten(decimal stortBedrag)
        {
            VorigSaldo = Saldo;
            Saldo += stortBedrag;
            if (RekeningUittreksel != null)
                RekeningUittreksel(this);
        }

        public void Afhalen(decimal afhaalBedrag)
        {
            if (Saldo >= afhaalBedrag)
            {
                VorigSaldo = Saldo;
                Saldo -= afhaalBedrag;
                if (RekeningUittreksel != null)
                    RekeningUittreksel(this);
            }
            else
            {
                if (SaldoInHetRood != null)
                    SaldoInHetRood(this);
            }

        }

        // Events
        public event Transactie RekeningUittreksel;
        public event Transactie SaldoInHetRood;
    }
}
