
using Delegates;
using Enums;
using Items;
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

            VidaPorNivel = 5;
            ManaPorNivel = 2;
            IntelectoPorNivel = 3;
            ForcaPorNivel = 5;
            DefesaPorNivel = 4;
            AgilidadePorNivel = 3;
            AtributoPrincipal = AtributoPrincipal.FORCA;

            AdicionarHabilidades();

        }

        public override void AdicionarHabilidades()
        {

            string descricao = "O Guerreiro investe contra seu alvo e ataca duas vezes rapidamente.";
            Habilidade habilidade = new Habilidade("Golpe Duplo", 2, 10, descricao, EfeitosDeHabilidades.Ataque1EMeioX);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Guerreiro aumenta sua DEFESA.";
            habilidade = new Habilidade("Instância De DEFESA", 2, 4, descricao, EfeitosDeHabilidades.BuffDefesa2);
            Habilidades.Add(habilidade);

            descricao = "Golpe que causa dano e atordoa o alvo, diminuindo sua DEFESA.";
            habilidade = new Habilidade("Golpe Debilitante", 4, 3, descricao, EfeitosDeHabilidades.Ataque1EMeioXComDebuffDefesa2);
            Habilidades.Add(habilidade);

            descricao = "Sequência de golpes rápidos que causam dano devastador.";
            habilidade = new Habilidade("Combo Triplo", 6, 2, descricao, EfeitosDeHabilidades.Ataque2x);
            Habilidades.Add(habilidade);

        }
        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     O primeiro que apanha, o último que ri (Passiva): Se o guerreiro perder a Iniciativa\n" +
                "          ele ganha 2 de Acerto e 1 de Força pelo resto do Round.");
            base.ListarHabilidadesDaClasse();
        }
        public override Classe MostrarSubclasses()
        {
            return OpcoesSubClasses(new Espadachim(), new Cavaleiro());
        }


    }
}
