using Entities;
using Menu;

namespace View
{
    public struct Texto
    {
        public static string tituloPrincipal = @"
        ███      ▄██████▄   ▄█     █▄     ▄████████    ▄████████       
    ▀█████████▄ ███    ███ ███     ███   ███    ███   ███    ███       
       ▀███▀▀██ ███    ███ ███     ███   ███    █▀    ███    ███       
        ███   ▀ ███    ███ ███     ███  ▄███▄▄▄      ▄███▄▄▄▄██▀       
        ███     ███    ███ ███     ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀         
        ███     ███    ███ ███     ███   ███    █▄  ▀███████████       
        ███     ███    ███ ███ ▄█▄ ███   ███    ███   ███    ███       
       ▄████▀    ▀██████▀   ▀███▀███▀    ██████████   ███    ███       
                                                      ███    ███       
            ▄████████    ▄████████    ▄████████ ███▄▄▄▄      ▄████████ 
           ███    ███   ███    ███   ███    ███ ███▀▀▀██▄   ███    ███ 
           ███    ███   ███    ███   ███    █▀  ███   ███   ███    ███ 
           ███    ███  ▄███▄▄▄▄██▀  ▄███▄▄▄     ███   ███   ███    ███ 
         ▀███████████ ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     ███   ███ ▀███████████ 
           ███    ███ ▀███████████   ███    █▄  ███   ███   ███    ███ 
           ███    ███   ███    ███   ███    ███ ███   ███   ███    ███ 
           ███    █▀    ███    ███   ██████████  ▀█   █▀    ███    █▀  
                        ███    ███                                     
";


        public static string novoPersonagem = @"
                                             ███▄▄▄▄    ▄██████▄   ▄█    █▄   ▄██████▄                                              
                                             ███▀▀▀██▄ ███    ███ ███    ███ ███    ███                                             
                                             ███   ███ ███    ███ ███    ███ ███    ███                                             
                                             ███   ███ ███    ███ ███    ███ ███    ███                                             
                                             ███   ███ ███    ███ ███    ███ ███    ███                                             
                                             ███   ███ ███    ███ ███    ███ ███    ███                                             
                                             ███   ███ ███    ███ ███    ███ ███    ███                                             
                                              ▀█   █▀   ▀██████▀   ▀██████▀   ▀██████▀                                              
                                                                                                                                    
       ▄███████▄    ▄████████    ▄████████    ▄████████  ▄██████▄  ███▄▄▄▄      ▄████████    ▄██████▄     ▄████████   ▄▄▄▄███▄▄▄▄   
      ███    ███   ███    ███   ███    ███   ███    ███ ███    ███ ███▀▀▀██▄   ███    ███   ███    ███   ███    ███ ▄██▀▀▀███▀▀▀██▄ 
      ███    ███   ███    █▀    ███    ███   ███    █▀  ███    ███ ███   ███   ███    ███   ███    █▀    ███    █▀  ███   ███   ███ 
      ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███        ███    ███ ███   ███   ███    ███  ▄███         ▄███▄▄▄     ███   ███   ███ 
    ▀█████████▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████ ███    ███ ███   ███ ▀███████████ ▀▀███ ████▄  ▀▀███▀▀▀     ███   ███   ███ 
      ███          ███    █▄  ▀███████████          ███ ███    ███ ███   ███   ███    ███   ███    ███   ███    █▄  ███   ███   ███ 
      ███          ███    ███   ███    ███    ▄█    ███ ███    ███ ███   ███   ███    ███   ███    ███   ███    ███ ███   ███   ███ 
     ▄████▀        ██████████   ███    ███  ▄████████▀   ▀██████▀   ▀█   █▀    ███    █▀    ████████▀    ██████████  ▀█   ███   █▀  
                                ███    ███                                                                                        ";


        public static string linha = @"                                                                                                   
    ████████████████████████████████████████████";


