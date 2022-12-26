
using Items;

using Rpg_De_Console.Entities;

namespace Classes
{
    internal class Espadachim : Classe
    {
        
        public Espadachim() 
        {
            Nome = "Espadachim";
            Arma = new EspadaCurta();
          
            VidaPorNivel = 3;
            ManaPorNivel= 1;
            PoderPorNivel = 2;
            DefesaPorNivel = 2;
            IniciativaPorNivel = 1;
        }

        // habilidades

        // golpe duplo
        protected override void Habilidade1(CriaturaBase alvo)
        {
            
        }

        // instância de defesa
        protected override void Habilidade2(CriaturaBase alvo)
        {
           
        }

        
    }
}
