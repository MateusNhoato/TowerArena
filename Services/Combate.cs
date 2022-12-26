using Entities;
using Inimigos;
using View;
using Menu;
namespace Services
{
    internal static class Combate
    {

        public static void Combater(Jogador jogador, Inimigo inimigo)
        {
            
            CombateView.ImprimirNumeroDoRound(jogador);
            
            CombateView.ImprimirTelaDeCombate(jogador, inimigo);
            string acao = MenuDeCombate.MostrarMenuDeCombate();

            switch(acao)
            {
                // atacar
                case "1":
                    
                    break;
                // habilidade especial
                case "2":
                    break;

                // consumiveis            
                case "3":
                    break;
                // fuga
                case "4":
                    break;
            }
        }
    }
}
