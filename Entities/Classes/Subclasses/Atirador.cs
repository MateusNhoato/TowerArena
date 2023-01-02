using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Atirador : Arqueiro
    {
        public Atirador()
        {
            Nome = "Atirador";
            Descricao = "A elite dos Arqueiros no que se trata de maestria com o arco e flecha.";
            Arma = new ArcoEFlechaLongo();

            VidaPorNivel = 4;
            ManaPorNivel = 3;
            ForcaPorNivel = 2;
            DefesaPorNivel = 3;
            AgilidadePorNivel = 5;
            IntelectoPorNivel = 4;
            AtributoPrincipal = AtributoPrincipal.Agilidade;
        }

        public override void AdicionarHabilidades()
        {
            string descricao = descricao = "Uma devastadora sucessão de flechas.";
            Habilidade habilidade = new Habilidade("Saraivada de Flechas", 8, 10, descricao, EfeitosDeHabilidades.Ataque1EMeioX, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Pelo resto do combate o Atirador terá o oponente perfeitamente mirado. A Agilidade do Atirador aumenta.";
            habilidade = new Habilidade("Na Mira", 12, 3, descricao, EfeitosDeHabilidades.BuffAgilidade10Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Uma flechada tão rápida que o oponente só consegue se defender com sua Agilidade.";
            habilidade = new Habilidade("Tiro Preciso", 10, 4, descricao, EfeitosDeHabilidades.TiroPreciso, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "As penas pretas desta flecha são a última coisa que os oponentes do Atirador verão.";
            habilidade = new Habilidade("Flecha da Morte", 22, 2, descricao, EfeitosDeHabilidades.Ataque2EMeioX, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     O Primeiro Tiro é o Mais Letal(Passiva): Se o Atirador ganha na iniciativa, ele ganha 10% de poder pelo resto do combate.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
