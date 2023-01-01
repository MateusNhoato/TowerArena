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
    internal class Feiticeiro : Conjurador
    {
        public Feiticeiro()
        {
            Nome = "Feiticeiro";
            Descricao = "Conjurador que utiliza maldições e magias de sangue para lutar.";
            Arma = new Grimorio();

        }

        public override void AdicionarHabilidades()
        {
            // 
            string descricao = "";
            Habilidade habilidade = new Habilidade("Bola de Água", 4, 10, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            // 
            descricao = "";
            habilidade = new Habilidade("Na Mira", 5, 4, descricao, EfeitosDeHabilidades.BuffPoder10Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            // 
            descricao = "";
            habilidade = new Habilidade("Flecha Perfurante", 6, 6, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            // forma demoníaca
            descricao = "";
            habilidade = new Habilidade("Flecha da Morte", 12, 4, descricao, EfeitosDeHabilidades.Ataque5x, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Leve Como Pedra(Passiva): ");
            base.ListarHabilidadesDaClasse();
        }
    }
}
