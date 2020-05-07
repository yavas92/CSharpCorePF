using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCorePFCursus
{
    public partial class Klant
    {
		// Code gegenereerd door Visual Studio...
		private string naam;
		public string Naam
		{
			get { return naam; }
			set { naam = value; NaamChanged(naam); }
		}

		partial void NaamChanged(string naam);
	}
}
