using System;

namespace HalloPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //geht nicht mehr weil die klasse nun abstract ist
            //Lebewesen lw = new Lebewesen();
            //ZeigeWasBinIch(lw);

            Mensch m = new Mensch();
            ZeigeWasBinIch(m);

            Baum b = new Baum();
            ZeigeWasBinIch(b);

            Vogel v = new Vogel();
            ZeigeWasBinIch(v);

            Sprich(v);
            Sprich(m);
            //Sprich(b);


            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void Sprich(ICanSpeak speaker)
        {
            Console.WriteLine($"{speaker.Sprache }: {speaker.Sprechen("Hallo")}");
        }

        static void ZeigeWasBinIch(Lebewesen lw)
        {
            Console.WriteLine($"{lw.WasBinIch()} " +
                $"mit dem Namen {lw.SagMitDeinenName()}");
        }
    }
}
