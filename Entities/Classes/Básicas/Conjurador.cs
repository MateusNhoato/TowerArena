using Items;

namespace Classes
{
    internal class Conjurador : Classe
    {
        public Conjurador()
        {
            Nome = "Conjurador";
            Descricao = "Uma classe que utiliza de magias para lutar. Subclasses: Mago e Feiticeiro.";
            Arma = new Varinha();
          
            VidaPorNivel = 3;
            ManaPorNivel = 8;
            PoderPorNivel = 8;
            DefesaPorNivel = 3;
            IniciativaPorNivel = 3;
        }

        public override void AdicionarHabilidades()
        {
            throw new NotImplementedException();
        }

        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Feiticeiro(), new Mago());
        }


        // habilidades





    }
}
