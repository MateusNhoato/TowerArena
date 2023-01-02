
namespace Items
{
    internal class ArcoEFlechaLongo : Arma
    {
        public ArcoEFlechaLongo()
        {
            Nome = "Arco e Flecha Longo";

        }
        public override int Dano { get => new Random().Next(1, 11) + 2; }
    }
}
