using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    class Omzetter
    {
        public const double centimetersPerInch = 2.54;
        public double CmNaarInch(double cm)
        {
            return cm / centimetersPerInch;
        }

        public double InchNaarCm(double inch)
        {
            return inch * centimetersPerInch;
        }
    }
}
