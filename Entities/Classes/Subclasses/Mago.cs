using Items;
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
            base.AdicionarHabilidades();
        }
    }
}
