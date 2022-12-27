using Enums;

namespace Items
{
    internal class ArcoEFlecha : Arma
    {
        public ArcoEFlecha()
        {
            Nome = "Arco e Flecha";
            Peso = 2.5;
            TipoDeArma = TipoDeArma.arcoEFlecha;
            Dano = 5;
        }
    }
}
