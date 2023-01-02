using Entities;
namespace Menu
{
    internal static class MenuDeCombate
    {
        public static string MostrarMenuDeCombate()
        {

            string[] opcoes = { "1", "2", "3", "4" };
            string resposta = "";

            Console.WriteLine("");
            Console.WriteLine("     1- Atacar");
            Console.WriteLine("     2- Habilidade Especial");
            Console.WriteLine("     3- Itens Consumíveis");
            Console.WriteLine("     4- Janela de Status");

            do
            {
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;

        }

        public static string MenuDeHabilidades(CriaturaBase jogador)
        {
            int numeroDeHabilidades = jogador.Classe.Habilidades.Count;
            IEnumerable<int> enumerable = Enumerable.Range(1, numeroDeHabilidades + 2);
            string[] opcoes = enumerable.Select(x => x.ToString()).ToArray();
            string resposta;


            do
            {
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;
        }

        public static string MenuDeConsumiveis()
        {
            string[] opcoes = { "1", "2", "3" };
            string resposta;

            do
            {
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;

        }
    }
}
