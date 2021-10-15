using System;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Katze meineKatze; //deklaration
            meineKatze = new Katze(); //intanzierung
            meineKatze.Name = "Henri";
            meineKatze.Gewicht = 6.2;
            meineKatze.Farbe = "black tabby";
            meineKatze.Rasse = "maine coon";
            meineKatze.GebDatum = new DateTime(2002, 10, 16);
            meineKatze.Geschlecht = Geschlecht.Männlich;

            ZeigeKatze(meineKatze);
        }

        static void ZeigeKatze(Katze katze)
        {
            //Console.WriteLine("Name: " + katze.Name+ " Gewicht: " + katze.Gewicht.ToString("0.00") + " Kg");

            //Console.WriteLine(string.Format("Name: {0} Gewicht: {1:0.00} Kg", katze.Name, katze.Gewicht));

            Console.WriteLine($"Name: {katze.Name} Gewicht: {katze.Gewicht:0.00} Kg"); //string interpolation = neu und cool!

            Console.WriteLine($"{katze.GebDatum:dddd} {katze.GebDatum:MMMM} {katze.GebDatum:yyyyy}");

            katze.Farbe = "rosa";
            Console.WriteLine($"{katze.Farbe}");

            katze.Rasse = "kurzhaar";
            Console.WriteLine(katze.Rasse);
        }
    }

}
