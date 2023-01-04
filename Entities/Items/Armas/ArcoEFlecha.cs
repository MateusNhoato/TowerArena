namespace Items
{
    internal class ArcoEFlecha : Arma
    {
        public ArcoEFlecha()
        {
            Nome = "Arco e Flecha";
            Descricao = "(Dano: 1-6 +1(flecha))";
        }

        public override int Dano { get => new Random().Next(1, 7) + 1; }
    }
}
