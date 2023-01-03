using Classes;
using Entities;
using Inimigos;
using Menu;
using View;

namespace Services
{
    internal class JogoPrincipal
    {
        public static int Round { get; private set; } = 1;
        public static Classe[]? ClassesBasicas { get; private set; }
        public static Classe[]? Subclasses { get; private set; }



        public static bool Jogar(Jogador jogador)
        {
            foreach (Habilidade hab in jogador.Classe.Habilidades)
                hab.ResetarUsos();

            Round = 1;
            for (; Round <= 10; Round++)
            {
                Inimigo inimigo = new Inimigo(jogador.Nivel, false, jogador.Andar);

                CombateView.ImprimirNumeroDoRound(Round);
                if (!Combate.Combater(jogador, inimigo))
                {
                    // se o jogador perder um combate
                    return false;
                }
                if (Round == 5)
                {
                    jogador.LevelUp();
                    PausaDoAndar(jogador, Round);
                }

                if (jogador.Classe.PropriedadeEspecial == true)
                {
                    jogador.Classe.AlterarPropriedadeEspecial();
                }
                jogador.ZerarAtributosExtras();
                jogador.RegeneracaoPosCombate();

                if (Round == 10)
                {
                    PausaDoAndar(jogador, Round);
                    CombateView.BossRound(jogador.Andar);
                    inimigo = new Inimigo(jogador.Nivel, true, jogador.Andar);

                    if (!Combate.Combater(jogador, inimigo))
                    {
                        // se o jogador perder um combate
                        return false;
                    }
                }


            }

            return true;
        }

        private static void PausaDoAndar(Jogador jogador, int round)
        {
            string resposta;
            string continuar = "Round 6";
            if (round == 10)
                continuar = "Boss";
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.meioDoAndar);
                Console.WriteLine("     1- Loja");
                Console.WriteLine("     2- Usar consumíveis");
                Console.WriteLine($"     3- Continuar para o {continuar}");
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        MenuDoAndar.MenuLoja(jogador);
                        break;
                    case "2":
                        MenuDoAndar.MenuConsumiveis(jogador);
                        break;

                    case "3":
                        break;

                    default:
                        MenuPrincipal.EntradaInvalida();
                        break;
                }
            } while (resposta != "3");
        }
        public static void ListarClasses()
        {
            ClassesBasicas = new Classe[4] { new Arqueiro(), new Conjurador(), new Guerreiro(), new Ladrao() };
            Subclasses = new Classe[8] {new Atirador(), new Cavaleiro(),  new Feiticeiro(), new Espadachim(),
                                                 new Ladino(),   new Mago(),       new Mercenario(), new Ranger()};
        }
        
    }
}
