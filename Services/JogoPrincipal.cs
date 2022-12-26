using Entities;
using Inimigos;
using View;

namespace Services
{
    internal class JogoPrincipal
    {

        public static bool Jogar(Jogador jogador)
        {
            for(int i= 1; i <= 10; i++) 
            {
                CombateView.ImprimirNumeroDoRound(i);
                if (!Combate.Combater(jogador, new Inimigo(jogador.Nivel))) 
                {
                    // se o jogador perder um combate
                    return false;
                }
                if ( i == 5)
                    jogador.LevelUp();           
            }
            return true;
        }
    }
}
