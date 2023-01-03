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
            // resetando os usos das habilidades
            foreach (Habilidade hab in jogador.Classe.Habilidades)
                hab.ResetarUsos();

            Round = 1;
            // loop principal do jogo
            for (; Round <= 10; Round++)
            {
                // gerando um inimigo aleatório, que não é boss
                Inimigo inimigo = new Inimigo(jogador.Nivel, false, jogador.Andar);

                CombateView.ImprimirNumeroDoRound(Round);
                if (!Combate.Combater(jogador, inimigo))
                {
                    // se o jogador perder um combate
                    return false;
                }
                // loot do combate
                CombateView.ImprimirRecompensasDoCombate(inimigo);
                RecompensasDoCombate(jogador, inimigo);
                
                // pausa depois do quinto round
                if (Round == 5)
                {
                    jogador.LevelUp();
                    PausaDoAndar(jogador, Round);
                }
                // resets pós combate
                if (jogador.Classe.PropriedadeEspecial == true)
                {
                    jogador.Classe.AlterarPropriedadeEspecial();
                }              
                jogador.ZerarAtributosExtras();
                jogador.RegeneracaoPosCombate();

                // round do boss
                if (Round == 10)
                {
                    PausaDoAndar(jogador, Round);
                    CombateView.BossRound(jogador.Andar);
                    inimigo = new Inimigo(jogador.Nivel, true, jogador.Andar);

                    if (!Combate.Combater(jogador, inimigo))
                    {
                        // se o jogador perder para o boss
                        return false;
                    }
                    // loot boss
                    CombateView.ImprimirRecompensasDoCombate(inimigo);
                    RecompensasDoCombate(jogador, inimigo);
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

        private static void RecompensasDoCombate(Jogador jogador, Inimigo inimigo)
        {
            jogador.Mochila.AlterarDinheiro(inimigo.Mochila.Dinheiro);

            for(int i=1; i <inimigo.Mochila.Items.Count; i++)
            {
                jogador.Mochila.Items.Add(inimigo.Mochila.Items[i]);
            }
        }

        public static void ListarClasses()
        {
            ClassesBasicas = new Classe[4] { new Arqueiro(), new Conjurador(), new Guerreiro(), new Ladrao() };
            Subclasses = new Classe[8] {new Atirador(), new Cavaleiro(),  new Feiticeiro(), new Espadachim(),
                                                 new Ladino(),   new Mago(),       new Mercenario(), new Ranger()};
        }
        
    }
}
