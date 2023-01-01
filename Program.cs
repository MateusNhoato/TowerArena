using Menu;
using Inimigos;
using View;

using Classes;
using Services;

namespace TowerArena
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.Title = "Tower Arena";
            JogoPrincipal.ListarClasses();
            JogoPrincipal.ListarChefesDeAndar();
            Console.ForegroundColor= ConsoleColor.Black;
            Console.BackgroundColor= ConsoleColor.White;
           MenuPrincipal.MostrarMenuPrincipal();
                  
        }
    }
}