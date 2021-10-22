namespace Baummanager.Model
{
    public class Baum
    {
        public int Id { get; set; }
        public string Art { get; set; }
        public double MaxSize { get; set; }
        public int MaxAlter { get; set; }
        public Gattung Gattung { get; set; }
    }

    public enum Gattung
    {
        Laub,
        Nadel
    }

}
