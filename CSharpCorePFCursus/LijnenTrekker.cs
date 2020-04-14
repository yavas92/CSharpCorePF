using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    class LijnenTrekker
    {

        public void TrekLijn(int lengte, char teken = '-')
        {
            for (int i = 0; i < lengte; i++)
                Console.Write(teken);
            Console.WriteLine();
        }

        public void TrekLijn(int lengte)
        {
            TrekLijn(lengte, '-');
        }

        public void TrekLijn()
        {
            TrekLijn(79);
        }
    }
}
