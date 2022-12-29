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
            base.AdicionarHabilidades();
            string descricao = "Uma flecha que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Flecha Perfurante", 4, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }
    }
}
