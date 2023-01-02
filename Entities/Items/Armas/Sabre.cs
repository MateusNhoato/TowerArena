namespace Items
{
    internal class Sabre : Arma
    {
        public Sabre() 
        {
            Nome = "Sabre";
        }
        public override int Dano { get => new Random().Next(1, 13); }
    }
}
