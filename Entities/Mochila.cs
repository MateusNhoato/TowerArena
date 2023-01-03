using Items;
using System;
using System.Text;

namespace Entities
{
    internal class Mochila
    {
        public List<Item> Items { get; private set; }
        public int Dinheiro { get; private set; }
        public Mochila()
        {
            Items = new List<Item>();
            for (int i = 0; i < 5; i++)
            {
                Items.Add(new PocaoVida());
                Items.Add(new PocaoMana());
            }
        }
        public Mochila(List<Item> items)
        {
            Items = items;
        }

        public void ListarConsumiveisNaMochila(bool mostrarPotsDeStatus)
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.Write($"     1- {new PocaoVida()} [");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Items.Count(x => x is PocaoVida)}");

            Console.ForegroundColor = aux;
            Console.WriteLine($"]");
            Console.Write($"     2- {new PocaoMana()} [");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Items.Count(x => x is PocaoMana)}");

            Console.ForegroundColor = aux;
            Console.WriteLine("]");

            if (mostrarPotsDeStatus)
            {
                Console.Write($"     3- {new PocaoAgilidade()} [");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"{Items.Count(x => x is PocaoAgilidade)}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]");



                Console.ForegroundColor = aux;
                Console.Write($"     4- {new PocaoForca()} [");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write($"{Items.Count(x => x is PocaoForca)}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]");

                Console.ForegroundColor = aux;
                Console.Write($"     5- {new PocaoIntelecto()} [");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{Items.Count(x => x is PocaoIntelecto)}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]");

                Console.ForegroundColor = aux;
                Console.Write($"     6- {new PocaoDefesa()} [");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{Items.Count(x => x is PocaoDefesa)}");

                Console.ForegroundColor = aux;
                Console.WriteLine("]");
            }

            Console.WriteLine("     0- Voltar");
        }

        public void RemoverConsumivelDaMochila(Item pocao)
        {
            Items.Remove(pocao);
        }

        public void AlterarDinheiro(int quantia)
        {
            Dinheiro += quantia;
        }

        public bool ChecarDinheiro(int quantia)
        {
            return (Dinheiro >= quantia);
        }

        public override string ToString()
        {
            Item arma = Items.Find(x => x is Arma);

            StringBuilder sb = new StringBuilder();
            if (Dinheiro > 0)
                sb.AppendLine($"     Gold: {Dinheiro}");
            if (Items.Count(x => x is PocaoVida) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoVida)}] Poções de Vida");
            if (Items.Count(x => x is PocaoMana) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoMana)}] Poções de Mana");
            if (Items.Count(x => x is PocaoAgilidade) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoAgilidade)}] Poções de Agilidade");
            if (Items.Count(x => x is PocaoForca) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoForca)}] Poções de Forca");
            if (Items.Count(x => x is PocaoIntelecto) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoIntelecto)}] Poções de Intelecto");
            if (Items.Count(x => x is PocaoDefesa) > 0)
                sb.AppendLine($"     [{Items.Count(x => x is PocaoDefesa)}] Poções de Defesa");
            return sb.ToString();
        }
    }
}
