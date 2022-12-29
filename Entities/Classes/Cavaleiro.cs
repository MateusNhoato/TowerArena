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
            Arma = new EspadaEEscudo();

            VidaPorNivel = 8;
            ManaPorNivel = 3;
            PoderPorNivel = 5;
            DefesaPorNivel = 6;
            IniciativaPorNivel = 3;

            AdicionarHabilidades();
        }

        private protected override void AdicionarHabilidades()
        {
            string descricao = "O Espachim investe contra seu alvo e ataca duas vezes rapidamente.";
            Habilidade habilidade = new Habilidade("Golpe De Escudo", 2, descricao, EfeitosDeHabilidades.Ataque1xComDebuffDefesa, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Cavaleiro aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 3, descricao, EfeitosDeHabilidades.BuffDefesa, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Golpe que atordoa o alvo, diminuindo sua defesa.";
            habilidade = new Habilidade("Golpe Debilitante", 3, descricao, EfeitosDeHabilidades.DebuffDefesa, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }

    }
}
