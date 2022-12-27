using Enums;

namespace Items
{
    internal class ArcoEFlecha : Arma
    {
        public ArcoEFlecha()
        {
            Nome = "Arco e Flecha";
            Peso = 7;
            TipoDeArma = TipoDeArma.arcoEFlecha;
            Dano = 35;
        }
    }
}
