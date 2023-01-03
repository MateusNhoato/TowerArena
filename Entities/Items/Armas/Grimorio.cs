namespace Items
{
    internal class Grimorio : Arma
    {
        public Grimorio()
        {
            Nome = "Grimório";
            Descricao = "| Dano: 1-6 +4";
        }
        public override int Dano { get => new Random().Next(1, 7) + 4; }
    }
}
