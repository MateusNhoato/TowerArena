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
            Descricao = "Um combatente resistente, especialista em lutas longas.";
            Arma = new EspadaEEscudo();

            VidaPorNivel = 6;
            ManaPorNivel = 2;
            DefesaPorNivel = 5;
            AgilidadePorNivel = 3;
            ForcaPorNivel = 3;
            IntelectoPorNivel = 2;
            AtributoPrincipal = AtributoPrincipal.FORCA;

        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Causa dano ao oponente baseado na DEFESA do Cavaleiro.";
            Habilidade habilidade = new Habilidade("Golpe De Escudo", 8, 10, descricao, EfeitosDeHabilidades.GolpeDeEscudo);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Cavaleiro aumenta sua DEFESA.";
            habilidade = new Habilidade("Instância De DEFESA", 10, 3, descricao, EfeitosDeHabilidades.InstanciaDeDefesa);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro investe impiedosamente contra seu oponente, causando dano devastador.";
            habilidade = new Habilidade("Investida", 10, 3, descricao, EfeitosDeHabilidades.Investida);
            Habilidades.Add(habilidade);

            descricao = "O Cavaleiro sacrifica 1/4 de sua Vida Máxima e causa o dano equivalente diretamente na vida do oponente (true damage).\n          Cuidado! Se o Cavaleiro estiver com 50% ou menos de vida ele vai fica somente com 1 de vida após o uso desta habilidade.";
            habilidade = new Habilidade("Trocação Franca", 20, 2, descricao, EfeitosDeHabilidades.TrocacaoFranca);
            Habilidades.Add(habilidade);
        }
        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     DEFESA É O Melhor Ataque(Passiva): Toda vez que o cavaleiro usa uma habilidade ele ganha 2 de defesa." +
                "\n          No começo de todo combate, o Caveleiro ganha de 1 a 6 de DEFESA, garantidos pelo seu escudo.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
