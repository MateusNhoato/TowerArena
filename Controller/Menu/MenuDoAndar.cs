using Entities;
using Services;
using Inimigos;
using View;
using Repositories;
using Classes;
using Items;

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
                Console.WriteLine("     4- Voltar");
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Texto.ImprimirAndarAtual(jogador.Andar);
                        if (JogoPrincipal.Jogar(jogador))
                            jogador.SubirAndar();
                        else
                        {
                            DadosDosJogadores.SalvarInfoJogador(jogador);
                            resposta = "4";
                        }
                        break;

                    case "2":
                        MenuConsumiveis(jogador);
                        break;

                    case "3":
                        MenuLoja(jogador);
                        break;

                    case "4":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while (resposta != "4");

        }

        public static void MenuConsumiveis(Jogador jogador)
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.consumiveis);
                Console.WriteLine($"\n     {jogador} | Vida [{jogador.VidaAtual} / {jogador.VidaTotal}] | Mana [{jogador.ManaAtual} / {jogador.ManaTotal}]\n");
                jogador.Mochila.ListarConsumiveisNaMochila(false);
                Console.Write("     Digite a opção desejada: ");
                input = Console.ReadLine();
                Combate.ItensConsumiveisDoJogador(jogador, input);
            } while (input != "3");

        }

        public static void MenuLoja(Jogador jogador)
        {
            ConsoleColor aux = Console.ForegroundColor;
            string inputAux;

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
                if (jogador.Classe is Mercenario)
                {
                    Console.WriteLine("]\n     3- Vender");
                    Console.WriteLine("     4- Voltar");
                    inputAux = "4";
                }
                else
                {
                    Console.WriteLine("]\n     3- Voltar");
                    inputAux = "3";
                }

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
                        if (jogador.Classe is Mercenario)
                            vender(jogador);
                        break;

                    case "4":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;

                }
            } while (input != inputAux);
        }

        public static void ComprarPocao(Jogador jogador, string tipo)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Item pocao = new PocaoVida();
            if (tipo == "2")
                pocao = new PocaoMana();
            int num;
            do
            {
                Console.WriteLine(Texto.linha);
                Console.Write($"\n     Digite a quantidade de {pocao.Nome} que gostaria: ");
            } while (!(int.TryParse(Console.ReadLine(), out num)));

            if(num < 0)
            {
                MenuPrincipal.EntradaInvalida();
                return;
            }

            int totalDinheiro = (pocao is PocaoVida) ? num * 25 : num * 40;

            if (jogador.Mochila.ChecarDinheiro(totalDinheiro))
            {
                jogador.Mochila.AlterarDinheiro(totalDinheiro * -1);

                for(int i=0; i < num; i++)
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
        public static void vender(Jogador jogador)
        {

        }
    }
}
