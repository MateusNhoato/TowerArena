using Entities;
using Inimigos;
using Menu;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace View
{
    internal class CombateView
        {

        public static string iniciativa = @"
     ▄█  ███▄▄▄▄    ▄█   ▄████████  ▄█     ▄████████     ███      ▄█   ▄█    █▄     ▄████████ 
    ███  ███▀▀▀██▄ ███  ███    ███ ███    ███    ███ ▀█████████▄ ███  ███    ███   ███    ███ 
    ███▌ ███   ███ ███▌ ███    █▀  ███▌   ███    ███    ▀███▀▀██ ███▌ ███    ███   ███    ███ 
    ███▌ ███   ███ ███▌ ███        ███▌   ███    ███     ███   ▀ ███▌ ███    ███   ███    ███ 
    ███▌ ███   ███ ███▌ ███        ███▌ ▀███████████     ███     ███▌ ███    ███ ▀███████████ 
    ███  ███   ███ ███  ███    █▄  ███    ███    ███     ███     ███  ███    ███   ███    ███ 
    ███  ███   ███ ███  ███    ███ ███    ███    ███     ███     ███  ███    ███   ███    ███ 
    █▀    ▀█   █▀  █▀   ████████▀  █▀     ███    █▀     ▄████▀   █▀    ▀██████▀    ███    █▀  ";
        public static string[] dado = { 
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |     __       | |
                                    | |    /  |      | |
                                    | |    `| |      | |
                                    | |     | |      | |
                                    | |    _| |_     | |
                                    | |   |_____|    | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    ",
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |    _____     | |
                                    | |   / ___ `.   | |
                                    | |  |_/___) |   | |
                                    | |   .'____.'   | |
                                    | |  / /____     | |
                                    | |  |_______|   | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    ",
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |    ______    | |
                                    | |   / ____ `.  | |
                                    | |   `'  __) |  | |
                                    | |   _  |__ '.  | |
                                    | |  | \____) |  | |
                                    | |   \______.'  | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    ",
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |   _    _     | |
                                    | |  | |  | |    | |
                                    | |  | |__| |_   | |
                                    | |  |____   _|  | |
                                    | |      _| |_   | |
                                    | |     |_____|  | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    ",
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |   _______    | |
                                    | |  |  _____|   | |
                                    | |  | |____     | |
                                    | |  '_.____''.  | |
                                    | |  | \____) |  | |
                                    | |   \______.'  | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    ",
                                     @"
                                     .----------------. 
                                    | .--------------. |
                                    | |    ______    | |
                                    | |  .' ____ \   | |
                                    | |  | |____\_|  | |
                                    | |  | '____`'.  | |
                                    | |  | (____) |  | |
                                    | |  '.______.'  | |
                                    | |              | |
                                    | '--------------' |
                                     '----------------' 
                                    " };

        public static string jogador = @"
         ▄█  ▄██████▄     ▄██████▄     ▄████████ ████████▄   ▄██████▄     ▄████████ 
        ███ ███    ███   ███    ███   ███    ███ ███   ▀███ ███    ███   ███    ███ 
        ███ ███    ███   ███    █▀    ███    ███ ███    ███ ███    ███   ███    ███ 
        ███ ███    ███  ▄███          ███    ███ ███    ███ ███    ███  ▄███▄▄▄▄██▀ 
        ███ ███    ███ ▀▀███ ████▄  ▀███████████ ███    ███ ███    ███ ▀▀███▀▀▀▀▀   
        ███ ███    ███   ███    ███   ███    ███ ███    ███ ███    ███ ▀███████████ 
        ███ ███    ███   ███    ███   ███    ███ ███   ▄███ ███    ███   ███    ███ 
    █▄ ▄███  ▀██████▀    ████████▀    ███    █▀  ████████▀   ▀██████▀    ███    ███ 
    ▀▀▀▀▀▀                                                               ███    ███ ";

        public static string inimigo = @"
      ▄██████▄     ▄███████▄  ▄██████▄  ███▄▄▄▄      ▄████████ ███▄▄▄▄       ███        ▄████████ 
     ███    ███   ███    ███ ███    ███ ███▀▀▀██▄   ███    ███ ███▀▀▀██▄ ▀█████████▄   ███    ███ 
     ███    ███   ███    ███ ███    ███ ███   ███   ███    █▀  ███   ███    ▀███▀▀██   ███    █▀  
     ███    ███   ███    ███ ███    ███ ███   ███  ▄███▄▄▄     ███   ███     ███   ▀  ▄███▄▄▄     
     ███    ███ ▀█████████▀  ███    ███ ███   ███ ▀▀███▀▀▀     ███   ███     ███     ▀▀███▀▀▀     
     ███    ███   ███        ███    ███ ███   ███   ███    █▄  ███   ███     ███       ███    █▄  
     ███    ███   ███        ███    ███ ███   ███   ███    ███ ███   ███     ███       ███    ███ 
      ▀██████▀   ▄████▀       ▀██████▀   ▀█   █▀    ██████████  ▀█   █▀     ▄████▀     ██████████ 
                                                                                                  
