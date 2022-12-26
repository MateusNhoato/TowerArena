using Entities;
using Inimigos;
using View;
using Menu;
namespace Services
{
    internal class Combate
    {
        private int _turno = 0;


        private static bool Iniciativa(Jogador jogador, Inimigo inimigo)
        {
            Random random = new Random();
            int iniAdicionalJg = random.Next(0, 5);
            int iniAdicionalIn = random.Next(0, 5);
            CombateView.ImprimirIniciativa(iniAdicionalJg, iniAdicionalIn);

            int iniciativaJogador = jogador.IniciativaTotal + iniAdicionalJg;
            int iniciativaInimigo = inimigo.IniciativaTotal + iniAdicionalIn;

            if (iniciativaJogador >= iniciativaInimigo)
                return true;
            else
                return false;
        }
        public static bool Combater(Jogador jogador, Inimigo inimigo)
        {
            bool resultadoIniciativa = Iniciativa(jogador, inimigo);

            if (resultadoIniciativa)
                CombateView.JogadorComeca();
            else
                CombateView.InimigoComeca();

            while (true)
            {
                CombateView.ImprimirTelaDeCombate(jogador, inimigo);

                if (jogador.VidaAtual <= 0 || inimigo.VidaAtual <= 0)
                    break;


                if (!resultadoIniciativa)
                {
                    AcaoDoInimigo(inimigo, jogador);
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    AcaoDoJogador(jogador, inimigo);
                }
                else
                {
                    AcaoDoJogador(jogador, inimigo);
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    AcaoDoInimigo(inimigo, jogador);
                }
            }
            if (jogador.VidaAtual <= 0)
                return false;
            else
                return true;
        }

        public static void AcaoDoJogador(Jogador jogador, Inimigo inimigo)
        {
            string acao = MenuDeCombate.MostrarMenuDeCombate();

            switch (acao)
            {
                // atacar
                case "1":
                    inimigo.ReceberDano(50);
                    break;
                // habilidade especial
                case "2":
                    jogador.ReceberDano(10);
                    break;

                // consumiveis            
                case "3":
                    break;
                // fuga
                case "4":
                    break;
            }
        }

        public static void AcaoDoInimigo(Inimigo inimigo, Jogador jogador)
        {
            Console.WriteLine("     Inimigo faz algo ~");
            MenuPrincipal.AperteEnterParaContinuar();
        }
    }
}
