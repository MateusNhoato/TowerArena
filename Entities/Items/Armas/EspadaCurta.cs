namespace Items
{
    internal class EspadaCurta : Arma
    {
        public EspadaCurta() 
        {
            Nome = "Espada Curta";
        }
        public override int Dano { get => new Random().Next(5, 51); }

    }
}
