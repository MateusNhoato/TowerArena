﻿using Entities;
using Inimigos;
using System.Text;

namespace View
{
    internal class CombateView
        {
        public static string numerosString =

@"
                           ██   ██████ 
                          ███  ██  ████ 
                           ██  ██ ██ ██ 
                           ██  ████  ██ 
                           ██   ██████ +
                              ██     
                             ███     
                              ██      
                              ██      
                              ██     +     
                             ██████    
                                  ██  
                              █████   
                             ██      
                             ███████ + 
                             ██████    
                                  ██  
                              █████    
                                  ██  
                             ██████  + 
                             ██   ██  
                             ██   ██  
                             ███████  
                                  ██  
                                  ██ +                 
                             ███████  
                             ██       
                             ███████ 
                                  ██ 
                             ███████ +
                              ██████  
                             ██       
                             ███████  
                             ██    ██ 
                              ██████ + 
                             ███████ 
                                  ██ 
                                 ██  
                                ██   
                                ██   +
                              █████  
                             ██   ██ 
                              █████  
                             ██   ██ 
                              █████  +   
                              █████  
                             ██   ██ 
                              ██████ 
                                  ██ 
                              █████  ";
        public static string[] numerosArray = numerosString.Split('+');

        public static string round = @"
      ▄████████  ▄██████▄  ███    █▄  ███▄▄▄▄   ████████▄  
      ███    ███ ███    ███ ███    ███ ███▀▀▀██▄ ███   ▀███ 
      ███    ███ ███    ███ ███    ███ ███   ███ ███    ███ 
     ▄███▄▄▄▄██▀ ███    ███ ███    ███ ███   ███ ███    ███ 
    ▀▀███▀▀▀▀▀   ███    ███ ███    ███ ███   ███ ███    ███ 
    ▀███████████ ███    ███ ███    ███ ███   ███ ███    ███ 
      ███    ███ ███    ███ ███    ███ ███   ███ ███   ▄███ 
      ███    ███  ▀██████▀  ████████▀   ▀█   █▀  ████████▀  
      ███    ███                                          ";

        public static string roundLinha = @"
       ██                                              ██       
        ██                   ▄ ██ ▄                   ██        
 ██████████████████████████████████████████████████████████████ 
        ██                   ▀ ██ ▀                   ██        
       ██                                              ██       
                                                               
                                                               
";
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
      
        

        public static void ImprimirNumeroDoRound(Jogador jogador)
        {
            Console.Clear();
            int numero = jogador.Round % 10;
            Console.WriteLine(round);
            ConsoleColor aux = Console.ForegroundColor;
            if (numero == 5)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (numero == 0)            
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            
            Console.WriteLine(numerosArray[numero]);
            Console.ForegroundColor = aux;
            Console.WriteLine(roundLinha);
            System.Threading.Thread.Sleep(1500);
        }

        public static void ImprimirTelaDeCombate(Jogador jogador, Inimigo inimigo)
        {
            Console.Clear();
            string barraDeVidaJogador;
            string barraDeVidaInimigo;

            int vidaJogador = jogador.PorcentagemVida();
            int vidaInimigo = inimigo.PorcentagemVida();

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


            ConsoleColor aux = Console.ForegroundColor;
            Console.WriteLine($"\n     {inimigo}");

            Console.ForegroundColor = corVidaInimigo;
            Console.WriteLine(barraDeVidaInimigo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(versus);

            Console.ForegroundColor = aux;
            Console.WriteLine($"\n     {jogador}");

            Console.ForegroundColor = corVidaJogador;
            Console.WriteLine(barraDeVidaJogador);
            Console.ForegroundColor = aux;
            Console.Write($"\n      Mana:");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"[{jogador.ManaAtual} / {jogador.ManaTotal}]");
            Console.ForegroundColor = aux;
            Console.WriteLine(inimigo.VidaAtual + "/" +inimigo.VidaTotal);

        }
    }
}
