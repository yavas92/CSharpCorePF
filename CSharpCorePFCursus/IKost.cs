using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    interface IKost
    {
        decimal Bedrag
        {
            get;
        }
        bool Menselijk
        {
            get;
        }
    }
}
