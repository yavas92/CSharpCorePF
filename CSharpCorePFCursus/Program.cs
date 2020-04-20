using System;

namespace CSharpCorePFCursus
{
    public static class Rekenaar
    {
        public static int Kwadraat(int getal)
        {
            return getal * getal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Werknemer ik = new Bediende("Asterix", DateTime.Today, Geslacht.Man, 1500m);
            Werknemer jij = new Bediende("Obelix", DateTime.Today, Geslacht.Man, 2300m);

            Console.WriteLine(ik.GetHashCode());
            Console.WriteLine(jij.GetHashCode());


            Bediende hij;

            hij = (Bediende)ik;
            hij.Afbeelden();
            Console.WriteLine(hij.GetHashCode());

            hij = ik as Bediende;
            if (hij != null)
            {
                hij.Afbeelden();
                Console.WriteLine(hij.GetHashCode()==ik.GetHashCode());
            }
                

            hij = jij as Bediende;
            if (hij != null)
            {
                hij.Afbeelden();
                Console.WriteLine(hij.GetHashCode());
            }

            
                
        }
    }
}
