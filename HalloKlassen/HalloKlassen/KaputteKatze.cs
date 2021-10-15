using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    class KaputteKatze
    {
        internal string name;

        public double gewicht;

        //public DateTime gebDatum;
        public Geschlecht geschlecht;

        public DateTime GebDatum { get; internal set; } //Auto Property

        private string rasse; //field
        public string Rasse //(full) property
        {
            get
            {
                return rasse;
            }
            internal set
            {
                rasse = value;
            }
        }


        private string farbe; //daten (backing field)
        public string GetFarbe() //getter 
        {
            return farbe;
        }
        internal void SetFarbe(string farbe) //setter
        {
            if (farbe != "rosa")
                this.farbe = farbe;
        }
    }
}
