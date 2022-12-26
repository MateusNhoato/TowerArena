using Items;
using Entities;

namespace Classes
{
    internal class Arqueiro : Classe
    {
        public Arqueiro()
        {
            Nome = "Arqueiro";
            Arma = new ArcoEFlecha();

            VidaPorNivel = 2;
            ManaPorNivel = 2;
            PoderPorNivel = 3;
            DefesaPorNivel = 1;
            IniciativaPorNivel = 1;

        }

        // habilidades

    }
}
