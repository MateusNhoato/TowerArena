namespace Items
{
    internal class EspadaEEscudo : Arma
    {
        public EspadaEEscudo()
        {
            Nome = "Espada e Escudo";
            Descricao = "(Dano: 1-6 | DEFESA: 1-6)";

        }
        public override int Dano { get => new Random().Next(1, 7); }
    }
}
