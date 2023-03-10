using Classes;
using Entities;
using Items;
using Services;

namespace Inimigos
{
    internal class Inimigo : CriaturaBase
    {
        private static string pathNomeInimigos = @"..\..\..\Repositories\Data\Nomes.txt";

        public static void ArrumarPathNomeInimigos()
        {
            try
            {
                string[] nomes = File.ReadAllLines(pathNomeInimigos);
            }
            catch (DirectoryNotFoundException)
            {
                pathNomeInimigos = @"Repositories\Data\Nomes.txt";
            }
        }

        public Inimigo(int nivel)
        {
            // pegando os numeros aleatórios
            Random random = new Random();
            int numNome = random.Next(1, 21985);
            int numNivel = random.Next(-1, 2);
            int pocoes = random.Next(0, 3);
            int classNum;

            if (nivel >= 11)
            {
                classNum = random.Next(0, 8);
                Classe = JogoPrincipal.Subclasses[classNum];
                pocoes = random.Next(2, 4);
            }
            else
            {
                classNum = random.Next(0, 4);
                Classe = JogoPrincipal.ClassesBasicas[classNum];

            }


            Nome = NomeAleatorio(numNome);
            Nivel = nivel + numNivel;
            if (nivel == 1)
                Nivel = 1;

            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;

            Mochila = new Mochila(new List<Item>());
            Mochila.AlterarDinheiro((5 + random.Next(1, 11)) * 2);

            for (int i = 0; i < pocoes; i++)
            {
                int n = random.Next(2);
                if (n == 0)
                    Mochila.Items.Add(new PocaoVida());
                else
                    Mochila.Items.Add(new PocaoMana());
            }

            if (random.Next(1,101) <= 3)
            {
                Item pocao;
                int pocaoEspecial = random.Next(0, 4);
                if (pocaoEspecial == 0)
                    pocao = new PocaoAgilidade();
                else if (pocaoEspecial == 1)
                    pocao = new PocaoForca();
                else if (pocaoEspecial == 2)
                    pocao = new PocaoIntelecto();
                else
                    pocao = new PocaoDefesa();
                Mochila.Items.Add(pocao);
            }
        }

        public static string NomeAleatorio(int numero)
        {
            string[] nomes = File.ReadAllLines(pathNomeInimigos);

            return nomes[numero - 1];
        }

    }
}
