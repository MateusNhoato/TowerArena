
using Items;
using Entities;
using Delegates;
using Enums;
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
            ManaPorNivel = 4;
            PoderPorNivel = 5;
            DefesaPorNivel = 4;
            IniciativaPorNivel = 8;

            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {

            string descricao = "Apunhalada que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Golpe Visceral", 2,5, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Uma bomba que debilita o poder e a defesa do oponente.";
            habilidade = new Habilidade("Bomba de Fumaça", 3, 4,descricao, EfeitosDeHabilidades.DebuffPoderEDefesa, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladrão assalta de 2 a 3 poções de seu oponente, se disponíveis.";
            habilidade = new Habilidade("Assalto", 3, 2, descricao, EfeitosDeHabilidades.Assalto, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladrão força uma jogada nova jogada de Iniciativa contra o inimigo. \n          Se ele ganhar, ele foge e vai para o próximo round (não é possível utilizar essa habilidade no round 10).";
            habilidade = new Habilidade("Fuga", 8, 1, descricao, EfeitosDeHabilidades.Fuga, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Ladino(), new Mercenario());
        }



    }
}
