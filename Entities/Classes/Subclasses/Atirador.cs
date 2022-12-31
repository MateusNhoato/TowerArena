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

        }

        public override void AdicionarHabilidades()
        {
            string descricao = descricao = "Uma devastadora sucessão de flechas.";
            Habilidade habilidade = new Habilidade("Saraivada de Flechas", 4, 10, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Pelo resto do combate o Atirador terá o oponente perfeitamente mirado. O dano do Atirador aumenta.";
            habilidade = new Habilidade("Na Mira", 5, 4, descricao, EfeitosDeHabilidades.BuffPoder20Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Uma flecha que acerta o ponto vital do alvo.";
            habilidade = new Habilidade("Flecha Perfurante", 6, 6, descricao, EfeitosDeHabilidades.Ataque4x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "As penas pretas desta flecha são a última coisa que os oponentes do Atirador verão.";
            habilidade = new Habilidade("Flecha da Morte",12, 4, descricao, EfeitosDeHabilidades.Ataque5x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     O Primeiro Tiro é o Mais Letal(Passiva): Se o Atirador ganha na iniciativa, ele ganha 10% de poder pelo resto do combate.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
