using System;
using System.Collections.Generic;

namespace ValueTypes_vs_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int zahl = 5; // value- / wertTyp
            Console.WriteLine($"Zahl: {zahl}");
            MachMehr(zahl);
            Console.WriteLine($"Zahl: {zahl}");

            Console.WriteLine("---------------------------------------");

            EineKlasse eineKlasse11 = null;

            if (eineKlasse11 != null)
                eineKlasse11.Zahl = 5;


            EineKlasse eineKlasse = new EineKlasse(); //referenztyp
            eineKlasse.Zahl = 5;
            Console.WriteLine($"Klasse: {eineKlasse.Zahl}");
            MachMehr(eineKlasse);
            Console.WriteLine($"Klasse: {eineKlasse.Zahl}");

            Console.WriteLine($"{eineKlasse11 == eineKlasse}");
            eineKlasse11 = eineKlasse;
            Console.WriteLine($"{eineKlasse11 == eineKlasse}");

            eineKlasse11 = new EineKlasse() { Zahl = 5 };
            Console.WriteLine($"{eineKlasse11 == eineKlasse}");


            //RAM füllen
            //List<EineKlasse> lala = new List<EineKlasse>();
            //while (true)
            //{
            //    lala.Add(new EineKlasse());
            //}

            Console.WriteLine("Ende");
            Console.ReadKey();
        }

        static void MachMehr(int eineZahl)
        {
            eineZahl = eineZahl + 5;
        }

        static void MachMehr(EineKlasse eineKlasse)
        {
            eineKlasse.Zahl = eineKlasse.Zahl + 5;
        }
    }

    class EineKlasse
    {
        public int Zahl { get; set; }
    }
}
