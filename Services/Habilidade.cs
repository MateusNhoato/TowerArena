using Entities;
using Enums;

namespace Services
{
    internal delegate void Efeito(CriaturaBase conjurador, CriaturaBase receptor);

    internal class Habilidade
    {
        public string Nome { get; private set; }
        public int CustoDeMana { get; private set; }
        public string Descricao { get; private set; }
        public Efeito Efeito { get; private set; }
        public int QuantidadeDeUsos { get; private set; }
        private int _usosMaximo;

        public Habilidade(string nome, int custoDeMana, int quantidadeDeUsos, string descricao, Efeito efeito)
        {
            Nome = nome;
            CustoDeMana = custoDeMana;
            Descricao = descricao;
            Efeito = efeito;           

            _usosMaximo = quantidadeDeUsos;
            QuantidadeDeUsos = quantidadeDeUsos;

        }

        public void DiminuirUso()
        {
            QuantidadeDeUsos--;

            if (QuantidadeDeUsos < 0)
                QuantidadeDeUsos = 0;
        }

        public void ResetarUsos()
        {
            QuantidadeDeUsos = _usosMaximo;
        }

        public void ImprimirHabilidade()
        {
            ConsoleColor aux = Console.ForegroundColor;

            Console.Write($"{Nome} | Custo de Mana: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{CustoDeMana} ");

            Console.ForegroundColor = aux;
            Console.Write($"| Usos Disponíveis: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{QuantidadeDeUsos} ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"          {Descricao}");

            Console.ForegroundColor = aux;

        }


    }
}