        public static string personagens = @"
       ▄███████▄    ▄████████    ▄████████    ▄████████  ▄██████▄  ███▄▄▄▄      ▄████████    ▄██████▄     ▄████████ ███▄▄▄▄      ▄████████ 
      ███    ███   ███    ███   ███    ███   ███    ███ ███    ███ ███▀▀▀██▄   ███    ███   ███    ███   ███    ███ ███▀▀▀██▄   ███    ███ 
      ███    ███   ███    █▀    ███    ███   ███    █▀  ███    ███ ███   ███   ███    ███   ███    █▀    ███    █▀  ███   ███   ███    █▀  
      ███    ███  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███        ███    ███ ███   ███   ███    ███  ▄███         ▄███▄▄▄     ███   ███   ███        
    ▀█████████▀  ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████ ███    ███ ███   ███ ▀███████████ ▀▀███ ████▄  ▀▀███▀▀▀     ███   ███ ▀███████████ 
      ███          ███    █▄  ▀███████████          ███ ███    ███ ███   ███   ███    ███   ███    ███   ███    █▄  ███   ███          ███ 
      ███          ███    ███   ███    ███    ▄█    ███ ███    ███ ███   ███   ███    ███   ███    ███   ███    ███ ███   ███    ▄█    ███ 
     ▄████▀        ██████████   ███    ███  ▄████████▀   ▀██████▀   ▀█   █▀    ███    █▀    ████████▀    ██████████  ▀█   █▀   ▄████████▀  
                                ███    ███                                                                                                 ";

        public static string tower = @"
        ███      ▄██████▄   ▄█     █▄     ▄████████    ▄████████ 
    ▀█████████▄ ███    ███ ███     ███   ███    ███   ███    ███ 
       ▀███▀▀██ ███    ███ ███     ███   ███    █▀    ███    ███ 
        ███   ▀ ███    ███ ███     ███  ▄███▄▄▄      ▄███▄▄▄▄██▀ 
        ███     ███    ███ ███     ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   
        ███     ███    ███ ███     ███   ███    █▄  ▀███████████ 
        ███     ███    ███ ███ ▄█▄ ███   ███    ███   ███    ███ 
       ▄████▀    ▀██████▀   ▀███▀███▀    ██████████   ███    ███ 
                                                      ███    ███ ";

        public static string floor = @"
        ▄████████  ▄█        ▄██████▄   ▄██████▄     ▄████████ 
       ███    ███ ███       ███    ███ ███    ███   ███    ███ 
       ███    █▀  ███       ███    ███ ███    ███   ███    ███ 
      ▄███▄▄▄     ███       ███    ███ ███    ███  ▄███▄▄▄▄██▀ 
     ▀▀███▀▀▀     ███       ███    ███ ███    ███ ▀▀███▀▀▀▀▀   
       ███        ███       ███    ███ ███    ███ ▀███████████ 
       ███        ███▌    ▄ ███    ███ ███    ███   ███    ███ 
       ███        █████▄▄██  ▀██████▀   ▀██████▀    ███    ███ 
                  ▀                                 ███    ███";
        public static string consumiveis = @"
      ▄████████  ▄██████▄  ███▄▄▄▄      ▄████████ ███    █▄    ▄▄▄▄███▄▄▄▄    ▄█   ▄█    █▄     ▄████████  ▄█     ▄████████ 
     ███    ███ ███    ███ ███▀▀▀██▄   ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄ ███  ███    ███   ███    ███ ███    ███    ███ 
     ███    █▀  ███    ███ ███   ███   ███    █▀  ███    ███ ███   ███   ███ ███▌ ███    ███   ███    █▀  ███▌   ███    █▀  
     ███        ███    ███ ███   ███   ███        ███    ███ ███   ███   ███ ███▌ ███    ███  ▄███▄▄▄     ███▌   ███        
     ███        ███    ███ ███   ███ ▀███████████ ███    ███ ███   ███   ███ ███▌ ███    ███ ▀▀███▀▀▀     ███▌ ▀███████████ 
     ███    █▄  ███    ███ ███   ███          ███ ███    ███ ███   ███   ███ ███  ███    ███   ███    █▄  ███           ███ 
     ███    ███ ███    ███ ███   ███    ▄█    ███ ███    ███ ███   ███   ███ ███  ███    ███   ███    ███ ███     ▄█    ███ 
     ████████▀   ▀██████▀   ▀█   █▀   ▄████████▀  ████████▀   ▀█   ███   █▀  █▀    ▀██████▀    ██████████ █▀    ▄████████▀  
                                                                                                                          ";
        public static string loja = @"
      ▄█        ▄██████▄       ▄█    ▄████████ 
     ███       ███    ███     ███   ███    ███ 
     ███       ███    ███     ███   ███    ███ 
     ███       ███    ███     ███   ███    ███ 
     ███       ███    ███     ███ ▀███████████ 
     ███       ███    ███     ███   ███    ███ 
     ███▌    ▄ ███    ███     ███   ███    ███ 
     █████▄▄██  ▀██████▀  █▄ ▄███   ███    █▀  
     ▀                    ▀▀▀▀▀▀                ";
        public static string boss = @"
        ▀█████████▄   ▄██████▄     ▄████████    ▄████████ 
          ███    ███ ███    ███   ███    ███   ███    ███ 
          ███    ███ ███    ███   ███    █▀    ███    █▀  
         ▄███▄▄▄██▀  ███    ███   ███          ███        
        ▀▀███▀▀▀██▄  ███    ███ ▀███████████ ▀███████████ 
          ███    ██▄ ███    ███          ███          ███ 
          ███    ███ ███    ███    ▄█    ███    ▄█    ███ 
        ▄█████████▀   ▀██████▀   ▄████████▀   ▄████████▀  
                                                       ";
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

