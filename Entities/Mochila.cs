using Items;
using System.Text;

namespace Entities
{
    internal class Mochila
    {
        public List<Item> Items { get; private set; }
       
        public Mochila()
        {
            Items = new List<Item>();
            for (int i=0; i <5; i++)
            {
                Items.Add(new PocaoVida());
                Items.Add(new PocaoMana());
            }
        }
        public Mochila(List<Item> items) 
        {
            Items = items;
        }

        public void ListarConsumiveisNaMochila()
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
            Console.WriteLine("     3- Voltar");
        }

        public void RemoverConsumivelDaMochila(Item pocao)
        {
            Items.Remove(pocao);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("     Itens:");

            Item arma = Items.Find(x => x is Arma);
            sb.AppendLine($"     {arma}");
            sb.AppendLine($"     [{Items.Count(x => x is PocaoVida)}] Poções de Vida");
            sb.AppendLine($"     [{Items.Count(x => x is PocaoMana)}] Poções de Mana");
            return sb.ToString();
        }
    }
}
