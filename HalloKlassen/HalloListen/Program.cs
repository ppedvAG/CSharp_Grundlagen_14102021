using System;
using System.Collections.Generic;

namespace HalloListen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Listen!");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Args: {args[i]}");
            }

            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            int[] zahlen = new[] { 12, -7, 38, 2347849, 6456, 354, 345 };

            //Console.WriteLine(zahlen[0]);
            //Console.WriteLine(zahlen[1]);
            //Console.WriteLine(zahlen[2]);
            //Console.WriteLine(zahlen[3]);

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine($"{i}:  {zahlen[i]}");
            }
            Console.WriteLine("----------------------------------------------------");
     
            List<int> zahlenListe = new List<int>();
            zahlenListe.Add(16);
            zahlenListe.Add(13429785);
            zahlenListe.Add(-13429785);
            zahlenListe.Remove(16);

            foreach (int zahl in zahlenListe)
            {
                Console.WriteLine(zahl);
            }


        }
    }
}
