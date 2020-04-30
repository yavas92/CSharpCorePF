using System;
using Firma;
using Firma.Personeel;
using Firma.Materiaal;

namespace CSharpCorePFCursus
{
    class Program
    {
        delegate void WerknemersLijst(Werknemer[] werknemers);
        static void Main(string[] args)
        {
            Console.WriteLine("Provincie: ");
            string provincie = Console.ReadLine();
            try
            {
                ProvincieInfo info = new ProvincieInfo();
                Console.WriteLine(info.ProvincieGrootte(provincie));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // p266
        }
    }
}
