using Entities;
using View;
namespace Menu
{
    internal static class MenuDeCombate
    {
        public static string  MostrarMenuDeCombate()
        {
            
            string[] opcoes = { "1", "2", "3", "4", "5" };
            string resposta = "";

            Console.WriteLine("");
            Console.WriteLine("     1- Atacar");
            Console.WriteLine("     2- Habilidade Especial");
            Console.WriteLine("     3- Itens Consumíveis");
            Console.WriteLine("     4- Janela de Status");
            Console.WriteLine("     5- Fugir");
            
            do
            {
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;

        }

        public static string MenuDeHabilidades(Jogador jogador)
        {
            int numeroDeHabilidades = jogador.Classe.Habilidades.Count;
            IEnumerable<int> enumerable = Enumerable.Range(1, numeroDeHabilidades+2);
            string[] opcoes = enumerable.Select(x=> x.ToString()).ToArray();
            string resposta = "";

            jogador.Classe.ListarHabilidadesDaClasse();

            do
            {              
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (!opcoes.Contains(resposta));
            return resposta;
        }
    }
}
