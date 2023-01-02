
using Enums;
using Items;
using Services;
using View;

namespace Classes
{
    internal abstract class Classe
    {

        public string? Nome { get; protected private set; }
        public string Descricao { get; protected private set; }
        public Arma? Arma { get; protected private set; }

        public AtributoPrincipal AtributoPrincipal;
        public bool? PropriedadeEspecial { get; protected private set; }
        public List<Habilidade> Habilidades { get; } = new List<Habilidade>();

        public int VidaPorNivel { get; protected private set; }
        public int ManaPorNivel { get; protected private set; }

        public int ForcaPorNivel { get; protected private set; }
        public int DefesaPorNivel { get; protected private set; }
        public int AgilidadePorNivel { get; protected private set; }
        public int IntelectoPorNivel { get; protected private set; }


        public abstract void AdicionarHabilidades();
        public abstract Classe MostrarSubclasses();

        public static Classe? Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");
            Classe classe;
            if (input == "Guerreiro")
                classe = new Guerreiro();
            else if (input == "Ladrão")
                classe = new Ladrao();
            else if (input == "Conjurador")
                classe = new Conjurador();
            else if (input == "Arqueiro")
                classe = new Arqueiro();
            else if (input == "Cavaleiro")
                classe = new Cavaleiro();
            else if (input == "Atirador")
                classe = new Atirador();
            else if (input == "Feiticeiro")
                classe = new Feiticeiro();
            else if (input == "Espadachim")
                classe = new Espadachim();
            else if (input == "Ladino")
                classe = new Ladino();
            else if (input == "Mago")
                classe = new Mago();
            else if (input == "Mercenário")
                classe = new Mercenario();
            else if (input == "Ranger")
                classe = new Ranger();
            else
                classe = null;

            return classe;
        }


        private protected static Classe OpcoesSubClasses(Classe classe1, Classe classe2)
        {
            Texto.SelecaoSubClasse();
            Console.WriteLine($"     1- {classe1}");
            Console.WriteLine($"     2- {classe2}");

            string resposta = "";
            do
            {
                if (resposta == "1" || resposta == "2")
                    break;
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (true);
            Classe classe;
            if (resposta == "1")
                classe = classe1;
            else
                classe = classe2;
            return classe;
        }
        public virtual void ListarHabilidadesDaClasse()
        {
            int i = 1;
            for (; i <= Habilidades.Count; i++)
            {
                Console.Write($"     {i}- ");
                Habilidades[i - 1].ImprimirHabilidade();
            }
            Console.WriteLine($"     {i}- Voltar");
        }

        public virtual void AlterarPropriedadeEspecial()
        {
            if (PropriedadeEspecial == true)
                PropriedadeEspecial = false;
            else
                PropriedadeEspecial = true;
        }

        public override string ToString()
        {
            return $"{Nome} | Arma: {Arma.Nome} | {Descricao}";
        }

    }
}
