namespace HelloWorld
{
    public interface IMinMenu
    {
        int Kesto { get; set; }
        string Nimi { get; set; }
        int Vuosi { get; set; }

        void Tallennus();
        void Valinta();
    }
}