namespace Items
{
    internal class Varinha : Arma
    {
        public Varinha()
        {
            Nome = "Varinha";          
        }
        public override int Dano { get => new Random().Next(7, 71); }
    }
}
