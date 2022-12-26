
using Items;
using Rpg_De_Console.Entities;

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
