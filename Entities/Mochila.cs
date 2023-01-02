using Items;
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

        public void ListarConsumiveisNaMochila(bool loja)
        {
            Console.Write($"     1- Poções de Vida [");

            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Items.Count(x => x is PocaoVida)}");

            Console.ForegroundColor = aux;
            Console.WriteLine($"]");
            Console.Write($"     2- Poções de Mana [");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Items.Count(x => x is PocaoMana)}");
            Console.ForegroundColor = aux;
            Console.WriteLine("]");

            if (!loja)
                Console.WriteLine("     3- Voltar");
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
            sb.AppendLine("     Mochila:");
            sb.AppendLine($"     Gold: {Dinheiro}");
            sb.AppendLine($"{arma}");
            sb.AppendLine($"     [{Items.Count(x => x is PocaoVida)}] Poções de Vida");
            sb.AppendLine($"     [{Items.Count(x => x is PocaoMana)}] Poções de Mana");
            return sb.ToString();
        }
    }
}
