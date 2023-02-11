using Classes;
using Entities;
using Items;
using Repositories;
using Services;
using View;

namespace Menu
{
    internal class MenuDoAndar
    {

        public static void MostrarMenuDoAndar(Jogador jogador)
        {
            string resposta;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.tower);
                Console.WriteLine($"\n     {jogador} | Vida [{jogador.VidaAtual} / {jogador.VidaTotal}] | Mana [{jogador.ManaAtual} / {jogador.ManaTotal}]\n");
                Console.WriteLine($"     1- Entrar no Próximo Andar - {(jogador.Andar)}");
                Console.WriteLine("     2- Usar Consumíveis");
                Console.WriteLine("     3- Loja");
                Console.WriteLine("     0- Voltar");
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Texto.ImprimirAndarAtual(jogador.Andar);
                        if (JogoPrincipal.Jogar(jogador))
                        {
                            jogador.SubirAndar();
                            if (jogador.Andar > 10)
                            {
                                Texto.FinalDoJogo(jogador.Nome);
                                resposta = "0";
                            }
                        }
                        else
                            resposta = "0";                                                         
                        break;

                    case "2":
                        MenuConsumiveis(jogador);
                        break;

                    case "3":
                        MenuLoja(jogador);
                        break;

                    case "0":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while (resposta != "0");
            DadosDosJogadores.SalvarInfoJogador(jogador);
        }

