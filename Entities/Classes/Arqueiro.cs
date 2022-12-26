using Items;
using Rpg_De_Console.Entities;

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
        protected override void Habilidade1(CriaturaBase alvo)
        {
            throw new NotImplementedException();
        }

        protected override void Habilidade2(CriaturaBase alvo)
        {
            throw new NotImplementedException();
        }


    }
}
