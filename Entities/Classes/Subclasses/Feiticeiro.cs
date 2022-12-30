using Items;
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

            VidaPorNivel *= 5;
            DefesaPorNivel *= 2;
        }

        public override void AdicionarHabilidades()
        {
            base.AdicionarHabilidades();
        }
    }
}
