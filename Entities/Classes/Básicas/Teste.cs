using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Teste : Classe
    {
        public Teste()
        {
            Nome = "Teste";
            Descricao = "Uma classe que utiliza de magia para lutar | Subclasses: Mago e Feiticeiro.";
            Arma = new Varinha();

            VidaPorNivel = 500;
            ManaPorNivel = 500;
            IntelectoPorNivel = 100;
            ForcaPorNivel = 100;
            DefesaPorNivel = 100;
            AgilidadePorNivel = 100;

            AtributoPrincipal = AtributoPrincipal.INTELECTO;
            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Uma onda de energia que é lançada ao oponente.";
            Habilidade habilidade = new Habilidade("Alakazam", 1, 1000, descricao, EfeitosDeHabilidades.Ataque1EMeioX);
            Habilidades.Add(habilidade);

            descricao = "Aumento o poder do Conjurador até o fim do combate.";
            habilidade = new Habilidade("Poder Ilimitado", 1, 300, descricao, EfeitosDeHabilidades.BuffIntelecto2);
            Habilidades.Add(habilidade);

            descricao = "O conjurador se protege com energia, aumentando sua defesa e ganhando vida extra até o fim do combate.";
            habilidade = new Habilidade("Barreira de Energia", 1, 200, descricao, EfeitosDeHabilidades.BuffVida15EDefesa2);
            Habilidades.Add(habilidade);

            descricao = "O Conjurador concentra uma grande quantidade de energia para realizar esse golpe devastador.";
            habilidade = new Habilidade("Explosão Primordial", 1, 300, descricao, EfeitosDeHabilidades.Ataque2EMeioX);
            Habilidades.Add(habilidade);
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Feiticeiro(), new Mago());
        }





    }
}
