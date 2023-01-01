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
            Descricao = "";
            Arma = new DuasEspadas();
            PropriedadeEspecial = false;


            VidaPorNivel = 4;
            DefesaPorNivel = 4;
            IniciativaPorNivel=6;
            PoderPorNivel = 6;

        }

        public override void AdicionarHabilidades()
        {

            string descricao = "Golpe duplo que aplica Entalhar 2x.";
            Habilidade habilidade = new Habilidade("Retalhar", 3, 10, descricao, EfeitosDeHabilidades.Retalhar, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Espachim gasta 25% da sua vida máxima para fazer 2 turnos adicionais. " +
                "\n          Cuidado! O Espachim pode morrer com o dano desta habilidade.";
            habilidade = new Habilidade("Surto de Ação", 0, 1, descricao, EfeitosDeHabilidades.SurtoDeAcao, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Espachim ataca o oponente no seu ponto fraco criado por Entalhar." +
                "\n          Esta habilidade causa dano proporcional a armadura do oponente.";
            habilidade = new Habilidade("Ponto Fraco", 5, 3, descricao, EfeitosDeHabilidades.PontoFraco, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Sequência de 4 golpes rápidos que causam dano devastador. Entalhar é aplicado em cada golpe.";
            habilidade = new Habilidade("Vendaval", 8, 2, descricao, EfeitosDeHabilidades.Vendaval, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Entalhar(Passiva): As habilidades ofensivas do Espadachim diminuem a defesa do oponente. ");
            base.ListarHabilidadesDaClasse();
        }
    }
}
