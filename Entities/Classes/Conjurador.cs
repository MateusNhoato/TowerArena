
using Items;
using Entities;

namespace Classes
{
    internal class Conjurador : Classe
    {
        public Conjurador()
        {
            Nome = "Conjurador";
            Arma = new Varinha();
          
            VidaPorNivel = 3;
            ManaPorNivel = 8;
            PoderPorNivel = 8;
            DefesaPorNivel = 3;
            IniciativaPorNivel = 3;
        }

        private protected override void AdicionarHabilidades()
        {
            throw new NotImplementedException();
        }


        // habilidades





    }
}
