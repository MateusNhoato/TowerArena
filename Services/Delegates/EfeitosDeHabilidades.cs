
using Entities;

namespace Delegates
{
    internal class EfeitosDeHabilidades
    {
        public static void HabilidadeAtaque1x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano;

            receptor.ReceberDano(dano);
        }
        public static void HabilidadeAtaque2x(CriaturaBase conjurador, CriaturaBase receptor)
        {
          
            int dano = (conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano) * 2;

            receptor.ReceberDano(dano);
        }

        public static void BuffPoder(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.PoderTotal /5;

            receptor.AlterarPoder(buff);
        }

        public static void BuffDefesa(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.DefesaTotal / 5;

            receptor.AlterarDefesa(buff);
        }

        public static void BuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.IniciativaTotal / 5;

            receptor.AlterarIniciativa(buff);
        }

        public static void BuffVida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.VidaTotal / 5;

            receptor.AlterarVida(buff);
        }

        public static void DebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.DefesaTotal / 6) * -1;

            receptor.AlterarDefesa(debuff);
        }

        public static void DebuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.IniciativaTotal / 6) * -1;

            receptor.AlterarIniciativa(debuff);
        }

        public static void DebuffPoder(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.PoderTotal / 6) * -1;

            receptor.AlterarPoder(debuff);
        }
    }
}
