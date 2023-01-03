using Delegates;
using Enums;
using Items;
using Services;


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
            AgilidadePorNivel = 5;
            IntelectoPorNivel = 3;
            AtributoPrincipal = AtributoPrincipal.Hibrido;
            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Uma flecha que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 3, 10, descricao, EfeitosDeHabilidades.Ataque2x);
            Habilidades.Add(habilidade);

            descricao = "O Arqueiro se prepara durante uma rodada, aumentando seu poder pelo resto do combate.";
            habilidade = new Habilidade("Mente Afiada", 3, 4, descricao, EfeitosDeHabilidades.BuffAgilidade5);
            Habilidades.Add(habilidade);

            descricao = "Uma flechada tão rápida que o oponente só  consegue desviar com sua iniciativa.";
            habilidade = new Habilidade("Tiro Preciso", 5, 3, descricao, EfeitosDeHabilidades.TiroPreciso);
            Habilidades.Add(habilidade);

            descricao = "Uma devastadora sucessão de flechas.";
            habilidade = new Habilidade("Saraivada de Flechas", 9, 3, descricao, EfeitosDeHabilidades.Ataque2EMeioX);
            Habilidades.Add(habilidade);
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Ranger(), new Atirador());
        }
    }
}
