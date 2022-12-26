
using Items;
using Entities;

namespace Classes
{
    internal abstract class Classe
    {
        public string? Nome { get; protected private set; }
        public Arma? Arma { get; protected private set; }

        public int VidaPorNivel { get; protected private set; }
        public int ManaPorNivel { get; protected private set; }
        public int PoderPorNivel { get; protected private set; }
        public int DefesaPorNivel { get; protected private set; }
        public int IniciativaPorNivel { get; protected private set; }

        public static Classe? Parse(string input)
        {
            if(string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");
           Classe classe;
            if (input == "Espadachim")
                classe = new Espadachim();
            else if (input == "Ladrão")
                classe = new Ladrao();
            else if (input == "Conjurador")
                classe = new Conjurador();
            else if (input == "Arqueiro")
                classe = new Arqueiro();
            else
                classe = null;

            return classe;
        }
    }
}
