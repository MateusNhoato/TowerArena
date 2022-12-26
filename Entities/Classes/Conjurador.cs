
using Items;
using Rpg_De_Console.Entities;

namespace Classes
{
    internal class Conjurador : Classe
    {
        public Conjurador()
        {
            Nome = "Conjurador";
            Arma = new Varinha();
          
            VidaPorNivel = 1;
            ManaPorNivel = 4;
            PoderPorNivel = 3;
            DefesaPorNivel = 1;
            IniciativaPorNivel = 1;
        }


        // habilidades

        protected override void Habilidade1(CriaturaBase alvo)
        {
           
        }

        protected override void Habilidade2(CriaturaBase alvo)
        {
            
        }

       
    }
}
