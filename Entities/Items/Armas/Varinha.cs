using Enums;
namespace Items
{
    internal class Varinha : Arma
    {
        public Varinha()
        {
            Nome = "Varinha";
            Peso = 0.5;
            TipoDeArma = TipoDeArma.varinha;
            Dano = 5;
        }
    }
}
