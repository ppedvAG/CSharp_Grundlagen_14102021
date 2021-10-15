using System;

namespace HalloKlassen
{
    public class Katze
    {
        //prop [TAB] [TAB] string [TAB] [TAB] Name
        public string Name { get; set; }
        public DateTime GebDatum { get; set; }
        public string Farbe { get; set; }
        public string Rasse { get; set; }
        public double Gewicht { get; set; }
        public Geschlecht Geschlecht { get; set; }
    }

}
