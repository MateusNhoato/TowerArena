using Classes;
using Entities;
using Items;
using Services;

namespace Inimigos
{
    internal class Inimigo : CriaturaBase
    {
        public Inimigo(int nivel) 
        {
            // pegando os numeros aleatórios
            Random random= new Random();
            int numNome = random.Next(1, 21985);
            int numNivel = random.Next(0, 4);
            int pocoes = random.Next(2, 7);
            int classNum;
            


            Nome = NomeAleatorio(numNome);            
            Nivel = nivel + numNivel;        
            if(Nivel >= 10)
            {
                classNum = random.Next(0, 8);
                Classe = JogoPrincipal.Subclasses[classNum];
            }
            else
            {
                classNum = random.Next(0, 4);
                Classe = JogoPrincipal.ClassesBasicas[classNum];
            }
 
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
        public Inimigo(string nome, int nivel, Classe classe)
        {
            Nome = nome;
            Nivel = nivel;
            Classe = classe;
            Mochila = new Mochila();
            Mochila.Items.Insert(0, Classe.Arma);
            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        public static string NomeAleatorio(int numero)
        {
            string[] nomes = File.ReadAllLines(@"..\..\..\Repositories\Data\Nomes.txt");

            return nomes[numero -1];
        }
        
    }
}
