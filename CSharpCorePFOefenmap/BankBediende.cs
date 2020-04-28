using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class BankBediende
    {
        // Constructor
        public BankBediende(string voornaam, string naam)
        {
            Voornaam = voornaam;
            Naam = naam;
        }

        // Properties
        public string Voornaam { get; set; }
        public string Naam { get; set; }

        // Methods
        public void DrukRekeninguittrekselAf(Rekening rekening)
        {
            Console.WriteLine($"Rekeninguittreksel van {rekening.Rekeningnummer}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Vorig saldo: {rekening.VorigSaldo} euro");
            if (rekening.Saldo > rekening.VorigSaldo)
                Console.WriteLine($"Gestort bedrag: {rekening.Saldo - rekening.VorigSaldo} euro");
            else
                Console.WriteLine($"Afgehaald bedrag: {rekening.VorigSaldo - rekening.Saldo}");
            Console.WriteLine($"Nieuwe saldo: {rekening.Saldo} euro");
        }

        public void SaldoInHetRood(Rekening rekening)
        {
            Console.WriteLine("Afhaling niet mogelijk, saldo ontoereikend!");
            Console.WriteLine($"Maximum af te halen bedrag: {rekening.Saldo} euro");
        }
    }
}
