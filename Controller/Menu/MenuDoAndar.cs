using Entities;
using Services;
using Inimigos;
using View;
using Repositories;

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
                Console.WriteLine("     3- Voltar");
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
                            resposta = "3";
                        }                          
                        break;

                    case "2":
                        MenuConsumiveis(jogador);
                        break;

                    case "3":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while(resposta != "3");
              
        }

       public static void MenuConsumiveis(Jogador jogador)
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.consumiveis);
                Console.WriteLine($"\n     {jogador} | Vida [{jogador.VidaAtual} / {jogador.VidaTotal}] | Mana [{jogador.ManaAtual} / {jogador.ManaTotal}]\n");
                jogador.Mochila.ListarConsumiveisNaMochila();
                Console.Write("     Digite a opção desejada: ");
                input = Console.ReadLine();
                Combate.ItensConsumiveisDoJogador(jogador, input);
            } while (input != "3");
       
        }
    }
}
