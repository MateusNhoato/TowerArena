using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Ladino : Ladrao
    {
        public Ladino()
        {
            Nome = "Ladino";
            Descricao = "Furtivamente caótico.";
            

            AdicionarHabilidades();
        }

        public override void AdicionarHabilidades()
        {
            base.AdicionarHabilidades();
        }
    }
}
