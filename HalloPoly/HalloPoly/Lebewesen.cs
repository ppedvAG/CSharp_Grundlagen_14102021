namespace HalloPoly
{
    class Lebewesen
    {
        public virtual string WasBinIch()
        {
            return "Ich bin ein Lebewesen";
        }
    }

    class Mensch : Lebewesen
    {
        public override string WasBinIch()
        {
            return "Ich bin ein Mensch";
        }
    }
}
