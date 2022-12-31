
using Items;
using Entities;
using Delegates;
using Enums;
using Services;

namespace Classes
{
    internal class Guerreiro : Classe
    {
        
        public Guerreiro()
        {
            Nome = "Guerreiro";
            Descricao = "Uma classe que se garante no combate corpo a corpo | Subclasses: Espachim e Cavaleiro.";
            Arma = new EspadaCurta();

            VidaPorNivel = 7;
            ManaPorNivel = 4;
            PoderPorNivel = 5;
            DefesaPorNivel = 5;
            IniciativaPorNivel = 4;

            AdicionarHabilidades();

        }

        public override void AdicionarHabilidades()
        {
            
            string descricao = "O Guerreiro investe contra seu alvo e ataca duas vezes rapidamente.";
            Habilidade habilidade = new Habilidade("Golpe Duplo", 2, 5, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Guerreiro aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 3, 2, descricao, EfeitosDeHabilidades.BuffDefesa, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Golpe que atordoa o alvo diminuindo sua defesa.";
            habilidade = new Habilidade("Golpe Debilitante", 3, 2, descricao, EfeitosDeHabilidades.DebuffDefesa5, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);

            descricao = "Sequência de golpes rápidos que causam dano devastador.";
            habilidade = new Habilidade("Combo Triplo", 4, 3, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }

        public override Classe MostrarSubclasses()
        {
           return OpcoesSubClasses(new Espadachim(), new Cavaleiro());
        }


    }
}
