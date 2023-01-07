using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Mercenario : Ladrao
    {
        public Mercenario()
        {
            Nome = "Mercenário";
            Descricao = "Combatente sanguinário que usa qualquer método para vencer.";
            Arma = new Sabre();

            VidaPorNivel = 4;
            ManaPorNivel = 3;
            DefesaPorNivel = 3;
            AgilidadePorNivel = 4;
            ForcaPorNivel = 5;
            IntelectoPorNivel = 3;
            AtributoPrincipal = AtributoPrincipal.Forca;

        }

        public override void AdicionarHabilidades()
        {
            string descricao = "O Mercenário disfere um golpe contra o oponente e recupera Vida (metade do dano causado).";
            Habilidade habilidade = new Habilidade("Lâmina Sangrenta", 9, 10, descricao, EfeitosDeHabilidades.Ataque1xComLifeSteal);
            Habilidades.Add(habilidade);

            descricao = "O Mercenário assalta de 2 a 3 poções de seu oponente, se disponíveis." +
                "\n          Para cada poção assaltada, ele ganha +2 de Acerto e +1 de Força" +
                "\n          O Mercenário pode vender suas poções na loja, aumentando seu Gold.";
            habilidade = new Habilidade("Assalto Rápido", 0, 2, descricao, EfeitosDeHabilidades.Assalto);
            Habilidades.Add(habilidade);


            descricao = "O Mercenário taca uma bomba de fumaça e ataca o inimigo durante a confusão." +
                "\n          Esta habilidade diminui a Defesa e o Atributo Principal do alvo.";
            habilidade = new Habilidade("Golpe Desleal", 15, 3, descricao, EfeitosDeHabilidades.GolpeDesleal);
            Habilidades.Add(habilidade);

            descricao = "Sequência de 3 ataques de Lâmina Sagrenta.";
            habilidade = new Habilidade("Combo Sangrento", 25, 2, descricao, EfeitosDeHabilidades.ComboSangrento);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Ganância(Passiva): Para cada 100 de Gold em sua mochila, o Mercenário ganha 1 de Acerto e 1 ponto em Força.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
