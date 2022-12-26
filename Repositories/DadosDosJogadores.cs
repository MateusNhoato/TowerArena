
using Entities;
using Classes;
using Items;
using Menu;

namespace Repositories
{
    static class DadosDosJogadores
    {
        private static string infoPersonagensPath = @"..\..\..\Repositories\Data\InfoPersonagens.txt";

        public static void SalvarInfoJogador(Jogador jogador)
        {
            string nome = jogador.Nome;
            string classe = jogador.Classe.Nome;
            int vidaAtual = jogador.VidaAtual;
            int manaAtual = jogador.ManaAtual;
            int andar = jogador.Andar;
            int nivel = jogador.Nivel;
            int pocoesDeVida = 0;
            int pocoesDeMana = 0;
            foreach (Item i in jogador.Items)
            {
                if (i.Nome == "Poção de Vida")
                    pocoesDeVida++;
                else if (i.Nome == "Pocão de Mana")
                    pocoesDeMana++;
            }

            string[] personagens = File.ReadAllLines(infoPersonagensPath);

            for(int i=0; i<personagens.Length; i++)
            {
                string[] personagem = personagens[i].Split(';');
                
                if(personagem[0] == nome)
                {
                    personagens[i] = $"{nome};{nivel};{andar};{classe};{vidaAtual};{manaAtual};{pocoesDeVida},{pocoesDeMana}";
                    File.WriteAllLines(infoPersonagensPath, personagens);
                    return;
                }
            }

            using (StreamWriter sw = new StreamWriter(infoPersonagensPath, true))
            {
                sw.WriteLine($"{nome};{nivel};{andar};{classe};{vidaAtual};{manaAtual};{pocoesDeVida},{pocoesDeMana}");
            }
        }

        public static bool CheckarNomeRepetido(string nome)
        {
            try
            {
                using (StreamReader sr = new StreamReader(infoPersonagensPath))
                {
                    string info = sr.ReadLine();
                    while (info != null)
                    {
                        string[] infoArray = info.Split(';');

                        if (infoArray[0] == nome)
                            return true;
                        info = sr.ReadLine();
                    }
                    return false;
                }
            }
            catch (FileNotFoundException)
            {
                File.Create(infoPersonagensPath).Close();
                return false;
            }

        }

        public static Jogador? AcharJogador(string nome)
        {
            Jogador jogador;
            try
            {
                string[] personagens = File.ReadAllLines(infoPersonagensPath);

                foreach (string s in personagens)
                {                   
                    string[] personagem = s.Split(';');

                    if (personagem[0] == nome && int.Parse(personagem[4]) > 0)
                    {
                        int nivel = int.Parse(personagem[1]);
                        int andar = int.Parse(personagem[2]);
                        int vidaAtual = int.Parse(personagem[4]);
                        int manaAtual = int.Parse(personagem[5]);

                        // lista de items
                        List<Item> items = new List<Item>();
                        string[] pocoes = personagem[6].Split(",");
                        int pocoesVida = int.Parse(pocoes[0]);
                        int pocoesMana = int.Parse(pocoes[1]);
                        for (int i = 0; i < pocoesVida; i++)
                        {
                            Item item = new PocaoVida();
                            items.Add(item);
                        }

                        for (int i = 0; i < pocoesMana; i++)
                        {
                            Item item = new PocaoMana();
                            items.Add(item);
                        }

                        Classe classe = Classe.Parse(personagem[3]);

                        if (classe != null)
                        {
                            jogador = new Jogador(personagem[0], classe, nivel, andar, vidaAtual, manaAtual, items);
                            return jogador;
                        }
                    }
                }

                return null;


            }
            catch (FileNotFoundException)
            {
                File.Create(infoPersonagensPath).Close();
                return null;
            }
        }

        public static void EditarInformacoesPersonagem(Jogador jogador)
        {
            string nome = jogador.Nome;
            string[] personagensDoArquivo = File.ReadAllLines(infoPersonagensPath);
            for (int i = 0; i < personagensDoArquivo.Length; i++)
            {
                string[] personagem = personagensDoArquivo[i].Split(';');
            }
        }
        public static void ListarPersonagens()
        {
            try
            {
                using (StreamReader sr = new StreamReader(infoPersonagensPath))
                {
                    string info = sr.ReadLine();
                    int cont = 1;
                    while (!string.IsNullOrEmpty(info))
                    {
                        string[] infoArray = info.Split(";");
                        string nome = infoArray[0];
                        string nivel = infoArray[1];
                        string andar = infoArray[2];

                        string classe = infoArray[3];
                        string vidaAtual = infoArray[4];
                        string manaAtual = infoArray[5];
                        if(int.Parse(vidaAtual) > 0)
                        {
                            Console.WriteLine($"\n     {cont}: {nome} ({classe}) | Nv:{nivel} | Andar:{andar} | Vida:{vidaAtual} | Mana:{manaAtual}");
                            cont++;
                        }
                        else
                            Console.WriteLine($"\n     {nome} ({classe}) | Morto | Recorde:{andar}");
                        
                        
                        info = sr.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                File.Create(infoPersonagensPath).Close();
                Console.WriteLine("     Nenhum Personagem encontrado.");
            }
        }
    }
}
