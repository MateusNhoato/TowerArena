using Classes;
using Delegates;
using Entities;
using Enums;
using Inimigos;
using Items;
using Menu;
using View;

namespace Services
{
    internal class Combate
    {
        public static bool _combate { get; set; } = true;

        public static bool Iniciativa(CriaturaBase jogador, CriaturaBase inimigo)
        {
            Random random = new Random();
            int iniAdicionalJg = random.Next(0, 6);
            int iniAdicionalIn = random.Next(0, 6);
            CombateView.ImprimirIniciativa(iniAdicionalJg, iniAdicionalIn);

            int iniciativaJogador = jogador.AgilidadeTotal + iniAdicionalJg + 1;
            int iniciativaInimigo = inimigo.AgilidadeTotal + iniAdicionalIn + 1;

            if (iniciativaJogador >= iniciativaInimigo)
            {
                // buff inicial de Atirador
                if (jogador.Classe is Atirador)
                    jogador.AlterarAgilidade(jogador.AgilidadeTotal / 10);
                return true;
            }

            else
                return false;


        }
        public static bool Combater(Jogador jogador, Inimigo inimigo)
        {
            _combate = true;
            // buff inicial do Mercenário
            if (jogador.Classe is Mercenario)
                jogador.AlterarForca(jogador.Mochila.Dinheiro / 100);


            // buff inicial de Mago
            if (jogador.Classe is Mago)
                if (jogador.PoderTotal > inimigo.PoderTotal)
                    jogador.AlterarDefesa(5);

            // buff inicial do Cavaleiro
            if(jogador.Classe is Cavaleiro)
                jogador.AlterarDefesa(new Random().Next(1, 7));


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

        public static bool FimDoRound(CriaturaBase jogador, CriaturaBase inimigo)
        {
            if (jogador.VidaAtual <= 0 || inimigo.VidaAtual <= 0 || _combate == false)
                return true;
            return false;
        }
        public static void AcaoDoJogador(CriaturaBase jogador, CriaturaBase inimigo)
        {
            string acao = MenuDeCombate.MostrarMenuDeCombate();

            switch (acao)
            {
                // atacar
                case "1":
                    new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(jogador, inimigo);
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
                    string consumivel = CombateView.MostrarItensConsumiveis(jogador, inimigo, true);
                    if (!(ItensConsumiveisDoJogador(jogador, consumivel, true)))
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

        public static bool HabilidadesDoJogador(CriaturaBase jogador, CriaturaBase inimigo, string habilidade)
        {
            
            if (habilidade == "0")
                return false;
            else
            {
                Habilidade hab = jogador.Classe.Habilidades[int.Parse(habilidade) - 1];

                if (hab.QuantidadeDeUsos > 0)
                {
                    if (jogador.CheckarMana(hab.CustoDeMana))
                    {
                        hab.Efeito(jogador, inimigo);
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
        public static bool ItensConsumiveisDoJogador(CriaturaBase jogador, string consumivel, bool pocoesDeStatus)
        {
            if (consumivel == "0")
                return false;


            Console.WriteLine(Texto.linha);
            if (consumivel == "1")
            {
                if (jogador.VidaAtual >= jogador.VidaTotal)
                {
                    Console.WriteLine("\n     Sua vida está cheia, não ha porque usar uma poção.");
                    Thread.Sleep(1000);
                    return false;
                }

                if (jogador.Mochila.Items.Exists(x => x is PocaoVida))
                {
                    Item pocao = jogador.Mochila.Items.Find(x => x is PocaoVida);
                    jogador.BeberPocao(pocao);
                    jogador.Mochila.RemoverConsumivelDaMochila(pocao);
                    Thread.Sleep(1000);
                    return true;
                }
                Console.WriteLine("\n     Sem poção de vida disponível.");
                Thread.Sleep(1000);
                return false;
            }

            else if (consumivel == "2")
            {
                if (jogador.ManaAtual >= jogador.ManaTotal)
                {
                    Console.WriteLine("\n     Sua mana está cheia, não ha porque usar uma poção.");
                    Thread.Sleep(1000);
                    return false;
                }

                if (jogador.Mochila.Items.Exists(x => x is PocaoMana))
                {
                    Item pocao = jogador.Mochila.Items.Find(x => x is PocaoMana);
                    jogador.BeberPocao(pocao);
                    jogador.Mochila.RemoverConsumivelDaMochila(pocao);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    Console.WriteLine("\n     Sem poção de mana disponível.");
                    Thread.Sleep(1000);
                    return false;
                }
            }

            else
            {
                if (!pocoesDeStatus)
                    return false;

                Item escolha = new PocaoAgilidade();

                if (consumivel == "4")
                    escolha = new PocaoForca();
                else if (consumivel == "5")
                    escolha = new PocaoIntelecto();
                else if (consumivel == "6")
                    escolha = new PocaoDefesa();

                if (jogador.Mochila.Items.Exists(x => x.Equals(escolha)))
                {
                    Item pocao = jogador.Mochila.Items.Find(x => x.Equals(escolha));
                    jogador.BeberPocao(pocao);
                    jogador.Mochila.RemoverConsumivelDaMochila(pocao);
                    Thread.Sleep(1000);
                    return true;
                }
                else
                {
                    Console.WriteLine($"\n     Sem {escolha.Nome} disponível.");
                    Thread.Sleep(1000);
                    return false;
                }
            }
        }
        public static void AcaoDoInimigo(CriaturaBase inimigo, CriaturaBase jogador)
        {
            Random random = new Random();
            int n;
            if (inimigo.PorcentagemVida() > 30)
            {
                n = random.Next(1, 101);

                if (n > 25)
                    new Habilidade("Ataque", 0, 1, $"{jogador.Classe.Nome} ataca o inimigo.", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);

                // habilidade
                else
                {
                    List<Habilidade> habilidades = inimigo.Classe.Habilidades;
                    int skillsDisponiveis = habilidades.Count() - 1;
                    int skillASerUsada = random.Next(0, skillsDisponiveis);

                    if (habilidades[skillASerUsada].QuantidadeDeUsos > 0)
                        if (inimigo.CheckarMana(habilidades[skillASerUsada].CustoDeMana))
                            habilidades[skillASerUsada].Efeito(inimigo, jogador);
                        else
                        {
                            // beber poção de mana
                            if (inimigo.Mochila.Items.Exists(x => x is PocaoMana))
                            {
                                Item pocao = inimigo.Mochila.Items.Find(x => x.Nome == "Poção de Mana");
                                inimigo.BeberPocao(pocao);
                                inimigo.Mochila.RemoverConsumivelDaMochila(pocao);
                            }
                            else
                                new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);
                        }
                    else
                        new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);

                }
            }
            else
            {
                n = random.Next(1, 101);

                if (n < 21)
                {
                    // beber poção de vida
                    if (inimigo.Mochila.Items.Exists(x => x is PocaoVida))
                    {
                        Item pocao = inimigo.Mochila.Items.Find(x => x.Nome == "Poção de Vida");
                        inimigo.BeberPocao(pocao);
                        inimigo.Mochila.RemoverConsumivelDaMochila(pocao);
                    }
                    else
                        new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);

                }
                else if (n < 51)
                    new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);

                // habilidade
                else
                {
                    List<Habilidade> habilidades = inimigo.Classe.Habilidades;
                    int skillsDisponiveis = habilidades.Count() - 1;
                    int skillASerUsada = random.Next(0, skillsDisponiveis);

                    if (habilidades[skillASerUsada].QuantidadeDeUsos > 0)
                        if (inimigo.CheckarMana(habilidades[skillASerUsada].CustoDeMana))
                            habilidades[skillASerUsada].Efeito(inimigo, jogador);
                        else
                        {
                            // beber poção de mana
                            if (inimigo.Mochila.Items.Exists(x => x is PocaoMana))
                            {
                                Item pocao = inimigo.Mochila.Items.Find(x => x.Nome == "Poção de Mana");
                                inimigo.BeberPocao(pocao);
                                inimigo.Mochila.RemoverConsumivelDaMochila(pocao);
                            }
                            else
                                new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);
                        }
                    else
                        new Habilidade("Ataque", 0, 1, "", EfeitosDeHabilidades.Ataque1x).Efeito(inimigo, jogador);

                }

            }
            CombateView.ImprimirTelaDeCombate(jogador, inimigo);
            MenuPrincipal.AperteEnterParaContinuar();
        }
    }
}
