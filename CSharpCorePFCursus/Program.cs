using System;

namespace CSharpCorePFCursus
{
    public static class Rekenaar
    {
        class Program
        {
            static void Main(string[] args)
            {
                object [] kosten = new object[5];

                kosten[0] = new Arbeider("Asterix", DateTime.Now, Geslacht.Man, 24.79m, 3);
                kosten[1] = new Bediende("Obelix", DateTime.Now, Geslacht.Man, 2400.79m);
                kosten[2] = new Manager("Idefix", DateTime.Now, Geslacht.Man, 2400.79m, 7000m);
                kosten[3] = new Fotokopiemachine("123", 500, 0.025m);
                kosten[4] = new string("Abdullah"); 


                foreach (object obj in kosten)
                {
                    Console.WriteLine(obj is IKost);
                }
            }
        }
    }
}
