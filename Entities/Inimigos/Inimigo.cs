using Classes;
using Entities;

namespace Inimigos
{
    internal class Inimigo : CriaturaBase
    {
        public Inimigo(int nivel) 
        {
            if (nivel == 1)
                nivel++;
            // pegando os numeros aleatórios
            Random random= new Random();
            int numNome = random.Next(1, 21985);
            int numNivel = random.Next(-1, 1);
            int pocoesVida = random.Next(0, 2);
            int pocoesMana = random.Next(0, 2);


            Nome = NomeAleatorio(numNome);            
            Nivel = nivel + numNivel;           
            Classe = new Espadachim();

            VidaAtual = VidaTotal;
            ManaAtual= ManaTotal;

        }

        public static string NomeAleatorio(int numero)
        {
            string[] nomes = File.ReadAllLines(@"..\..\..\Repositories\Data\Nomes.txt");

            return nomes[numero -1];
        }
        
    }
}
