using System;

namespace HalloKlassen
{
    public class Tier : Object
    {
        //prop [TAB] [TAB] string [TAB] [TAB] Name
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
        public string Farbe { get; set; }
        public string Rasse { get; set; }
        public double Gewicht { get; set; }
        public Geschlecht Geschlecht { get; set; }

        public Tier() //default konstruktor
        {
            Farbe = "weiss";
        }

        public Tier(string name)
        {
            Name = name;
        }
    }

}
