using Entities;
using Inimigos;
using View;
using Menu;
using Enums;
using Delegates;
using Items;
using System.Linq;
using TowerArena.Entities;

namespace Services
{
    internal class Combate
    {
        public static bool _combate { get; set; } = true;

        public static bool Iniciativa(CriaturaBase jogador, CriaturaBase inimigo)
        {
            Random random = new Random();
            int iniAdicionalJg = random.Next(0, 5);
            int iniAdicionalIn = random.Next(0, 5);
            CombateView.ImprimirIniciativa(iniAdicionalJg, iniAdicionalIn);

            int iniciativaJogador = jogador.IniciativaTotal + iniAdicionalJg +1;
            int iniciativaInimigo = inimigo.IniciativaTotal + iniAdicionalIn +1;

            if (iniciativaJogador >= iniciativaInimigo)
                return true;
            else
                return false;
        }
        public static bool Combater(Jogador jogador, Inimigo inimigo)
        {
            _combate = true;

            bool resultadoIniciativa = Iniciativa(jogador, inimigo);

            if (resultadoIniciativa)
                CombateView.JogadorComeca();
            else
                CombateView.InimigoComeca();


            while (true)
            {
                CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                Thread.Sleep(500);
                if (FimDoRound(jogador, inimigo))
                    break;

                if (!resultadoIniciativa)
                {
                    AcaoDoInimigo(inimigo, jogador);                 
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    Thread.Sleep(500);
                    if (FimDoRound(jogador, inimigo))
                        break;
                    AcaoDoJogador(jogador, inimigo);
                }
                else
                {
                    AcaoDoJogador(jogador, inimigo);                   
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    Thread.Sleep(500);
                    if (FimDoRound(jogador, inimigo))
                        break;
                    AcaoDoInimigo(inimigo, jogador);
                }
            }
                        
            if (jogador.VidaAtual <= 0)
            {
                CombateView.VitoriaDoOponente();
                return false;
            }
            else
            {
                if (!_combate)
                    CombateView.JogadorFugiu();
                else
                    CombateView.VitoriaDoJogador();
                return true;
            }

                
        }

        public static bool FimDoRound(Jogador jogador, Inimigo inimigo)
        {
            if (jogador.VidaAtual <= 0 || inimigo.VidaAtual <= 0 || _combate == false)
                return true;
            return false;
        }
        public static void AcaoDoJogador(Jogador jogador, Inimigo inimigo)
        {
            string acao = MenuDeCombate.MostrarMenuDeCombate();

            switch (acao)
            {
                // atacar
                case "1":
                    new Habilidade("Ataque", 0, $"{jogador.Classe.Nome} ataca o inimigo.", EfeitosDeHabilidades.Ataque1x, TipoDeHabilidade.Ataque ).Efeito(jogador, inimigo);
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
                    string consumivel = CombateView.MostrarItensConsumiveis(jogador, inimigo);
                    if (!(ItensConsumiveisDoJogador(jogador, consumivel)))
                    {
                        CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                        AcaoDoJogador(jogador, inimigo);
                    }
                    break;
                // janela de status
                case "4":
                    CombateView.JanelaDeStatus(jogador);
                    CombateView.ImprimirTelaDeCombate(jogador, inimigo);
                    AcaoDoJogador(jogador, inimigo);
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
                Habilidade hab = jogador.Classe.Habilidades[int.Parse(habilidade) - 1];

                if(hab.QuantidadeDeUsos > 0)
                {
                    if (jogador.CheckarMana(hab.CustoDeMana))
                    {
                        if (hab.Tipo == TipoDeHabilidade.Ataque || hab.Tipo == TipoDeHabilidade.Debuff)
                            hab.Efeito(jogador, inimigo);
                        else
                            hab.Efeito(jogador, jogador);

                        hab.DiminuirUso();
                        return true;
                    }
                    Console.WriteLine("     Sem mana para castar a habilidade.");
                    Thread.Sleep(1000);
                    return false;
                }
                else
                {
                    Console.WriteLine("     Não há usos disponíveis para a habilidade.");
                    Thread.Sleep(1000);
                    return false;
                }

                
            }                
        }
    
        // opções de usar poção de vida e mana ou voltar
    public static bool ItensConsumiveisDoJogador(Jogador jogador, string consumivel)
        {
            if(consumivel == "3")
                return false;

            Console.WriteLine(Texto.linha);
            if(consumivel == "1")
            {
                if (jogador.Mochila.Items.Exists(x => x is PocaoVida))
                {
                    Item pocao = jogador.Mochila.Items.Find(x => x is PocaoVida);
                    jogador.BeberPocao(pocao);
                    jogador.Mochila.RemoverConsumivelDaMochila(pocao);
                    return true;
                }
                Console.WriteLine("\n     Sem poção de vida disponível.");
                Thread.Sleep(1000);
                return false;
            }

            if (jogador.Mochila.Items.Exists(x => x is PocaoMana))
            {
                Item pocao = jogador.Mochila.Items.Find(x => x is PocaoMana);
                jogador.BeberPocao(pocao);
                jogador.Mochila.RemoverConsumivelDaMochila(pocao);
                return true;
            }
            Console.WriteLine("\n     Sem poção de mana disponível.");
            Thread.Sleep(1000);
            return false;
        }
    public static void AcaoDoInimigo(Inimigo inimigo, Jogador jogador)
    {
        Console.WriteLine("     Inimigo faz algo ~");
        MenuPrincipal.AperteEnterParaContinuar();
    }
}
}
