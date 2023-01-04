namespace Items
{
    internal class Sabre : Arma
    {
        public Sabre()
        {
            Nome = "Sabre";
            Descricao = "(Dano: 1-10)";
        }
        public override int Dano { get => new Random().Next(1, 10); }
    }
}
