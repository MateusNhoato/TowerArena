using Delegates;
using Enums;
using Items;
using Services;

namespace Classes
{
    internal class Mago : Conjurador
    {
        public Mago()
        {
            Nome = "Mago";
            Descricao = "Conjurador que utiliza magias elementais para lutar.";
            Arma = new Cajado();

            DefesaPorNivel = 3;
       
        }

        public override void AdicionarHabilidades()
        {

            string descricao = "O Mago conjura uma esfera de água e a joga no oponente.";
            Habilidade habilidade = new Habilidade("Bola de Água", 8, 20, descricao, EfeitosDeHabilidades.Ataque1EMeioX);
            Habilidades.Add(habilidade);


            descricao = "O Mago faz uma cópia de si mesmo que irá receber o dano causado pelo oponente até se extinguir ou o combate chegar ao fim.";
            habilidade = new Habilidade("Imagem de Fogo", 20, 2, descricao, EfeitosDeHabilidades.ImagemDeFogo);
            Habilidades.Add(habilidade);


            descricao = "O chão treme por causa do ar? Nem o Mago soube me explicar direito para escrever a descrição da habilidade...\n          De qualquer jeito, o oponente recebe dano.";
            habilidade = new Habilidade("Terremoto de Ar", 20, 3, descricao, EfeitosDeHabilidades.Ataque2x);
            Habilidades.Add(habilidade);


            descricao = "O Mago invoca a fúria dos céus para abater seu oponente.";
            habilidade = new Habilidade("Raios e Trovões", 50, 2, descricao, EfeitosDeHabilidades.Ataque3x);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Leve Como Pedra(Passiva): Contra um oponente com menos poder, o Mago ganha 5 de defesa.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
