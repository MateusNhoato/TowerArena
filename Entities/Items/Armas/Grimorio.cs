namespace Items
{
    internal class Grimorio : Arma
    {
        public Grimorio() 
        {
            Nome = "Grimório";
        }
        public override int Dano { get => new Random().Next(250, 500); }
    }
}
