using Entities;
using Repositories;
using System.Globalization;
using View;
using Classes;
using Rpg_De_Console.Entities;
using Inimigos;
using Services;

namespace Menu
{
    static class MenuPrincipal
    {


        public static void MostrarMenuPrincipal()
        {
            string resposta;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.tituloPrincipal);
                Console.WriteLine("     1 - Jogar");
                Console.WriteLine("     2 - Listar Personagens");
                Console.WriteLine("     3 - Criar Personagem");
                Console.WriteLine("     0 - Sair do Jogo");

                Console.Write("\n     Digite a opção desejada: ");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "0":
                        break;

                    case "1":
                        MenuEscolhaDePersonagem();
                        break;

                    case "2":
                        ListarPersonagens();
                        AperteEnterParaContinuar();
                        break;

                    case "3":
                        MenuDeCriacaoDePersonagem();
                        break;

                    default:
                        EntradaInvalida();
                        break;
                }


            } while (resposta != "0");
        }


        private static void MenuDeCriacaoDePersonagem()
        {
            Console.Clear();
            Console.WriteLine(Texto.novoPersonagem);
            Console.Write("\n    Nome do Personagem: ");
            string nome = Console.ReadLine();
            Console.WriteLine(Texto.linha + "\n");

            Console.WriteLine("     1 - Espadachim");
            Console.WriteLine("     2 - Ladrão");
            Console.WriteLine("     3 - Conjurador");
            Console.WriteLine("     4 - Arqueiro");
            Console.Write("\n     Escolha a opção desejada: ");
            string escolhaClasse = Console.ReadLine();

            Console.WriteLine(Texto.linha);

            Classe classe;
            if (escolhaClasse == "1")
                classe = new Espadachim();

            else if (escolhaClasse == "2")
                classe = new Ladrao();

            else if (escolhaClasse == "3")
                classe = new Conjurador();

            else if (escolhaClasse == "4")
                classe = new Arqueiro();
           
            else
                classe = null;

            if (classe == null)
                EntradaInvalida();
            else
            {
                if (nome.Length >= 2)
                {
                    TextInfo textInfo = new CultureInfo("pt-br", false).TextInfo;
                    nome = textInfo.ToTitleCase(nome);
                    if (!DadosDosJogadores.CheckarNomeRepetido(nome))
                    {
                        Jogador jogador = new Jogador(nome, classe);

                        DadosDosJogadores.SalvarInfoJogador(jogador);
                        Console.WriteLine($"\n     {jogador.Nome} ({jogador.Classe.Nome}) criado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("     Nome já utilizado.");
                    }

                }
                else
                {
                    Console.WriteLine("\n     Um nome precisa ter pelo menos 2 caracteres.");
                }

            }

            
            
            AperteEnterParaContinuar();
        }


        private static void ListarPersonagens()
        {
            Console.Clear();
            Console.WriteLine(Texto.personagens);
            DadosDosJogadores.ListarPersonagens();
            Console.WriteLine(Texto.linha);
        }

        private static void MenuEscolhaDePersonagem()
        {
            ListarPersonagens();
            Console.Write("\n    Qual personagem gostaria de escolher? ");
            var input = Console.ReadLine();
            Console.WriteLine(Texto.linha);

            int num;
            if(int.TryParse(input, out num))
            {
                Jogador jogador = DadosDosJogadores.AcharJogador(num);
                Inimigo inimigo = new Inimigo(jogador.Nivel);

                Combate.Combater(jogador, inimigo);
            }
            else
                EntradaInvalida();            
            AperteEnterParaContinuar();            
        }



        public static void AperteEnterParaContinuar()
        {
            Console.WriteLine("\n     Aperte enter para continuar");
            Console.ReadLine();
        }

        public static void EntradaInvalida()
        {
            Console.WriteLine("\n    Entrada Inválida.");
            System.Threading.Thread.Sleep(1200);
        }
    }
}
