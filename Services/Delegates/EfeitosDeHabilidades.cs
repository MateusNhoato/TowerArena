
using Entities;

namespace Delegates
{
    internal class EfeitosDeHabilidades
    {
        public static void HabilidadeAtaque2x(CriaturaBase conjurador, CriaturaBase receptor)
        {
          
            int dano = conjurador.PoderTotal * 2 + conjurador.Classe.Arma.Dano;

            receptor.ReceberDano(dano);
        }

        public static void BuffPoder(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            receptor.AumentarPoder(5);
        }
        
    }
}
