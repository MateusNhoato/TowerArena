namespace Items
{
    internal class DuasEspadas : Arma
    {
        public DuasEspadas() 
        {
            Nome = "Duas Espadas";
        }
        public override int Dano { get => new Random().Next(300, 601); }
    }
}
