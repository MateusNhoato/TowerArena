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
    internal class Ladino : Ladrao
    {
        public Ladino()
        {
            Nome = "Ladino";
            Descricao = "Furtivamente caótico.";
           
        }

        public override void AdicionarHabilidades()
        {
            string descricao = "O primeiro que ataca é quem ganha - Ladino, usando sua iniciativa para atacar.";
            Habilidade habilidade = new Habilidade("Estreia do Astro", 4, 10,descricao, EfeitosDeHabilidades.EstreiaDoAstro, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladino passa a perna em seu oponente, debilitando todos os status dele\n          enquanto pega as quantidades correspondentes dos atributos para si mesmo.";
            habilidade = new Habilidade("Rasteira", 6, 5, descricao, EfeitosDeHabilidades.Rasteira, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladino assalta de 2 a 3 poções de seu oponente e as bebe.\n          Atenção: o oponente pode ou não ter poções.";
            habilidade = new Habilidade("Pilhagem Conturbada", 10, 3, descricao, EfeitosDeHabilidades.PilhagemConturbado, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladino ataca usando todos seus status.";
            habilidade = new Habilidade("Golpe Estatístico", 25, 2, descricao, EfeitosDeHabilidades.GolpeEstatistico, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }
    }
}
