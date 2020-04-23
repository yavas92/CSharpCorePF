using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
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
