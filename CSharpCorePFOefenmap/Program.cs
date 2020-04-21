using CSharpCorePFOefenmap;
using System;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 Variabelen, constanten en bewerkingen
            //-------------------------------------------

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



            // 2 Selecties
            //-------------

            // 2.1 Kortingsbon
            /*
            Een kledingzaak geeft een kortingsbon afhankelijk van je aankoopgedrag van het afgelopen jaar. Heb je voor minder 
            dan 25 euro aangekocht, dan krijg je een bon ter waarde van 1% van je aankopen. Bij een aankoop van 25 euro of meer
            maar minder dan 50 euro is dit 2%, van 50 tot 100 euro 3% en vanaf 100 euro is het 5%. Voer een aankoopbedrag in, 
            bereken en toon de waarde van de bijhorende korting.
            */

            //Console.Write("Tik een aankoopbedrag in: ");
            //double aankoopbedrag = int.Parse(Console.ReadLine());
            //double kortingsbon = 0;

            //if (aankoopbedrag < 25)
            //{
            //    kortingsbon = aankoopbedrag * 0.01;
            //} else if (aankoopbedrag >= 25 && aankoopbedrag < 50)
            //{
            //    kortingsbon = aankoopbedrag * 0.02;
            //} else if (aankoopbedrag >= 50 && aankoopbedrag < 100)
            //{
            //    kortingsbon = aankoopbedrag * 0.03;
            //} else if (aankoopbedrag >= 100)
            //{
            //    kortingsbon = aankoopbedrag * 0.05;
            //}

            //Console.WriteLine($"U krijgt een kortingsbon cadeau ter waarde van {kortingsbon} euro!");



            // 2.2 Schrikkeljaar
            /*
            Bereken of een ingevoerd jaartal een schrikkeljaar is of niet. Alle jaren die deelbaar zijn door 4 zijn 
            schrikkeljaren behalve de jaren die deelbaar zijn door 100 en niet deelbaar zijn door 400.
            */

            //Console.Write("Geef een jaartal in: ");
            //int jaar = int.Parse(Console.ReadLine());
            //System.Text.StringBuilder schrikkeljaar = new System.Text.StringBuilder("geen");

            //if (jaar % 4 == 0)
            //{
            //    if (jaar % 100 == 0 && jaar % 400 != 0)
            //    {
            //        // doet niks want schrikkeljaar staat al op "geen schrikkeljaar"
            //    }
            //    else
            //    {
            //        schrikkeljaar.Clear();
            //        schrikkeljaar.Append("een");
            //    }
            //}

            //Console.WriteLine($"{jaar} is {schrikkeljaar} schrikkeljaar.");



            // 2.3 Lichtkrant
            /*
            Een winkel toont de openingsuren en een gepaste boodschap via een lichtkrant aan de 
            klanten.

            Schrijf een programma dat aan de gebruiker een willekeurige datum vraagt en de juiste 
            openingsuren en de juiste boodschap vermeldt, afhankelijk van de dag van de week:

             * *Zie takenbundel voor tabel
            */

            //Console.WriteLine("Geef een willekeurig datum in ");
            //DateTime datum = DateTime.Parse(Console.ReadLine());

            //switch ((int) datum.DayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine("Zondag: Gesloten");
            //        Console.WriteLine("We wensen u een fijn weekend!");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("maandag t.e.m. vrijdag: 9u00 tot 12-00 en van 13u00 tot 18u00");
            //        Console.WriteLine("We wensen u een prettige werkdag!");
            //        break;
            //    case 6:
            //        Console.WriteLine("zaterdag: 10u00 tot 12-00");
            //        Console.WriteLine("We wensen u een fijn weekend!");
            //        break;
            //     }



            // 3 Iteraties
            //-------------

            // 3.1 Kleinste, grootste en gemiddelde
            /*
            Voer een aantal positieve getallen in en bereken er de kleinste, grootste en gemiddelde 
            waarde van. Beëindig de invoer van de getallen met -1.
            */

            //int getal, kleinste = 0, grootste = 0, gemiddelde = 0, aantal = 0;
            //Console.WriteLine("Voer positieve getallen in (eindig met -1)");
            //while ((getal = int.Parse(Console.ReadLine())) != -1)
            //{
            //    if (kleinste != 0 && grootste != 0)
            //    {
            //        kleinste = getal < kleinste ? getal : kleinste;
            //        grootste = getal > grootste ? getal : grootste;
            //        gemiddelde += getal;
            //        aantal++;
            //    }
            //    else if (getal != 0)
            //    {
            //        kleinste = getal;
            //        grootste = getal;
            //    }
            //}

            //Console.WriteLine($"Kleinste: {kleinste}\nGrootste: {grootste}\nGemiddelde: {gemiddelde / aantal}");



            // 3.2 Priemgetal
            /*
            Bereken of een ingevoerd getal een priemgetal is of niet. Doe dit door het getal te delen 
            door alle getallen die liggen tussen 1 en het getal zelf.
            Toon de delers op het scherm. Besluit dan of het ingegeven getal een priemgetal is of niet.
            */

            //Console.WriteLine("Tik een getal in: ");
            //int getal = int.Parse(Console.ReadLine());
            //bool isPriem = true;

            //for (int i = 2; i < getal; i++)
            //{
            //    if (getal % i == 0) { Console.WriteLine($"{getal} is deelbaar door {i}."); isPriem = false; }
            //}

            //Console.Write($"{getal} is ");
            //if (isPriem) { Console.Write("een "); } else { Console.Write("geen "); }
            //Console.WriteLine("priemgetal.");



            // 3.3 IBAN rekeningnummer generator
            /*
            Het IBAN (International Bank Account Number) bankrekeningnummer heeft een vaste lengte per
            land en bestaat in België uit 16 tekens.

            O.w.v. de leesbaarheid wordt het voorgesteld in 4 groepen van 4 tekens:
            BE73 0631 5475 6360

            een landcode (2 letters, BE) + een controlegetal (2 cijfers) + het nationaal rekeningnummer
            (12cijfers).

            Om het nationaal rekeningnummerformaat (063-1547563-60) om te zetten in een IBAN 
            rekeningnummerformaat kan je de volgende werkwijze toepassen:

            * Schrap alle niet-alfanumerieke tekens: 063-1547563-60 -> 063154756360
            * Voeg achteraan de landcode, gevolgd door “00” toe: 0631547563606360 -> 063154756360BE00
            * Vervang de letters door cijfers, meer bepaald door hun positie in het alfabet, vermeerderd met 9 (A=10, B=11, … Z=35): 063154756360BE00 -> 063154756360111400
            * Deel dit getal door 97 en trek de rest van deze deling af van 98. Wanneer dit resultaat slechts één cijfer is, laat dit dan voorafgaan door een 0 (nul): 73
            * Dit cijfer is het controlegetal dat volgt op de landcode in het IBAN rekeningnummer: BE73 0631 5475 6360
            * Schrijf een programma dat het IBAN bankrekeningnummer genereert op basis van een opgegeven Belgisch bankrekeningnummer.
            */

            //const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.Write("Geef rekeningnummer in: ");
            //string rekeningNr = Console.ReadLine();
            //const string landcode = "BE00";

            //StringBuilder bewerkteRekeningNr = new StringBuilder(rekeningNr.Replace("-", ""));
            ////Schrap alle niet-alfanumerieke tekens: 063-1547563-60 -> 063154756360
            //StringBuilder bewerkteLandcode = new StringBuilder();
            //StringBuilder ibanVoorvoegsel = new StringBuilder();
            //StringBuilder ibanRekeningnummer = new StringBuilder();

            //ulong controlegetal;


            //for (int i = 0; i < landcode.Length; i++)
            //{
            //    if (alfabet.IndexOf(landcode[i]) != -1)
            //    {
            //        bewerkteLandcode.Append(alfabet.IndexOf(landcode[i]) + 10);
            //        // Vervang de letters door cijfers
            //    }
            //    else
            //    {
            //        bewerkteLandcode.Append(landcode[i]);
            //    }
            //}

            //bewerkteRekeningNr.Append(bewerkteLandcode);
            //// Voeg achteraan de BEWERKTE landcode

            //controlegetal = 98 - (ulong.Parse(bewerkteRekeningNr.ToString()) % 97);

            //ibanVoorvoegsel.Append("BE" + (controlegetal > 9 ? controlegetal.ToString() : "0" + controlegetal.ToString()));
            //// IBAN voorvoegsel met landcode berekenen + aanmaken

            //ibanRekeningnummer.Append(ibanVoorvoegsel + rekeningNr.Replace("-", ""));
            //ibanRekeningnummer.Insert(12, "-");
            //ibanRekeningnummer.Insert(8, "-");
            //ibanRekeningnummer.Insert(4, "-");

            //Console.WriteLine($"Rekeningnummer: {rekeningNr}\nIBAN: {ibanRekeningnummer}");



            // 3.4 Controle IBAN rekeningnummer
            /*
            Schrijf een programma om te controleren of een IBAN rekeningnummer een geldig nummer is. 
            Hiervoor kan je als volgt tewerk gaan:
            
            * Schrap alle spaties uit het IBAN nummer -> BE73063154756360
            * Verplaats de eerste 4 tekens naar uiterst rechts -> 063154756360BE73
            * Vervang de letters door cijfers, meer bepaald door hun positie in het alfabet, vermeerderd met 9 (A=10, B=11, … Z=35) -> 063154756360111473
            * Deel dit getal door 97. Voor een geldig IBAN rekeningnummer moet de rest van deze deling gelijk zijn aan 1 
            */

            //const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //StringBuilder ibanRekeningnummer = new StringBuilder("BE56 0019 0020 0088");
            //StringBuilder ibanVoorvoegsel = new StringBuilder();
            //StringBuilder cijfers = new StringBuilder();


            //ibanRekeningnummer.Replace(" ", "");
            //ibanVoorvoegsel.Append(ibanRekeningnummer.ToString().Substring(0, 4));
            //ibanRekeningnummer.Remove(0, 4);

            //for (int i = 0; i < ibanVoorvoegsel.Length; i++)
            //{
            //    if (alfabet.IndexOf(ibanVoorvoegsel[i]) != -1)
            //    {
            //        cijfers.Append(alfabet.IndexOf(ibanVoorvoegsel[i]) + 10);
            //    } else
            //    {
            //        cijfers.Append(ibanVoorvoegsel[i]);
            //    }
            //}
            //ibanRekeningnummer.Append(cijfers);

            //string isGeldig = ulong.Parse(ibanRekeningnummer.ToString()) % 97 == 1? "een" : "geen";
            //Console.WriteLine($"Dit is {isGeldig} geldige IBAN nummer."); 



            // 4 Arrays
            //-------------------

            // 4.1 Codeerprogramma
            // Zie opgave in pdf

            //char[] alfabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] sleutel = { 'Q', 'S', 'P', 'A', 'T', 'V', 'X', 'B', 'C', 'R', 'J', 'Y', 'E', 'D', 'U', 'O', 'H', 'Z', 'G', 'I', 'F', 'L', 'N', 'W', 'K', 'M' };

            //Console.WriteLine("Geef een tekst in:");
            //String tekst = Console.ReadLine().ToUpper();
            //StringBuilder gecodeerdeTekst = new StringBuilder();

            //for (int i = 0; i < tekst.Length; i++)
            //{
            //    for (int j = 0; j < alfabet.Length; j++)
            //    {
            //        if (tekst[i] == alfabet[j])
            //        {
            //            gecodeerdeTekst.Append(sleutel[j]);
            //            break;
            //        }
            //        else if (j == alfabet.Length - 1)
            //        {
            //            gecodeerdeTekst.Append(tekst[i]);
            //        }
            //    }
            //}
            //Console.WriteLine(gecodeerdeTekst);



            // 5 Classes, objects, objectvariables, constructors
            //-------------------------------------------------------

            // 5.1 Oefening Bank
            // Zie opgave in pdf

            //Rekening rekening = new Rekening(rekeningNummer: "BE23377019153291", creatieDatum: new DateTime(2020, 4, 14));
            //rekening.Afbeelden();
            //rekening.Storten(stortBedrag: 2000);
            //rekening.Afbeelden();



            // 5.2 Oefening Voertuig
            // Zie opgave in pdf

            //Voertuig v1 = new Voertuig("Burcu Köse", 25000m, 136, 6.6f, "CANIM SIVAS");
            //Voertuig v2 = new Voertuig("Abdullah Yavas", 12500m, 100, 5.5f, "1-EMD-003");
            //v1.Afbeelden();
            //v2.Afbeelden();



            // 6 Inheritance
            //-----------------

            // 6.1 Oefening Bank (zie opgave cursus)

            //Spaarrekening r1 = new Spaarrekening("BE23377019153291", DateTime.Today, 1);
            //Zichtrekening r2 = new Zichtrekening("BE23377019153291", DateTime.Today, -2000m);

            //r1.Storten(1000);
            //r2.Storten(125m);

            //r1.Afbeelden();
            //r2.Afbeelden();



            // 6.2 Oefening Voertuigen (zie opgave cursus)

            //Vrachtwagen v1 = new Vrachtwagen("Abdullah Yavas", 60000, 450, 20, "1-VRA-003");
            //Personenwagen v2 = new Personenwagen();

            //v1.Afbeelden();
            //v2.Afbeelden();



            // 7 Abstract classes, abstract members, static members
            //---------------------------------------------------------

            // 7.1 Oefening Bank
            // Classes aangepast

            // 7.2 Oefening Voertuigen
            // Classes aangepast


            // 8 Inheritance polymorphisme
            //-------------------------------

            // 8.1 Oefening Bank
            /*
            Creëer een array van twee rekeningen. Initialiseer de eerste rekening als een spaarrekening gebruik 
            makend van een geparametriseerde constructor. De tweede rekening is een zichtrekening, eveneens te 
            initialiseren met een geparametriseerde constructor. Overloop de array met een foreach opdracht en roep de
            method Afbeelden() op om het polymorphisme te demonstreren.
            */

            //Spaarrekening.Intrest = 2f;
            //Rekening[] mijnRekeningen = new Rekening[2];
            //mijnRekeningen[0] = new Spaarrekening("BE23377019153291", 10000m, DateTime.Now);
            //mijnRekeningen[1] = new Zichtrekening("BE23377019153291", 1500m, DateTime.Now, -2000m);

            //foreach (Rekening eenRekening in mijnRekeningen)
            //{
            //    eenRekening.Afbeelden();
            //    Console.WriteLine();
            //}


            // 8.2 Oefening Voertuigen
            /*
            Vul een array op met één personenwagen en één vrachtwagen. Toon de gegevens en de kyoto-score van beide 
            voertuigen op het scherm.
            */

            //Voertuig[] mijnVoertuigen = new Voertuig[2];
            //mijnVoertuigen[0] = new Personenwagen("Abdullah Yavas", 25000m, 200, 8.6f, "1-AAA-000", 4, 5);
            //mijnVoertuigen[1] = new Vrachtwagen("Abdullah Yavas", 45000m, 400, 20f, "1-BBB-111", 15000f);

            //foreach (Voertuig eenVoertuig in mijnVoertuigen)
            //{
            //    eenVoertuig.Afbeelden();
            //    Console.WriteLine($"Kyoto score: {Math.Round(eenVoertuig.GetKyotoScore()*100)/100}");
            //    Console.WriteLine();
            //}



            // 9 Aggregation
            //----------------

            // 9.1 Oefening Bank

            //Klant ik = new Klant("Abdullah", "Yavas");
            //Spaarrekening sRekening = new Spaarrekening(ik, "BE23377019153291", 20000, DateTime.Today);
            //Zichtrekening zRekening = new Zichtrekening(ik, "BE23377019153291", 2500, DateTime.Today, -1000);

            //sRekening.Afbeelden();
            //Console.WriteLine();
            //zRekening.Afbeelden();
        }
    }
}
