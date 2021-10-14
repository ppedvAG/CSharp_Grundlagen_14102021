using System;

namespace HalloDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string text = "Hallo String";
            Console.WriteLine(text + " und " + text);
            char buchstabe = 'b';

            int zahl = 23;
            Console.WriteLine("Zahl: " + zahl); //implizit 
            Console.WriteLine("Zahl: " + zahl.ToString()); //explizit 

            float kommaZahlFloat = 23.55f;
            double kommaZahl = 23.55;
            decimal kommaZahlDecimal = 23.55m;
            Console.WriteLine("Komma Zahl:" + kommaZahl);

            //parsen
            Console.WriteLine("Bitte eine Zahl eingeben:");
            string eingabeAlsString = Console.ReadLine();
            Console.WriteLine("Du hast eingegeben: " + eingabeAlsString);
            int eingabeAlsInt = int.Parse(eingabeAlsString);
            Console.WriteLine("Das doppelte ist: " + eingabeAlsInt * 2);

            //convertieren / casten
            double zahlAlsDouble = zahl; //implizit
            int doubleAlsInt = (int)kommaZahl; //explizit
            Console.WriteLine(doubleAlsInt);
            Console.WriteLine(Math.Round(kommaZahlDecimal, 0, MidpointRounding.AwayFromZero));

        }
    }
}
