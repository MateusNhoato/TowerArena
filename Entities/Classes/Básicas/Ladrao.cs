
using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Ladrao : Classe
    {
        public Ladrao()
        {
            Nome = "Ladrão";
            Descricao = "Uma classe que utiliza de truques e tramoias para sobreviver | Subclasses: Mercenário e Ladino.";
            Arma = new Adaga();

            VidaPorNivel = 4;
            ManaPorNivel = 3;
            IntelectoPorNivel = 3;
            ForcaPorNivel = 3;
            DefesaPorNivel = 3;
            AgilidadePorNivel = 5;

            AtributoPrincipal = AtributoPrincipal.Agilidade;

            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {

            string descricao = "Apunhalada que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Golpe Visceral", 3, 5, descricao, EfeitosDeHabilidades.Ataque2x);
            Habilidades.Add(habilidade);

            descricao = "Uma bomba que debilita o poder e a defesa do oponente.";
            habilidade = new Habilidade("Bomba de Fumaça", 3, 4, descricao, EfeitosDeHabilidades.DebuffDefesa2EDebuffStatusPrincipal2);
            Habilidades.Add(habilidade);

            descricao = "O Ladrão assalta de 2 a 3 poções de seu oponente, se disponíveis.";
            habilidade = new Habilidade("Assalto", 4, 2, descricao, EfeitosDeHabilidades.Assalto);
            Habilidades.Add(habilidade);

            descricao = "O Ladrão força uma jogada nova jogada de Iniciativa contra o inimigo." +
                "\n          Se ele ganhar, ele foge e vai para o próximo round (não é possível utilizar essa habilidade no round 10).";
            habilidade = new Habilidade("Fuga", 9, 1, descricao, EfeitosDeHabilidades.Fuga);
            Habilidades.Add(habilidade);
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Ladino(), new Mercenario());
        }



    }
}
