namespace Items
{
    internal class Adaga : Arma
    {

        public Adaga()
        {
            Nome = "Adaga";
            Descricao = "| Dano: 1-4";
        }


        public override int Dano { get => new Random().Next(1, 4); }
    }
}
