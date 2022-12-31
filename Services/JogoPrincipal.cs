using Entities;
using Inimigos;
using View;
using Classes;

namespace Services
{
    internal class JogoPrincipal
    {
        public static int Round { get; private set; } = 1;
        private static List<Inimigo> ChefesDeAndar;
        public static List<Classe> ClassesBasicas { get; private set; }
        public static List<Classe> Subclasses { get; private set; }
        public static bool Jogar(Jogador jogador)
        {
            foreach (Habilidade hab in jogador.Classe.Habilidades)
                hab.ResetarUsos();

            Round = 1;
            for (; Round <= 10; Round++) 
            {
                Inimigo inimigo = new Inimigo(jogador.Nivel, false);
                if (Round == 10)
                    inimigo = new Inimigo(jogador.Nivel, true);


                CombateView.ImprimirNumeroDoRound(Round);
                if (!Combate.Combater(jogador, inimigo))    
                {
                    // se o jogador perder um combate
                    return false;
                }
                if ( Round == 5)
                    jogador.LevelUp();

                jogador.ZerarAtributosExtras();

            }
       
            return true;
        }
        public static void ListarClasses()
        {
            ClassesBasicas = new List<Classe>() {new Arqueiro(), new Conjurador(), new Espadachim(), new Ladrao()};
            Subclasses = new List<Classe>() {new Atirador(), new Cavaleiro(),  new Feiticeiro(), new Guerreiro(),
                                                 new Ladino(),   new Mago(),       new Mercenario(), new Ranger()};
        }
        public static void ListarChefesDeAndar()
        {
            ChefesDeAndar= new List<Inimigo>();

          //  Inimigo inimigo = new Inimigo();
        }
    }
}
