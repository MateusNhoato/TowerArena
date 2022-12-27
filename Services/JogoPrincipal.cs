using Entities;
using Inimigos;
using View;

namespace Services
{
    internal class JogoPrincipal
    {
        private static bool _fuga = false; 

        public static bool Fuga
        {
            get { return _fuga; }
            set { _fuga = value; }
        }

        public static bool Jogar(Jogador jogador)
        {
            for(int i= 1; i <= 10; i++) 
            {
                Fuga = false;
                CombateView.ImprimirNumeroDoRound(i);
                if (!Combate.Combater(jogador, new Inimigo(jogador.Nivel))) 
                {
                    // se o jogador perder um combate
                    return false;
                }
                if ( i == 5)
                    jogador.LevelUp();
                jogador.ZerarAtributosExtras();

                foreach(Habilidade hab in jogador.Classe.Habilidades)
                    hab.ResetarUsos();
            }
            return true;
        }
    }
}
