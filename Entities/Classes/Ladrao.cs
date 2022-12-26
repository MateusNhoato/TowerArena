
using Items;
using Entities;

namespace Classes
{
    internal class Ladrao : Classe
    {
        public Ladrao()
        {
            Nome = "Ladrão";
            Arma = new Adaga();
         
            VidaPorNivel = 2;
            ManaPorNivel = 1;
            PoderPorNivel = 3;
            DefesaPorNivel = 1;
            IniciativaPorNivel = 3;

        }
        // habilidades
        
        

        
    }
}
