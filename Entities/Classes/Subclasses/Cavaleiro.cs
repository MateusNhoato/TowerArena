using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Cavaleiro : Espadachim
    {

        public Cavaleiro()
        {

            Nome = "Cavaleiro";
            Descricao = "";
            Arma = new EspadaEEscudo();


        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Ataque atordoante, reduz a defesa do oponente além de causar dano.";
            Habilidade habilidade = new Habilidade("Golpe De Escudo", 2, 5, descricao, EfeitosDeHabilidades.Ataque2xComDebuffDefesa, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Cavaleiro aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 3,2, descricao, EfeitosDeHabilidades.BuffDefesa, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro investe impiedosamente contra seu oponente, causando dano devastador.";
            habilidade = new Habilidade("Investida", 4, 3, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro sacrifica metade de sua vida MÁXIMA e dá o dano equivalente diretamente na vida do inimigo.\n          Cuidado! Se o Cavaleiro estiver com 50% ou menos de vida ele vai fica somente com 1 de vida após o uso desta habilidade.";
            habilidade = new Habilidade("Trocação Franca", 0, 2, descricao, EfeitosDeHabilidades.TrocacaoFranca, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

    }
}
