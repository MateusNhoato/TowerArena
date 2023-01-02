using Items;
using Entities;
using Services;
using Delegates;
using Enums;


namespace Classes
{
    internal class Arqueiro : Classe
    {
        public Arqueiro()
        {
            Nome = "Arqueiro";
            Descricao = "Uma classe ofensiva que utiliza golpes especiais com frequência | Subclasses: Ranger e Atirador.";
            Arma = new ArcoEFlecha();


            VidaPorNivel = 4;
            ManaPorNivel = 3;
            ForcaPorNivel = 3;
            DefesaPorNivel = 3;
            AgilidadePorNivel =4;
            IntelectoPorNivel= 5;
            AtributoPrincipal = AtributoPrincipal.Hibrido;
            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {            
            string descricao = "Uma flecha que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 2,10, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Arqueiro se prepara durante uma rodada, aumentando seu poder pelo resto do combate.";
            habilidade = new Habilidade("Mente Afiada", 3, 3, descricao, EfeitosDeHabilidades.BuffAgilidade2, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Uma flechada tão rápida que o oponente só  consegue desviar com sua iniciativa.";
            habilidade = new Habilidade("Tiro Preciso", 3, 3, descricao, EfeitosDeHabilidades.TiroPreciso, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Uma devastadora sucessão de flechas.";
            habilidade = new Habilidade("Saraivada de Flechas", 5, 3, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);     
        }

        public override Classe MostrarSubclasses()
        {
           return OpcoesSubClasses(new Ranger(), new Atirador());
        }
    }
}
