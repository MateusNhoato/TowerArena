namespace Items
{
    internal class EspadaCurta : Arma
    {
        public EspadaCurta()
        {
            Nome = "Espada Curta";
            Descricao = "| Dano: 1-6";
        }
        public override int Dano { get => new Random().Next(1, 7); }

    }
}
