using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFOefenmap
{
    class Stookketel : IVervuiler
    {
        // Constructor
        public Stookketel(float CONorm)
        {
            this.CONorm = CONorm;
        }

        // Properties
        private float CONormValue;

        public float CONorm
        {
            get { return CONormValue; }
            set
            {
                if (value >= 0f)
                    CONormValue = value;
            }
        }

        public double GeefVervuiling()
        {
            return CONorm * 100;
        }
    }
}
