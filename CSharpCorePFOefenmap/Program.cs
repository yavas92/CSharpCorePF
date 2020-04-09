using System;

namespace CSharpCorePFCursus
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 Conversie Celsius  Fahrenheit
            /* 
            Bereken de gemiddelde lichaamstemperatuur in graden Fahrenheit als je weet dat deze in Celsius 37° is. Om 
            graden Celsius om te zetten naar Fahrenheit vermenigvuldig je deze met 9/5 en tel je er 32 bij op.
            Gebruik een constante GemLichTempCelsius en geef deze de waarde 37.Toon het resultaat op het scherm.

            Om een samengestelde string af te beelden kan je i.p.v.de + -operator gebruik maken van zogenaamde placeholder
            of van een interpolated string.Uitleg hierover vind je in de cursus in het hoofdstuk HET TYPE STRING paragraaf
            EEN SAMENGESTELDE STRING AFBEELDEN. 
            */

            //double gradenCelsius = 37;
            //double gradenFahrenheit = gradenCelsius * 9 / 5 + 32;
            //Console.WriteLine("Graden Celsius: " + gradenCelsius + "°C");
            //Console.WriteLine("Graden Fahrenheit: " + gradenFahrenheit + "°F");



            // 1.2 Omrekening seconden
            /*
            Maak een programma dat een geheel aantal seconden, bijvoorbeeld 3736, omrekent in uren, minuten en seconden. 
            Toon het resultaat als volgt: U:1 M:2 S:16.
            */

            //int getal = 3736;
            //int uren = getal / 3600;
            //int minuten = (getal % 3600) / 60;
            //int seconden = (getal % 3600) % 60;
            //Console.WriteLine(getal + " seconden is gelijk aan:");
            //Console.WriteLine(uren + "u " + minuten + "min " + seconden + "sec");



            // 1.3 Snoepautomaat
            /*
            Bij een snoepautomaat bedraagt de maximale kostprijs van een stuk snoep 2 €. De klant kan enkel betalen 
            met een muntstuk van € 2.
            Schrijf een programma dat het wisselgeld uitrekent nl. hoeveel muntstukken 
            van 1 euro, 50, 20, 10, 5, 2 en 1 cent er teruggegeven worden, en dit met zo weinig mogelijk munten.
            Toon het te betalen bedrag, het bedrag aan wisselgeld en hoeveel munten er van elk muntstuk teruggegeven worden.
            Test dit uit voor een aantal bedragen.
            */

            //double bedrag = 0.85;
            //double wisselgeld = 2 - bedrag;
            //int wisselcentjes = (int)(wisselgeld * 100);
            //Console.WriteLine(wisselgeld);


            //int éénEuro = wisselcentjes / 100;
            //int vijftigCent = (wisselcentjes % 100) / 50;
            //int twintigCent = (wisselcentjes % 50) / 20;
            //int tienCent = (wisselcentjes % 50 % 20) / 10;
            //int vijfCent = (wisselcentjes % 10) / 5;
            //int tweeCent = (wisselcentjes % 5) / 2;
            //int éénCent = (wisselcentjes % 5 % 2) / 1;

            //Console.WriteLine(wisselcentjes % 10);

            //Console.WriteLine("De snoep kost " + bedrag + " euro en u betaalde 2 euro");
            //Console.WriteLine("Wisselgeld = " + wisselgeld);
            //Console.WriteLine(éénEuro + " x 1 euro");
            //Console.WriteLine(vijftigCent + " x 50 cent");
            //Console.WriteLine(twintigCent + " x 20 cent");
            //Console.WriteLine(tienCent + " x 10 cent");
            //Console.WriteLine(vijfCent + " x 5 cent");
            //Console.WriteLine(tweeCent + " x 2 cent");
            //Console.WriteLine(éénCent + " x 1 cent");



            

        }
    }
}
