namespace Items
{
    internal class DuasEspadas : Arma
    {
        public DuasEspadas()
        {
            Nome = "Duas Espadas";
            Descricao = "(Dano: 1-6 + 1-6)";
        }
        public override int Dano { get => new Random().Next(1, 7) + new Random().Next(1, 7); }
    }
}
