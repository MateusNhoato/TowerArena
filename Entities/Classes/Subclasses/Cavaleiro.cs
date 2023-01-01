using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Cavaleiro : Guerreiro
    {

        public Cavaleiro()
        {

            Nome = "Cavaleiro";
            Descricao = "";
            Arma = new EspadaEEscudo();


        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Causa dano ao oponente baseado na defesa do Cavaleiro.";
            Habilidade habilidade = new Habilidade("Golpe De Escudo", 3, 10, descricao, EfeitosDeHabilidades.GolpeDeEscudo, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Cavaleiro aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 5, 2, descricao, EfeitosDeHabilidades.InstanciaDeDefesa, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro investe impiedosamente contra seu oponente, causando dano devastador.";
            habilidade = new Habilidade("Investida", 5, 2, descricao, EfeitosDeHabilidades.Investida, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro sacrifica 1/4 de sua Vida Máxima e dá metade do dano de sua vida Máxima diretamente na vida do oponente (true damage).\n          Cuidado! Se o Cavaleiro estiver com 50% ou menos de vida ele vai fica somente com 1 de vida após o uso desta habilidade.";
            habilidade = new Habilidade("Trocação Franca", 0, 2, descricao, EfeitosDeHabilidades.TrocacaoFranca, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }
        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Defesa É O Melhor Ataque(Passiva): Toda vez que o cavaleiro usa uma habilidade ele ganha 5 de defesa.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
