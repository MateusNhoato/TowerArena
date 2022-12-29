using Classes;
using Entities;
using Items;
using TowerArena.Entities;

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
            int pocoes = random.Next(0, 7);
            


            Nome = NomeAleatorio(numNome);            
            Nivel = nivel + numNivel;           
            Classe = new Espadachim();
            Mochila = new Mochila(new List<Item>());
            Mochila.Items.Add(Classe.Arma);

            for(int i= 0; i< pocoes; i++)
            {
                int n = random.Next(2);
                if (n == 0)
                    Mochila.Items.Add(new PocaoVida());
                else
                    Mochila.Items.Add(new PocaoMana());
            }

            

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
