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
        public static string MostrarHabilidadesDaClasse(Jogador jogador, Inimigo inimigo)
        {
            Console.Clear();
            ImprimirTelaDeCombate(jogador, inimigo);
            Console.WriteLine("\n     Habilidades:");
            return MenuDeCombate.MenuDeHabilidades(jogador);

        }
        public static void JanelaDeStatus(Jogador jogador)
        {
            ConsoleColor aux = Console.ForegroundColor;

            Console.Clear();
            Console.WriteLine(status);

       
            Console.WriteLine($"\n     {jogador}");
            Console.Write("\n     Vida:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"[{jogador.VidaAtual} / {jogador.VidaTotal}({jogador.VidaExtra})]");

            Console.ForegroundColor = aux;
            Console.Write("   Mana:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[{jogador.ManaAtual} / {jogador.ManaTotal}]");

            Console.ForegroundColor = aux;
            Console.Write("     Poder     :");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[{jogador.PoderTotal}({jogador.PoderExtra})]");

            Console.ForegroundColor = aux;
            Console.Write("     Defesa    :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{jogador.DefesaTotal}({jogador.DefesaExtra})]");

            Console.ForegroundColor = aux;
            Console.Write("     Iniciativa:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{jogador.IniciativaTotal}({jogador.IniciativaExtra})]");

            Console.ForegroundColor = aux;
            Console.WriteLine("\n\n     Obs: os números entre parênteses são atributos extras.");
            Console.WriteLine(Texto.linha);
            MenuPrincipal.AperteEnterParaContinuar();
        }
        public static void ImprimirTelaDeCombate(Jogador jogador, Inimigo inimigo)
        {
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
            if (vidaJogador == 0)
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
            if (vidaInimigo == 0)
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

            Console.WriteLine($"{inimigo.VidaAtual} / {inimigo.VidaTotal}");
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
    }
}
