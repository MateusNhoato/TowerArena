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
            string descricao = "Causa dano ao oponente e aumenta a defesa do Cavaleiro.";
            Habilidade habilidade = new Habilidade("Golpe De Escudo", 3, 10, descricao, EfeitosDeHabilidades.GolpeDeEscudo, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Cavaleiro aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 5, 2, descricao, EfeitosDeHabilidades.BuffDefesa20Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro investe impiedosamente contra seu oponente, causando dano devastador.";
            habilidade = new Habilidade("Investida", 5, 5, descricao, EfeitosDeHabilidades.Investida, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro sacrifica metade de sua vida MÁXIMA e dá o dano equivalente diretamente na vida do inimigo.\n          Cuidado! Se o Cavaleiro estiver com 50% ou menos de vida ele vai fica somente com 1 de vida após o uso desta habilidade.";
            habilidade = new Habilidade("Trocação Franca", 0, 2, descricao, EfeitosDeHabilidades.TrocacaoFranca, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }
        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Defesa É O Melhor Ataque(Passiva): As habilidades ofensivas do Cavaleiro recebem bônus de dano de sua defesa.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
