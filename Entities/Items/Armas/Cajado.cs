namespace Items
{
    internal class Cajado : Arma
    {
        public Cajado()
        {
            Nome = "Cajado";
            
        }
        public override int Dano { get => new Random().Next(1, 7) + 6; }
    }
}
