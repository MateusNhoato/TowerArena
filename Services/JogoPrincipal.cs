using Entities;
using Inimigos;
using View;

namespace Services
{
    internal class JogoPrincipal
    {
        public static int Round { get; private set; } = 1;
        public static bool Jogar(Jogador jogador)
        {
            foreach (Habilidade hab in jogador.Classe.Habilidades)
                hab.ResetarUsos();

            for (; Round <= 10; Round++) 
            {
                
                CombateView.ImprimirNumeroDoRound(Round);
                if (!Combate.Combater(jogador, new Inimigo(jogador.Nivel))) 
                {
                    // se o jogador perder um combate
                    return false;
                }
                if ( Round == 5)
                    jogador.LevelUp();
                jogador.ZerarAtributosExtras();

            }
            Round = 1;
            return true;
        }
    }
}
