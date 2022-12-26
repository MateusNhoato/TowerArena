﻿
using System.Net.NetworkInformation;

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
    █████████████████████████████████";


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
    }
}
