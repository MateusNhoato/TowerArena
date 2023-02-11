using Entities;
namespace Menu
{
    internal static class MenuDeCombate
    {
        public static string MostrarMenuDeCombate()
        {

            string[] opcoes = { "1", "2", "3", "4" };
            string resposta = "";
            View.CombateView.ImprimirOpcoesMenuDeCombate();          

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
            IEnumerable<int> enumerable = Enumerable.Range(0, numeroDeHabilidades + 1);
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
            string[] opcoes = { "0", "1", "2", "3", "4", "5", "6", };
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
