using Classes;
using Entities;
using Repositories;
using System.Globalization;
using View;


namespace Menu
{
    static class MenuPrincipal
    {

        private static List<Classe> _classesBasicas { get; } = new List<Classe>()
             { new Arqueiro(), new Guerreiro(), new Ladrao(), new Conjurador()};
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

            for (int i = 0; i < _classesBasicas.Count; i++)
            {
                Console.WriteLine($"     {i + 1}- {_classesBasicas[i]}");
            }
            Console.Write("\n     Escolha a opção desejada: ");

            int escolhaClasse;

            if (int.TryParse(Console.ReadLine(), out escolhaClasse))
            {
                Classe classe;
                try
                {
                    classe = _classesBasicas[escolhaClasse - 1];
                }
                catch (ArgumentOutOfRangeException)
                {
                    EntradaInvalida();
                    return;
                }
                if (nome.Length >= 2)
                {
                    nome = NomePascalCase(nome);
                    if (!DadosDosJogadores.CheckarNomeRepetido(nome))
                    {
                        Jogador jogador = new Jogador(nome, classe);

                        DadosDosJogadores.SalvarInfoJogador(jogador);
                        Console.WriteLine($"\n     {jogador.Nome} ({jogador.Classe.Nome}) criado com sucesso!");
                    }
                    else
                        Console.WriteLine("     Nome já utilizado.");

                }
                else
                    Console.WriteLine("\n     Um nome precisa ter pelo menos 2 caracteres.");
            }
            else
                EntradaInvalida();
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
            Console.Write("\n    Digite o nome do personagem gostaria de escolher: ");
            string nome = Console.ReadLine();
            if (!string.IsNullOrEmpty(nome))
            {
                nome = NomePascalCase(nome);
            }

            Console.WriteLine(Texto.linha);

            Jogador jogador = DadosDosJogadores.AcharJogador(nome);
            if (jogador != null)
                MenuDoAndar.MostrarMenuDoAndar(jogador);
            else
                EntradaInvalida();
            AperteEnterParaContinuar();
        }

        private static string NomePascalCase(string nome)
        {
            TextInfo textInfo = new CultureInfo("pt-br", false).TextInfo;
            nome = textInfo.ToTitleCase(nome);
            return nome;
        }

        public static void AperteEnterParaContinuar()
        {
            Console.Write("\n     Aperte enter para continuar");
            Console.ReadLine();
        }

        public static void EntradaInvalida()
        {
            Console.Write("\n    Entrada Inválida.");
            System.Threading.Thread.Sleep(1200);
        }
    }
}