        public static string escolhaDeClasse = @"
        ▄████████    ▄████████  ▄████████  ▄██████▄   ▄█          ▄█    █▄       ▄████████     ████████▄     ▄████████     
       ███    ███   ███    ███ ███    ███ ███    ███ ███         ███    ███     ███    ███     ███   ▀███   ███    ███     
       ███    █▀    ███    █▀  ███    █▀  ███    ███ ███         ███    ███     ███    ███     ███    ███   ███    █▀      
      ▄███▄▄▄       ███        ███        ███    ███ ███        ▄███▄▄▄▄███▄▄   ███    ███     ███    ███  ▄███▄▄▄         
     ▀▀███▀▀▀     ▀███████████ ███        ███    ███ ███       ▀▀███▀▀▀▀███▀  ▀███████████     ███    ███ ▀▀███▀▀▀         
       ███    █▄           ███ ███    █▄  ███    ███ ███         ███    ███     ███    ███     ███    ███   ███    █▄      
       ███    ███    ▄█    ███ ███    ███ ███    ███ ███▌    ▄   ███    ███     ███    ███     ███   ▄███   ███    ███     
       ██████████  ▄████████▀  ████████▀   ▀██████▀  █████▄▄██   ███    █▀      ███    █▀      ████████▀    ██████████     
                                                     ▀                                                                     
                      ▄████████  ▄█          ▄████████    ▄████████    ▄████████    ▄████████                              
                     ███    ███ ███         ███    ███   ███    ███   ███    ███   ███    ███                              
                     ███    █▀  ███         ███    ███   ███    █▀    ███    █▀    ███    █▀                               
                     ███        ███         ███    ███   ███          ███         ▄███▄▄▄                                  
                     ███        ███       ▀███████████ ▀███████████ ▀███████████ ▀▀███▀▀▀                                  
                     ███    █▄  ███         ███    ███          ███          ███   ███    █▄                               
                     ███    ███ ███▌    ▄   ███    ███    ▄█    ███    ▄█    ███   ███    ███                              
                     ████████▀  █████▄▄██   ███    █▀   ▄████████▀   ▄████████▀    ██████████                              
                                ▀                                                                                          
";

