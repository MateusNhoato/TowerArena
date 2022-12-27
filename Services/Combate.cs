using Entities;
using Inimigos;
using View;
using Menu;
using Enums;

namespace Services
{
    internal class Combate
    {


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
                    string habilidade = CombateView.MostrarHabilidadesDaClasse(jogador, inimigo);
                    if (!(HabilidadesDoJogador(jogador, inimigo, habilidade)))
                    {
                        CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                        AcaoDoJogador(jogador, inimigo);
                    }
                    break;

                // consumiveis            
                case "3":
                    break;
                // janela de status
                case "4":
                    CombateView.JanelaDeStatus(jogador);
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    AcaoDoJogador(jogador, inimigo);
                    break;

                // fulga
                case "5":
                    break;
            }
        }

        public static bool HabilidadesDoJogador(Jogador jogador, Inimigo inimigo, string habilidade)
        {
            string sair = (jogador.Classe.Habilidades.Count + 1).ToString();

            if (habilidade == sair)
                return false;
            else
            {
                if (jogador.CheckarMana(jogador.Classe.Habilidades[int.Parse(habilidade) - 1].CustoDeMana))
                {
                    if (jogador.Classe.Habilidades[int.Parse(habilidade) - 1].Tipo == TipoDeHabilidade.Ataque)
                        jogador.Classe.Habilidades[int.Parse(habilidade) - 1].Efeito(jogador, inimigo);
                    else
                        jogador.Classe.Habilidades[int.Parse(habilidade) - 1].Efeito(jogador, jogador);
                    return true;
                }
                Console.WriteLine("    Sem mana para castar a habilidade.");
                Thread.Sleep(1000);
                return false;
            }                
        }
    
    public static void AcaoDoInimigo(Inimigo inimigo, Jogador jogador)
    {
        Console.WriteLine("     Inimigo faz algo ~");
        MenuPrincipal.AperteEnterParaContinuar();
    }
}
}
