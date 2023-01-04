
namespace Items
{
    internal class ArcoEFlechaLongo : Arma
    {
        public ArcoEFlechaLongo()
        {
            Nome = "Arco e Flecha Longo";
            Descricao = "(Dano: 1-10 +2(flecha))";

        }
        public override int Dano { get => new Random().Next(1, 11) + 2; }
    }
}