        public static string meioDoAndar = @"
       ▄▄▄▄███▄▄▄▄      ▄████████  ▄█   ▄██████▄      ████████▄   ▄██████▄         ▄████████ ███▄▄▄▄   ████████▄     ▄████████    ▄████████ 
     ▄██▀▀▀███▀▀▀██▄   ███    ███ ███  ███    ███     ███   ▀███ ███    ███       ███    ███ ███▀▀▀██▄ ███   ▀███   ███    ███   ███    ███ 
     ███   ███   ███   ███    █▀  ███▌ ███    ███     ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███   ███    ███ 
     ███   ███   ███  ▄███▄▄▄     ███▌ ███    ███     ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███  ▄███▄▄▄▄██▀ 
     ███   ███   ███ ▀▀███▀▀▀     ███▌ ███    ███     ███    ███ ███    ███     ▀███████████ ███   ███ ███    ███ ▀███████████ ▀▀███▀▀▀▀▀   
     ███   ███   ███   ███    █▄  ███  ███    ███     ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███ ▀███████████ 
     ███   ███   ███   ███    ███ ███  ███    ███     ███   ▄███ ███    ███       ███    ███ ███   ███ ███   ▄███   ███    ███   ███    ███ 
      ▀█   ███   █▀    ██████████ █▀    ▀██████▀      ████████▀   ▀██████▀        ███    █▀   ▀█   █▀  ████████▀    ███    █▀    ███    ███ 
                                                                                                                                 ███    ███ ";
        public static string finalDoAndar = @"
        ▄████████  ▄█  ███▄▄▄▄      ▄████████  ▄█           ████████▄   ▄██████▄         ▄████████ ███▄▄▄▄   ████████▄     ▄████████    ▄████████ 
       ███    ███ ███  ███▀▀▀██▄   ███    ███ ███           ███   ▀███ ███    ███       ███    ███ ███▀▀▀██▄ ███   ▀███   ███    ███   ███    ███ 
       ███    █▀  ███▌ ███   ███   ███    ███ ███           ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███   ███    ███ 
      ▄███▄▄▄     ███▌ ███   ███   ███    ███ ███           ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███  ▄███▄▄▄▄██▀ 
     ▀▀███▀▀▀     ███▌ ███   ███ ▀███████████ ███           ███    ███ ███    ███     ▀███████████ ███   ███ ███    ███ ▀███████████ ▀▀███▀▀▀▀▀   
       ███        ███  ███   ███   ███    ███ ███           ███    ███ ███    ███       ███    ███ ███   ███ ███    ███   ███    ███ ▀███████████ 
       ███        ███  ███   ███   ███    ███ ███▌    ▄     ███   ▄███ ███    ███       ███    ███ ███   ███ ███   ▄███   ███    ███   ███    ███ 
       ███        █▀    ▀█   █▀    ███    █▀  █████▄▄██     ████████▀   ▀██████▀        ███    █▀   ▀█   █▀  ████████▀    ███    █▀    ███    ███ 
                                              ▀                                                                                        ███    ███";
        public static string topoDaTorre = @"
         ███      ▄██████▄     ▄███████▄  ▄██████▄      ████████▄     ▄████████         ███      ▄██████▄     ▄████████    ▄████████    ▄████████ 
     ▀█████████▄ ███    ███   ███    ███ ███    ███     ███   ▀███   ███    ███     ▀█████████▄ ███    ███   ███    ███   ███    ███   ███    ███ 
        ▀███▀▀██ ███    ███   ███    ███ ███    ███     ███    ███   ███    ███        ▀███▀▀██ ███    ███   ███    ███   ███    ███   ███    █▀  
         ███   ▀ ███    ███   ███    ███ ███    ███     ███    ███   ███    ███         ███   ▀ ███    ███  ▄███▄▄▄▄██▀  ▄███▄▄▄▄██▀  ▄███▄▄▄     
         ███     ███    ███ ▀█████████▀  ███    ███     ███    ███ ▀███████████         ███     ███    ███ ▀▀███▀▀▀▀▀   ▀▀███▀▀▀▀▀   ▀▀███▀▀▀     
         ███     ███    ███   ███        ███    ███     ███    ███   ███    ███         ███     ███    ███ ▀███████████ ▀███████████   ███    █▄  
         ███     ███    ███   ███        ███    ███     ███   ▄███   ███    ███         ███     ███    ███   ███    ███   ███    ███   ███    ███ 
        ▄████▀    ▀██████▀   ▄████▀       ▀██████▀      ████████▀    ███    █▀         ▄████▀    ▀██████▀    ███    ███   ███    ███   ██████████ 
                                                                                                             ███    ███   ███    ███             ";
        public static string fim = @"
        ▄████████  ▄█    ▄▄▄▄███▄▄▄▄   
       ███    ███ ███  ▄██▀▀▀███▀▀▀██▄ 
       ███    █▀  ███▌ ███   ███   ███ 
      ▄███▄▄▄     ███▌ ███   ███   ███ 
     ▀▀███▀▀▀     ███▌ ███   ███   ███ 
       ███        ███  ███   ███   ███ 
       ███        ███  ███   ███   ███ 
       ███        █▀    ▀█   ███   █▀  
                                     ";
        public static string muitoObrigadoPorJogar = @"
       ▄▄▄▄███▄▄▄▄   ███    █▄   ▄█      ███      ▄██████▄       ▄██████▄  ▀█████████▄     ▄████████  ▄█     ▄██████▄     ▄████████ ████████▄   ▄██████▄  
     ▄██▀▀▀███▀▀▀██▄ ███    ███ ███  ▀█████████▄ ███    ███     ███    ███   ███    ███   ███    ███ ███    ███    ███   ███    ███ ███   ▀███ ███    ███ 
     ███   ███   ███ ███    ███ ███▌    ▀███▀▀██ ███    ███     ███    ███   ███    ███   ███    ███ ███▌   ███    █▀    ███    ███ ███    ███ ███    ███ 
     ███   ███   ███ ███    ███ ███▌     ███   ▀ ███    ███     ███    ███  ▄███▄▄▄██▀   ▄███▄▄▄▄██▀ ███▌  ▄███          ███    ███ ███    ███ ███    ███ 
     ███   ███   ███ ███    ███ ███▌     ███     ███    ███     ███    ███ ▀▀███▀▀▀██▄  ▀▀███▀▀▀▀▀   ███▌ ▀▀███ ████▄  ▀███████████ ███    ███ ███    ███ 
     ███   ███   ███ ███    ███ ███      ███     ███    ███     ███    ███   ███    ██▄ ▀███████████ ███    ███    ███   ███    ███ ███    ███ ███    ███ 
     ███   ███   ███ ███    ███ ███      ███     ███    ███     ███    ███   ███    ███   ███    ███ ███    ███    ███   ███    ███ ███   ▄███ ███    ███ 
      ▀█   ███   █▀  ████████▀  █▀      ▄████▀    ▀██████▀       ▀██████▀  ▄█████████▀    ███    ███ █▀     ████████▀    ███    █▀  ████████▀   ▀██████▀  
                                                                                          ███    ███                                                      
                            ▄███████▄  ▄██████▄     ▄████████          ▄█  ▄██████▄     ▄██████▄     ▄████████    ▄████████                               
                           ███    ███ ███    ███   ███    ███         ███ ███    ███   ███    ███   ███    ███   ███    ███                               
                           ███    ███ ███    ███   ███    ███         ███ ███    ███   ███    █▀    ███    ███   ███    ███                               
                           ███    ███ ███    ███  ▄███▄▄▄▄██▀         ███ ███    ███  ▄███          ███    ███  ▄███▄▄▄▄██▀                               
                         ▀█████████▀  ███    ███ ▀▀███▀▀▀▀▀           ███ ███    ███ ▀▀███ ████▄  ▀███████████ ▀▀███▀▀▀▀▀                                 
                           ███        ███    ███ ▀███████████         ███ ███    ███   ███    ███   ███    ███ ▀███████████                               
                           ███        ███    ███   ███    ███         ███ ███    ███   ███    ███   ███    ███   ███    ███                               
                          ▄████▀       ▀██████▀    ███    ███     █▄ ▄███  ▀██████▀    ████████▀    ███    █▀    ███    ███                               
                                                   ███    ███     ▀▀▀▀▀▀                                         ███    ███ ";
        public static void ImprimirAndarAtual(int numero)
        {
            if (numero == 10)
                numero = 0;

            Console.Clear();
            Console.WriteLine(floor);
            Console.WriteLine(numerosArray[numero]);
            System.Threading.Thread.Sleep(1500);
        }

        public static void SelecaoSubClasse()
        {
            Console.Clear();
            Console.WriteLine(escolhaDeClasse);
        }

        public static void FinalDoJogo(string jogador)
        {
            Console.Clear();
            Console.WriteLine(topoDaTorre);
            string paragrafo = "          E então, depois de passar por diversos adversários e provações nosso Héroi," +
                             $"\n          {jogador}, triunfou! Se tornando assim, um Conquistador da Torre.\n\n";

            for(int i=0; i<paragrafo.Length; i++) 
            {
                Console.Write(paragrafo[i]);
                Thread.Sleep(50);
            }
            Thread.Sleep(1000);
            MenuPrincipal.AperteEnterParaContinuar();
            Console.Clear();
            Console.WriteLine(fim);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine(muitoObrigadoPorJogar);           
        }
    }
}
