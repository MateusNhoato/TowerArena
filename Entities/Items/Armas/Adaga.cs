namespace Items
{
    internal class Adaga : Arma
    {

        public Adaga()
        {
            Nome = "Adaga";
        }


        public override int Dano { get => new Random().Next(1, 5); }
    }
}
