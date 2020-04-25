namespace Oefening1BoekBoekenrek
{
    public class Doelgroep
    {
        // Constructor
        public Doelgroep(int leeftijd)
        {
            Leeftijd = leeftijd;
        }

        // Properties
        public string Categorie
        {
            get
            {
                if (Leeftijd < 18)
                    return "Jeugd";
                else
                    return "Volwassenen";
            }
        }

        private int leeftijdValue;

        public int Leeftijd
        {
            get { return leeftijdValue; }
            set
            {
                if (value > 0)
                    leeftijdValue = value;
            }
        }

    }
}