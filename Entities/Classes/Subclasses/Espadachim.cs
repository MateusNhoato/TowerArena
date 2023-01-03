using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Espadachim : Guerreiro
    {
        public Espadachim()
        {
            Nome = "Espadachim";
            Descricao = "Um combatente ágil que usa duas espadas para retalhar seus inimigos.";
            Arma = new DuasEspadas();
            PropriedadeEspecial = false;


            VidaPorNivel = 4;
            ManaPorNivel = 3;
            DefesaPorNivel = 3;
            AgilidadePorNivel = 4;
            ForcaPorNivel = 5;
            IntelectoPorNivel = 3;
            AtributoPrincipal = AtributoPrincipal.Hibrido;

        }

        public override void AdicionarHabilidades()
        {

            string descricao = "Golpe duplo que aplica Entalhar 2x.";
            Habilidade habilidade = new Habilidade("Retalhar", 9, 10, descricao, EfeitosDeHabilidades.Retalhar);
            Habilidades.Add(habilidade);

            descricao = "O Espachim gasta 25% da sua vida máxima para fazer 2 turnos adicionais. " +
                "\n          Cuidado! O Espachim pode morrer com o dano desta habilidade.";
            habilidade = new Habilidade("Surto de Ação", 15, 2, descricao, EfeitosDeHabilidades.SurtoDeAcao);
            Habilidades.Add(habilidade);

            descricao = "O Espachim ataca o oponente no seu ponto fraco criado por Entalhar." +
                "\n          Esta habilidade causa dano proporcional a armadura do oponente.";
            habilidade = new Habilidade("Ponto Fraco", 15, 3, descricao, EfeitosDeHabilidades.PontoFraco);
            Habilidades.Add(habilidade);

            descricao = "Sequência de 4 golpes rápidos que causam dano devastador. Entalhar é aplicado em cada golpe.";
            habilidade = new Habilidade("Vendaval", 30, 2, descricao, EfeitosDeHabilidades.Vendaval);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Entalhar(Passiva): As habilidades ofensivas do Espadachim diminuem a defesa do oponente em 2. ");
            base.ListarHabilidadesDaClasse();
        }
    }
}
