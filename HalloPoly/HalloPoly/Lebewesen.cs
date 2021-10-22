namespace HalloPoly
{
    abstract class Lebewesen
    {
        public abstract string SagMitDeinenName();

        public virtual string WasBinIch()
        {
            return "Ich bin ein Lebewesen";
        }
    }

    interface ICanSpeak
    {
        string Sprache { get; }
        string Sprechen(string text);
    }

    class Vogel : Lebewesen, ICanSpeak
    {
        public string Sprache { get { return "Piepisch"; } }

        public override string SagMitDeinenName()
        {
            return "Rudi";
        }

        public string Sprechen(string text)
        {
            return $"BRAAAAA {text}";
        }
    }

    class Baum : Lebewesen
    {
        public override string SagMitDeinenName()
        {
            return "Walter";
        }
    }

    class Mensch : Lebewesen, ICanSpeak
    {
        public string Sprache
        {
            get { return "DE"; }
        }

        public override string SagMitDeinenName()
        {
            return "Fred";
        }

        public string Sprechen(string text)
        {
            return $"BLA BLA BLA {text}";
        }

        public override string WasBinIch()
        {
            return "Ich bin ein Mensch";
        }
    }
}
