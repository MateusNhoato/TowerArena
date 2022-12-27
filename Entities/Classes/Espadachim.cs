
using Items;

using Entities;

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

        private protected override void AdicionarHabilidades()
        {
            throw new NotImplementedException();
        }

        // habilidades

        // golpe duplo


        // instância de defesa



    }
}
