using Menu;
using Services;
using View;

namespace TowerArena
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Title = "Tower Arena";
            JogoPrincipal.ListarClasses();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            MenuPrincipal.MostrarMenuPrincipal();

        }
    }
}