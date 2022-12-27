using Enums;

namespace Items
{
    abstract class Arma : Item
    {
        public  TipoDeArma TipoDeArma { get; protected set; }
        public int Dano { get; protected set; }
    }
}