        public static void MenuConsumiveis(Jogador jogador)
        {
            string input;
            do
            {
                Console.Clear();
                CombateView.JanelaDeStatus(jogador);
                Console.WriteLine("\n     Mochila:");
                jogador.Mochila.ListarConsumiveisNaMochila();
                Console.Write("\n     Obs: ao utilizar uma poção de atributo, o personagem só terá seu efeito pelo próximo Round.");
                Console.Write("\n     Digite a opção desejada: ");
                
                input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input))
                    Combate.ItensConsumiveisDoJogador(jogador, input);
            } while (input != "0");

        }

        public static void MenuLoja(Jogador jogador)
        {
            ConsoleColor aux = Console.ForegroundColor;

            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.loja);
                Console.Write($"\n     {jogador} | Vida [");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{jogador.VidaAtual} ");

                Console.ForegroundColor = aux;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{jogador.VidaTotal}");

                Console.ForegroundColor = aux;
                Console.Write("] | Mana [");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{jogador.ManaAtual}");

                Console.ForegroundColor = aux;
                Console.Write("/");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{jogador.ManaTotal}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]\n");
                Console.WriteLine($"     Itens na mochila de {jogador.Nome}:");
                Console.WriteLine(jogador.Mochila); ;

                Console.WriteLine(Texto.linha);
                Console.WriteLine("     Comprar:");
                Console.Write("     1- Poção de Vida [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("25G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     2- Poção de Mana [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("40G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     3- Poção de Agi [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("100G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     4- Poção de For [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("100G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     5- Poção de Int [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("100G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     6- Poção de Def [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("100G");

                Console.ForegroundColor = aux;
                if (jogador.Classe is Mercenario)
                    Console.WriteLine("]\n     7- Vender");

                Console.WriteLine("]\n     0- Voltar");


                Console.Write("     Digite a opção desejada: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ComprarPocao(jogador, "1");
                        break;

                    case "2":
                        ComprarPocao(jogador, "2");
                        break;
                    case "3":
                        ComprarPocao(jogador, "3");
                        break;

                    case "4":
                        ComprarPocao(jogador, "4");
                        break;
                    case "5":
                        ComprarPocao(jogador, "5");
                        break;
                    case "6":
                        ComprarPocao(jogador, "6");
                        break;
                    case "7":
                        if (jogador.Classe is Mercenario)
                            Vender(jogador);
                        break;
                    case "0":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;

                }
            } while (input != "0");
        }

        public static void ComprarPocao(Jogador jogador, string tipo)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Item pocao;
            int dinheiroPorPocao;

            if(tipo == "1")
            {
                pocao = new PocaoVida();
                dinheiroPorPocao = 25;
            }
            else if (tipo == "2")
            {
                dinheiroPorPocao = 40;
                pocao = new PocaoMana();
            }
            else
            {
                dinheiroPorPocao = 100;
                if (tipo == "3")
                    pocao = new PocaoAgilidade();
                else if (tipo == "4")
                    pocao = new PocaoForca();
                else if (tipo == "5")
                    pocao = new PocaoIntelecto();
                else
                    pocao = new PocaoDefesa();
            }

            int num;
            do
            {
                Console.WriteLine(Texto.linha);
                Console.Write($"\n     Digite a quantidade de {pocao.Nome} que gostaria: ");
            } while (!(int.TryParse(Console.ReadLine(), out num)));

            if (num < 0)
            {
                MenuPrincipal.EntradaInvalida();
                return;
            }

            int totalDinheiro = num * dinheiroPorPocao;

            if (jogador.Mochila.ChecarDinheiro(totalDinheiro))
            {
                jogador.Mochila.AlterarDinheiro(totalDinheiro * -1);

                for (int i = 0; i < num; i++)
                {
                    jogador.Mochila.Items.Add(pocao);
                }


                Console.Write("     Total: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{totalDinheiro}");
                Console.ForegroundColor = aux;
                Console.WriteLine("G");
            }
            else
                Console.WriteLine("     Gold insuficiente.");

            MenuPrincipal.AperteEnterParaContinuar();
            Console.Clear();

        }
        public static void Vender(Jogador jogador)
        {
            ConsoleColor aux = Console.ForegroundColor;


            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.loja);
                Console.Write($"\n     {jogador} | Vida [");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{jogador.VidaAtual} ");

                Console.ForegroundColor = aux;
                Console.Write("/");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{jogador.VidaTotal}");

                Console.ForegroundColor = aux;
                Console.Write("] | Mana [");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{jogador.ManaAtual}");

                Console.ForegroundColor = aux;
                Console.Write("/");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{jogador.ManaTotal}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]\n");
                Console.WriteLine($"     Itens na mochila de {jogador.Nome}:");
                Console.WriteLine(jogador.Mochila); ;

                Console.WriteLine(Texto.linha);
                Console.WriteLine("     Vender:");
                Console.Write("     1- Poção de Vida [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("12G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     2- Poção de Mana [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("20G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     3- Poção de Agi  [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("50G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     4- Poção de For  [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("50G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     5- Poção de Int  [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("50G");

                Console.ForegroundColor = aux;
                Console.Write("]\n     6- Poção de Def  [");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("50G");
                Console.ForegroundColor = aux;
                Console.WriteLine("]\n     0- Voltar");


                Console.Write("     Qual poção gostaria de vender? ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        VenderPocao(jogador, "1");
                        break;

                    case "2":
                        VenderPocao(jogador, "2");
                        break;
                    case "3":
                        VenderPocao(jogador, "3");
                        break;
                    case "4":
                        VenderPocao(jogador, "4");
                        break;
                    case "5":
                        VenderPocao(jogador, "5");
                        break;
                    case "6":
                        VenderPocao(jogador, "6");
                        break;
                    case "0":
                        break;
                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while (input != "0");


        }

        public static void VenderPocao(Jogador jogador, string tipo)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Item pocao = new PocaoVida();
            int dinheiroPorPocao = 12;
            if (tipo == "2")
            {
                dinheiroPorPocao = 20;
                pocao = new PocaoMana();
            }
            else
            {
                dinheiroPorPocao = 50;
                if (tipo == "3")
                    pocao = new PocaoAgilidade();
                else if (tipo == "4")
                    pocao = new PocaoForca();
                else if (tipo == "5")
                    pocao = new PocaoIntelecto();
                else
                    pocao = new PocaoDefesa();
            }

            int num;
            do
            {
                Console.WriteLine(Texto.linha);
                Console.Write($"\n     Digite a quantidade de {pocao.Nome} que gostaria de Vender: ");
            } while (!(int.TryParse(Console.ReadLine(), out num)));

            if (num <= 0)
            {
                MenuPrincipal.EntradaInvalida();
                return;
            }

            int totalDinheiro = num * dinheiroPorPocao;

            if (jogador.Mochila.Items.Count(x => x.Equals(pocao)) >= num)
            {
                jogador.Mochila.AlterarDinheiro(totalDinheiro);

                for (int i = 0; i < num; i++)
                {
                    jogador.Mochila.Items.Remove(pocao);
                }

                Console.Write("     Total: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{totalDinheiro}");
                Console.ForegroundColor = aux;
                Console.WriteLine("G");
            }
            else
                Console.WriteLine("     Poções insuficiente.");

            MenuPrincipal.AperteEnterParaContinuar();
            Console.Clear();
        }

    }
}





