using Delegates;
using Enums;
using Items;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Mago : Conjurador
    {
        public Mago()
        {
            Nome = "Mago";
            Descricao = "Conjurador que utiliza magias elementais para lutar.";
            Arma = new Cajado();

        
        }

        public override void AdicionarHabilidades()
        {
           
            string descricao = descricao = "";
            Habilidade habilidade = new Habilidade("Bola de Água", 4, 10, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            
            descricao = "O Mago faz uma cópia de si mesmo que irá receber o dano causado pelo oponente até se extinguir ou o combate chegar ao fim.";
            habilidade = new Habilidade("Imagem de Fogo", 6, 3, descricao, EfeitosDeHabilidades.ImagemDeFogo, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            
            descricao = "O chão treme por causa do ar? Nem o Mago soube me explicar direito para escrever a descrição da habilidade...\n          De qualquer jeito, o oponente recebe dano.";
            habilidade = new Habilidade("Terremoto de Ar", 6, 3, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            
            descricao = "";
            habilidade = new Habilidade("", 12, 4, descricao, EfeitosDeHabilidades.Ataque4x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Leve Como Pedra(Passiva): Contra um oponente com menos poder, o Mago ganha 10% de seu poder em defesa adicional.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
