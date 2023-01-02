namespace Items
{
    internal class EspadaEEscudo : Arma
    {
           public EspadaEEscudo()
        {
            Nome = "Espada e Escudo";

        }
        public override int Dano { get => new Random().Next(1, 7); }
    }
}
