﻿using Menu;
using Inimigos;
using View;

using Classes;
namespace TowerArena
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.Title = "Tower Arena";
            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
           MenuPrincipal.MostrarMenuPrincipal();
                  
        }
    }
}