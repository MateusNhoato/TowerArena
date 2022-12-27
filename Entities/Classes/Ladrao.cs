
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
         
            VidaPorNivel = 4;
            ManaPorNivel = 4;
            PoderPorNivel = 5;
            DefesaPorNivel = 4;
            IniciativaPorNivel = 8;

        }

        private protected override void AdicionarHabilidades()
        {
            throw new NotImplementedException();
        }
        // habilidades




    }
}
