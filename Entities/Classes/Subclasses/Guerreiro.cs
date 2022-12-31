using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Guerreiro : Espadachim
    {
        public Guerreiro() 
        {
            Nome = "Guerreiro";
            Descricao = "";
            Arma = new EspadaLonga();
         
        }
    }
}
