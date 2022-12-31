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
            // bola de água
            string descricao = descricao = "Uma devastadora sucessão de flechas.";
            Habilidade habilidade = new Habilidade("Saraivada de Flechas", 4, 10, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            // rajada de  terra
            descricao = "Pelo resto do combate o Atirador terá o oponente perfeitamente mirado. O dano do Atirador aumenta.";
            habilidade = new Habilidade("Na Mira", 5, 4, descricao, EfeitosDeHabilidades.BuffPoder20Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            // imagem de fogo
            descricao = "Uma flecha que acerta o ponto vital do alvo.";
            habilidade = new Habilidade("Flecha Perfurante", 6, 6, descricao, EfeitosDeHabilidades.Ataque4x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            //
            descricao = "As penas pretas desta flecha são a última coisa que os oponentes do Atirador verão.";
            habilidade = new Habilidade("Flecha da Morte", 12, 4, descricao, EfeitosDeHabilidades.Ataque5x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Leve Como Pedra(Passiva): ");
            base.ListarHabilidadesDaClasse();
        }
    }
}
