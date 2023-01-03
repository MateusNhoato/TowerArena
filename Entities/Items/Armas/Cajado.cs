namespace Items
{
    internal class Cajado : Arma
    {
        public Cajado()
        {
            Nome = "Cajado";
            Descricao = "| Dano: 1-6 +4";

        }
        public override int Dano { get => new Random().Next(1, 7) + 4; }
    }
}
