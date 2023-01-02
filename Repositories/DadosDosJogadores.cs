
using Classes;
using Entities;
using Items;

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
            int pocoesDeVida = jogador.Mochila.Items.Count(x => x is PocaoVida);
            int pocoesDeMana = jogador.Mochila.Items.Count(x => x is PocaoMana);
            int pocoesDeAgi = jogador.Mochila.Items.Count(x => x is PocaoAgilidade);
            int pocoesDeFor = jogador.Mochila.Items.Count(x => x is PocaoForca);
            int pocoesDeInt = jogador.Mochila.Items.Count(x => x is PocaoIntelecto);
            int pocoesDeDef = jogador.Mochila.Items.Count(x => x is PocaoDefesa);



            int dinheiro = jogador.Mochila.Dinheiro;


            string[] personagens = File.ReadAllLines(infoPersonagensPath);

            for (int i = 0; i < personagens.Length; i++)
            {
                string[] personagem = personagens[i].Split(';');

                if (personagem[0] == nome)
                {
                    personagens[i] = $"{nome};{nivel};{andar};{classe};{vidaAtual};{manaAtual};{pocoesDeVida},{pocoesDeMana},{pocoesDeAgi},{pocoesDeFor},{pocoesDeInt},{pocoesDeDef};{dinheiro}";
                    File.WriteAllLines(infoPersonagensPath, personagens);
                    return;
                }
            }

            using (StreamWriter sw = new StreamWriter(infoPersonagensPath, true))
            {
                sw.WriteLine($"{nome};{nivel};{andar};{classe};{vidaAtual};{manaAtual};{pocoesDeVida},{pocoesDeMana};{dinheiro}");
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
                        int pocoesAgi = int.Parse(pocoes[2]);
                        int pocoesFor = int.Parse(pocoes[3]);
                        int pocoesInt = int.Parse(pocoes[4]);
                        int pocoesDef = int.Parse(pocoes[5]);


                        int dinheiro = int.Parse(personagem[7]);

                        AdicionarPocoesNaLista(pocoesVida, new PocaoVida(), items);
                        AdicionarPocoesNaLista(pocoesMana, new PocaoMana(), items);
                        AdicionarPocoesNaLista(pocoesAgi, new PocaoAgilidade(), items);
                        AdicionarPocoesNaLista(pocoesFor, new PocaoForca(), items);
                        AdicionarPocoesNaLista(pocoesInt, new PocaoIntelecto(), items);
                        AdicionarPocoesNaLista(pocoesDef, new PocaoDefesa(), items);


                        Classe classe = Classe.Parse(personagem[3]);

                        if (classe != null)
                        {
                            jogador = new Jogador(personagem[0], classe, nivel, andar, vidaAtual, manaAtual, items, dinheiro);
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

        public static void AdicionarPocoesNaLista(int quantia, Item pocao, List<Item> items)
        {
            for(int i=0; i <quantia; i++)
            {
                items.Add(pocao);
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
                        string gold = infoArray[7];

                        if (int.Parse(vidaAtual) > 0)
                        {
                            Console.WriteLine($"\n     {cont}: {nome} ({classe}) | Nv:{nivel} | Andar:{andar} | Vida:{vidaAtual} | Mana:{manaAtual} | Gold:{gold}");
                            cont++;
                        }
                        else
                            Console.WriteLine($"\n     {nome} ({classe}) | Morto | Recorde: {andar} Andar(es)");


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
