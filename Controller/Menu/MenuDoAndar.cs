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
                            resposta = "3";
                        DadosDosJogadores.SalvarInfoJogador(jogador);
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while(resposta != "3");
              
        }
    }
}
