using Entities;
using Inimigos;
using View;
using Classes;
using Menu;

namespace Services
{
    internal class JogoPrincipal
    {
        public static int Round { get; private set; } = 1;
        private static string[] ChefesDeAndarQuotes;
        public static Classe[] ClassesBasicas { get; private set; }
        public static Classe[] Subclasses { get; private set; }



        public static bool Jogar(Jogador jogador)
        {
            foreach (Habilidade hab in jogador.Classe.Habilidades)
                hab.ResetarUsos();

            Round = 1;
            for (; Round <= 10; Round++) 
            {
                Inimigo inimigo = new Inimigo(jogador.Nivel, false, jogador.Andar);
                if (Round == 10)
                    inimigo = new Inimigo(jogador.Nivel, true, jogador.Andar);


                CombateView.ImprimirNumeroDoRound(Round);
                if (!Combate.Combater(jogador, inimigo))    
                {
                    // se o jogador perder um combate
                    return false;
                }
                if (Round == 5)
                {
                    jogador.LevelUp();
                    PausaNoMeioDoAndar(jogador);
                }

                if(jogador.Classe.PropriedadeEspecial == true)
                {
                    jogador.Classe.AlterarPropriedadeEspecial();
                }
                jogador.ZerarAtributosExtras();

            }
       
            return true;
        }

        private static void PausaNoMeioDoAndar(Jogador jogador)
        {
            string resposta;
            do
            {
                Console.Clear();
                Console.WriteLine(Texto.meioDoAndar);
                Console.WriteLine("     1- Loja");
                Console.WriteLine("     2- Usar consumíveis");
                Console.WriteLine("     3- Continuar para o Round 6");
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();

                switch(resposta)
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
            MenuDoAndar.MenuConsumiveis(jogador);
            
        }
        public static void ListarClasses()
        {
            ClassesBasicas = new Classe[4] {new Arqueiro(), new Conjurador(), new Guerreiro(), new Ladrao()};
            Subclasses = new Classe[8] {new Atirador(), new Cavaleiro(),  new Feiticeiro(), new Espadachim(),
                                                 new Ladino(),   new Mago(),       new Mercenario(), new Ranger()};
        }
        public static void ListarChefesDeAndar()
        {
           // ChefesDeAndarQuotes = new string[10] { };

          //  Inimigo inimigo = new Inimigo();
        }
    }
}
