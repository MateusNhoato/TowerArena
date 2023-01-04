namespace Items
{
    internal class Varinha : Arma
    {
        public Varinha()
        {
            Nome = "Varinha";
            Descricao ="(Dano: 1-4)";
        }
        public override int Dano { get => new Random().Next(1, 5); }
    }
}
