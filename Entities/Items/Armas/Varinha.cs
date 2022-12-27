using Enums;
namespace Items
{
    internal class Varinha : Arma
    {
        public Varinha()
        {
            Nome = "Varinha";
            Peso = 5;
            TipoDeArma = TipoDeArma.varinha;
            Dano = 25;
        }
    }
}
