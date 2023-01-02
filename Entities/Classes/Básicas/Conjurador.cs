using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Conjurador : Classe
    {
        public Conjurador()
        {
            Nome = "Conjurador";
            Descricao = "Uma classe que utiliza de magia para lutar | Subclasses: Mago e Feiticeiro.";
            Arma = new Varinha();

            VidaPorNivel = 3;
            ManaPorNivel = 4;
            IntelectoPorNivel = 6;
            ForcaPorNivel = 3;
            DefesaPorNivel = 4;
            AgilidadePorNivel = 3;

            AtributoPrincipal = AtributoPrincipal.Intelecto;
            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Uma onda de energia que é lançada ao oponente.";
            Habilidade habilidade = new Habilidade("Alakazam", 4, 10, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Aumento o poder do Conjurador até o fim do combate.";
            habilidade = new Habilidade("Poder Ilimitado", 4, 3, descricao, EfeitosDeHabilidades.BuffIntelecto2, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O conjurador se protege com energia, aumentando sua defesa e ganhando vida extra até o fim do combate.";
            habilidade = new Habilidade("Barreira de Energia", 7, 2, descricao, EfeitosDeHabilidades.BuffVida15EDefesa2, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Conjurador concentra uma grande quantidade de energia para realizar esse golpe devastador.";
            habilidade = new Habilidade("Explosão Primordial", 10, 3, descricao, EfeitosDeHabilidades.Ataque2EMeioX, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Feiticeiro(), new Mago());
        }


        // habilidades





    }
}
