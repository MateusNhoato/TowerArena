using View;
namespace Menu
{
    internal static class MenuDeCombate
    {
        public static string  MostrarMenuDeCombate()
        {
            
            string[] opcoes = { "1", "2", "3", "4" };
            string resposta = "";

            Console.WriteLine("\n\n");
            Console.WriteLine("     1- Atacar");
            Console.WriteLine("     2- Habilidade Especial");
            Console.WriteLine("     3- Itens Consumíveis");
            Console.WriteLine("     4- Fugir");
            
            do
            {
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;

        }
    }
}