";
        public static string comeca = @"
        ▄███████▄    ▄████████  ▄█    ▄▄▄▄███▄▄▄▄      ▄████████  ▄█     ▄████████  ▄██████▄  
       ███    ███   ███    ███ ███  ▄██▀▀▀███▀▀▀██▄   ███    ███ ███    ███    ███ ███    ███ 
       ███    ███   ███    ███ ███▌ ███   ███   ███   ███    █▀  ███▌   ███    ███ ███    ███ 
       ███    ███  ▄███▄▄▄▄██▀ ███▌ ███   ███   ███  ▄███▄▄▄     ███▌  ▄███▄▄▄▄██▀ ███    ███ 
     ▀█████████▀  ▀▀███▀▀▀▀▀   ███▌ ███   ███   ███ ▀▀███▀▀▀     ███▌ ▀▀███▀▀▀▀▀   ███    ███ 
       ███        ▀███████████ ███  ███   ███   ███   ███    █▄  ███  ▀███████████ ███    ███ 
       ███          ███    ███ ███  ███   ███   ███   ███    ███ ███    ███    ███ ███    ███ 
      ▄████▀        ███    ███ █▀    ▀█   ███   █▀    ██████████ █▀     ███    ███  ▀██████▀  
                    ███    ███                                          ███    ███          ";

         public static string _100Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ███████████████████████████████████████████ 
    ██                                       ██ 
    ███                                     ███                                             
    ";
         public static string _90Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████████████████████████   ██ 
    ██                                       ██ 
    ███                                     ███                                                                                             
    ";
         public static string _80Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████████████████████       ██ 
    ██                                       ██ 
    ███                                     ███                                                                                          
    ";
         public static string _70Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████████████████           ██ 
    ██                                       ██ 
    ███                                     ███                                                                                         
    ";
        public static string _60Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████████████               ██ 
    ██                                       ██ 
    ███                                     ███                                                                                       
    ";
         public static string _50Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████████                   ██ 
    ██                                       ██ 
    ███                                     ███                                                                                     
    ";
        public static string _40Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████████                       ██ 
    ██                                       ██ 
    ███                                     ███                                                                                   
    ";
        public static string _30Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████████                           ██ 
    ██                                       ██ 
    ███                                     ███                                                                                 
    ";
        public static string _20Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████████                               ██ 
    ██                                       ██ 
    ███                                     ███                                                                              
    ";
        public static string _10Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██████                                   ██ 
    ██                                       ██ 
    ███                                     ███                                                                            
    ";
        public static string _0Porcento = @"
    ███                                     ███ 
    ██                                       ██ 
    ██                                       ██ 
    ██                                       ██ 
    ███                                     ███                                                                            
    ";

        public static string versus = @"
              ▄█    █▄     ▄████████ 
             ███    ███   ███    ███ 
             ███    ███   ███    █▀  
             ███    ███   ███        
             ███    ███ ▀███████████ 
             ███    ███          ███ 
             ███    ███    ▄█    ███ 
              ▀██████▀   ▄████████▀                          
    ";
        public static string status = @"
       ▄████████     ███        ▄████████     ███     ███    █▄     ▄████████ 
      ███    ███ ▀█████████▄   ███    ███ ▀█████████▄ ███    ███   ███    ███ 
      ███    █▀     ▀███▀▀██   ███    ███    ▀███▀▀██ ███    ███   ███    █▀  
      ███            ███   ▀   ███    ███     ███   ▀ ███    ███   ███        
    ▀███████████     ███     ▀███████████     ███     ███    ███ ▀███████████ 
             ███     ███       ███    ███     ███     ███    ███          ███ 
       ▄█    ███     ███       ███    ███     ███     ███    ███    ▄█    ███ 
     ▄████████▀     ▄████▀     ███    █▀     ▄████▀   ████████▀   ▄████████▀";

        public static string venceu = @"
         ▄█    █▄     ▄████████ ███▄▄▄▄    ▄████████    ▄████████ ███    █▄  
        ███    ███   ███    ███ ███▀▀▀██▄ ███    ███   ███    ███ ███    ███ 
        ███    ███   ███    █▀  ███   ███ ███    █▀    ███    █▀  ███    ███ 
        ███    ███  ▄███▄▄▄     ███   ███ ███         ▄███▄▄▄     ███    ███ 
        ███    ███ ▀▀███▀▀▀     ███   ███ ███        ▀▀███▀▀▀     ███    ███ 
        ███    ███   ███    █▄  ███   ███ ███    █▄    ███    █▄  ███    ███ 
        ███    ███   ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ 
         ▀██████▀    ██████████  ▀█   █▀  ████████▀    ██████████ ████████▀  
                                                                              
