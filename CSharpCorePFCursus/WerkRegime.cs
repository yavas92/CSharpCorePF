using System;
using System.Collections.Generic;
using System.Text;

namespace Firma.Personeel
{
    public abstract partial class Werknemer
    {
        // Nested class
        public class WerkRegime
        {
            public enum RegimeType
            {
                Voltijds, Viervijfde, Halftijds
            }

            // Constructor
            public WerkRegime(RegimeType type)
            {
                Type = type;
            }

            // Properties
            public RegimeType Type { get; set; }

            public int AantalVakantiedagen
            {
                get
                {
                    switch (Type)
                    {
                        case RegimeType.Voltijds:
                            return 25;
                        case RegimeType.Viervijfde:
                            return 20;
                        case RegimeType.Halftijds:
                            return 12;
                        default:
                            return 0;
                    }
                }
            }

            // Methods
            public override string ToString()
            {
                return Type.ToString();
            }
        }
    }
}
