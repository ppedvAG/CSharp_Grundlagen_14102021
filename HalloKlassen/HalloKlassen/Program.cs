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
            meineKatze.Miauen();

            ZeigeTier(meineKatze);

            Console.WriteLine("------------------------------------------------");

            Hund einHund = new Hund();
            einHund.Bellen();
            ZeigeTier(einHund);

            Console.WriteLine(einHund.ToString());


        }

        static void ZeigeTier(Tier tier)
        {
            if (tier is Katze katze) //konvertiere das Tier in eine Katze, wenn es eine ist
            {
                Console.WriteLine("Das ist eine Katze ");
                katze.Miauen();
            }

            if (tier is Hund)
                Console.WriteLine("Das ist ein Hund");

            //Console.WriteLine("Name: " + katze.Name+ " Gewicht: " + katze.Gewicht.ToString("0.00") + " Kg");
            //Console.WriteLine(string.Format("Name: {0} Gewicht: {1:0.00} Kg", katze.Name, katze.Gewicht));

            Console.WriteLine($"Name: {tier.Name} Gewicht: {tier.Gewicht:0.00} Kg"); //string interpolation = neu und cool!
            Console.WriteLine($"{tier.GebDatum:dddd} {tier.GebDatum:MMMM} {tier.GebDatum:yyyyy}");

            tier.Farbe = "rosa";
            Console.WriteLine($"{tier.Farbe}");

            tier.Rasse = "kurzhaar";
            Console.WriteLine(tier.Rasse);
        }
    }

}
