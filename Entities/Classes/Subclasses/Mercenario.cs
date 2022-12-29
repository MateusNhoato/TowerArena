using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Mercenario : Ladrao
    {
        public Mercenario() 
        {
            Nome = "Mercenário";
            Descricao = "Combatente sanguinário que usa qualquer método para vencer.";
            Arma = new Sabre();

            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {
            base.AdicionarHabilidades();
        }
    }
}
