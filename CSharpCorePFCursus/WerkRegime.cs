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
                    return Type switch
                    {
                        RegimeType.Voltijds => 25,
                        RegimeType.Viervijfde => 20,
                        RegimeType.Halftijds => 12,
                        _ => 0,
                    };
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