";      public static string fugiu = @"
               ▄████████ ███    █▄     ▄██████▄   ▄█  ███    █▄  
              ███    ███ ███    ███   ███    ███ ███  ███    ███ 
              ███    █▀  ███    ███   ███    █▀  ███▌ ███    ███ 
             ▄███▄▄▄     ███    ███  ▄███        ███▌ ███    ███ 
            ▀▀███▀▀▀     ███    ███ ▀▀███ ████▄  ███▌ ███    ███ 
              ███        ███    ███   ███    ███ ███  ███    ███ 
              ███        ███    ███   ███    ███ ███  ███    ███ 
              ███        ████████▀    ████████▀  █▀   ████████▀  
                                                              
";
        public static void ImprimirNumeroDoRound(int numero)
        {
            Console.Clear();
             
            Console.WriteLine(Texto.round);
            ConsoleColor aux = Console.ForegroundColor;
            if (numero == 5)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (numero == 10)
            {
                numero = 0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
                
                            
            Console.WriteLine(Texto.numerosArray[numero]);
            Console.ForegroundColor = aux;
            Console.WriteLine(Texto.roundLinha);
            System.Threading.Thread.Sleep(1500);
        }

        public static void ImprimirIniciativa(int iniJg, int iniIn)
        {
            Console.Clear();
            Console.WriteLine(iniciativa);
            
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine(dado[iniJg]);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(dado[iniIn]);

            System.Threading.Thread.Sleep(1500);
            Console.ForegroundColor = aux;

        }
        public static void InimigoComeca()
        {
            Console.Clear();
            Console.WriteLine(inimigo);
            Console.WriteLine(comeca);
            System.Threading.Thread.Sleep(1500);
        }

        public static void JogadorComeca()
        {
            Console.Clear();
            Console.WriteLine(jogador);
            Console.WriteLine(comeca);
            System.Threading.Thread.Sleep(1500);
        }
        public static string MostrarHabilidadesDaClasse(CriaturaBase jogador, CriaturaBase inimigo)
        {
            Console.Clear();
            ImprimirTelaDeCombate(jogador, inimigo);
            Console.WriteLine("\n     Habilidades:");
            jogador.Classe.ListarHabilidadesDaClasse();
            return MenuDeCombate.MenuDeHabilidades(jogador);

        }
        public static string MostrarItensConsumiveis(CriaturaBase jogador, CriaturaBase inimigo)
        {
            Console.Clear();
            ImprimirTelaDeCombate(jogador, inimigo);
            jogador.Mochila.ListarConsumiveisNaMochila(false);
            return MenuDeCombate.MenuDeConsumiveis();
        }
        public static void JanelaDeStatus(CriaturaBase jogador)
        {
            ConsoleColor aux = Console.ForegroundColor;

            Console.Clear();
            Console.WriteLine(status);

       
            Console.WriteLine($"\n     {jogador}");
            Console.Write("\n     Vida:[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{jogador.VidaAtual}");

            Console.ForegroundColor = aux;
            Console.Write("/");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{jogador.VidaTotal}");

            Console.ForegroundColor = aux;
            Console.Write("(");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{jogador.VidaExtra}");

            Console.ForegroundColor = aux;
            Console.Write(")]");

            
            Console.Write(" | Mana:[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{jogador.ManaAtual}");

            Console.ForegroundColor = aux;
            Console.Write("/");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{jogador.ManaTotal}");

            Console.ForegroundColor = aux;
            Console.WriteLine("]");

            
            Console.Write("     Poder     :[");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{jogador.PoderTotal}");


            Console.ForegroundColor = aux;
            Console.Write("(");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{jogador.PoderExtra}");

            Console.ForegroundColor = aux;
            Console.WriteLine(")]");

           
            Console.Write("     Defesa    :[");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{jogador.DefesaTotal}");

            Console.ForegroundColor = aux;
            Console.Write("(");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{jogador.DefesaExtra}");

            Console.ForegroundColor = aux;
            Console.WriteLine(")]");



            Console.ForegroundColor = aux;
            Console.Write("     Iniciativa:[");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{jogador.IniciativaTotal}");

            Console.ForegroundColor = aux;
            Console.Write("(");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{jogador.IniciativaExtra}");

            Console.ForegroundColor = aux;
            Console.WriteLine(")]");


           
            Console.WriteLine("\n\n     Obs: os números entre parênteses são atributos extras.");
            Console.WriteLine(Texto.linha);
            MenuPrincipal.AperteEnterParaContinuar();
        }
        public static void ImprimirTelaDeCombate(CriaturaBase jogador, CriaturaBase inimigo)
        {
            if(jogador is Inimigo)
            {
                ImprimirTelaDeCombate(inimigo, jogador);
                return;
            }

            Console.Clear();
            string barraDeVidaJogador;
            string barraDeVidaInimigo;

            double vidaJogador = jogador.PorcentagemVida();
            double vidaInimigo = inimigo.PorcentagemVida();

            ConsoleColor corVidaJogador;
            ConsoleColor corVidaInimigo;

            // cor da vida do jogador
            if (vidaJogador >= 70)
                corVidaJogador = ConsoleColor.DarkGreen;
            else if (vidaJogador >= 30)
                corVidaJogador = ConsoleColor.Green;
            else
                corVidaJogador = ConsoleColor.Red;


            // cor da vida do inimigo
            if (vidaInimigo >= 50)
                corVidaInimigo= ConsoleColor.DarkRed;
            else 
                corVidaInimigo = ConsoleColor.Red;
            

            // barra de vida do jogador
            if (vidaJogador <= 0)
                barraDeVidaJogador = _0Porcento;
            else if (vidaJogador <= 10)
                barraDeVidaJogador = _10Porcento;
            else if (vidaJogador <= 20)
                barraDeVidaJogador = _20Porcento;
            else if (vidaJogador <= 30)
                barraDeVidaJogador = _30Porcento;
            else if (vidaJogador <= 40)
                barraDeVidaJogador = _40Porcento;
            else if (vidaJogador <= 50)
                barraDeVidaJogador = _50Porcento;
            else if (vidaJogador <= 60)
                barraDeVidaJogador = _60Porcento;
            else if (vidaJogador <= 70)
                barraDeVidaJogador = _70Porcento;
            else if (vidaJogador <= 80)
                barraDeVidaJogador = _80Porcento;
            else if (vidaJogador <= 90)
                barraDeVidaJogador = _90Porcento;
            else 
                barraDeVidaJogador = _100Porcento;


            // barra de vida do inimigo
            if (vidaInimigo <= 0)
                barraDeVidaInimigo = _0Porcento;
            else if (vidaInimigo <= 10)
                barraDeVidaInimigo = _10Porcento;
            else if (vidaInimigo <= 20)
                barraDeVidaInimigo = _20Porcento;
            else if (vidaInimigo <= 30)
                barraDeVidaInimigo = _30Porcento;
            else if (vidaInimigo <= 40)
                barraDeVidaInimigo = _40Porcento;
            else if (vidaInimigo <= 50)
                barraDeVidaInimigo = _50Porcento;
            else if (vidaInimigo <= 60)
                barraDeVidaInimigo = _60Porcento;
            else if (vidaInimigo <= 70)
                barraDeVidaInimigo = _70Porcento;
            else if (vidaInimigo <= 80)
                barraDeVidaInimigo = _80Porcento;
            else if (vidaInimigo <= 90)
                barraDeVidaInimigo = _90Porcento;
            else
                barraDeVidaInimigo = _100Porcento;

            ConsoleColor aux = Console.ForegroundColor;
            Console.WriteLine($"\n     {inimigo}");

            Console.ForegroundColor = corVidaInimigo;
            Console.WriteLine(barraDeVidaInimigo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(versus);
            

            Console.ForegroundColor = corVidaJogador;
            Console.WriteLine(barraDeVidaJogador);            
            Console.ForegroundColor = aux;
            Console.WriteLine($"\n     {jogador}");
            Console.Write($"\n     Vida:");
            Console.ForegroundColor = corVidaJogador;
            Console.Write($"[{jogador.VidaAtual} / {jogador.VidaTotal}]");

            Console.ForegroundColor = aux;
            Console.Write($"   Mana:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[{jogador.ManaAtual} / {jogador.ManaTotal}]");

            Console.ForegroundColor = aux;
            Console.WriteLine(Texto.linha);
        }

        public static void VitoriaDoJogador()
        {
            ConsoleColor aux = Console.ForegroundColor;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(jogador);
            Console.WriteLine(venceu);
            Thread.Sleep(1000);
            Console.ForegroundColor = aux;
        }
        public static void VitoriaDoOponente()
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(inimigo);
            Console.WriteLine(venceu);
            Thread.Sleep(1000);

            Console.ForegroundColor = aux;
        }

        public static void JogadorFugiu()
        {
            Console.Clear();
            Console.WriteLine(jogador);
            Console.WriteLine(fugiu);
            Thread.Sleep(1000);
        }
    
    }
}
