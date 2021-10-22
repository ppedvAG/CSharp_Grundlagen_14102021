using System;

namespace HalloPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lebewesen lw = new Lebewesen();
            ZeigeWasBinIch(lw);

            Mensch m = new Mensch();
            ZeigeWasBinIch(m);

                
            Console.WriteLine("Ende");
            Console.ReadLine();
        }
        static void ZeigeWasBinIch(Lebewesen lw)
        {
            Console.WriteLine(lw.WasBinIch());
        }
    }
}
