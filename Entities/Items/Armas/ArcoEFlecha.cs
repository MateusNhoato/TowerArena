namespace Items
{
    internal class ArcoEFlecha : Arma
    {
        public ArcoEFlecha()
        {
            Nome = "Arco e Flecha";           
        }

        public override int Dano { get => new Random().Next(6, 61); }
    }
}
