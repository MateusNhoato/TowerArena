using Delegates;
using Enums;
using Services;

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
            Habilidade habilidade = new Habilidade("Estreia do Astro", 8, 10, descricao, EfeitosDeHabilidades.EstreiaDoAstro, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladino passa a perna em seu oponente, debilitando todos os status dele\n          enquanto pega as quantidades correspondentes dos atributos para si mesmo.";
            habilidade = new Habilidade("Rasteira", 15, 4, descricao, EfeitosDeHabilidades.Rasteira, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ladino assalta de 2 a 3 poções de seu oponente e as bebe.\n          Atenção: o oponente pode ou não ter poções.";
            habilidade = new Habilidade("Pilhagem Conturbada", 15, 2, descricao, EfeitosDeHabilidades.PilhagemConturbada, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Ataque que soma todos os atributos do Ladino e dão o dano equivalente diretamente na vida do inimigo (true damage).";
            habilidade = new Habilidade("Golpe Estatístico", 30, 1, descricao, EfeitosDeHabilidades.GolpeEstatistico, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Finta(Passiva):Os movimentos rápidos do Ladino enganam o oponente e, muitas vezes, até a si mesmo.\n          Estreia do Astro tem 50% de forçar seu alvo a defender-se com sua Iniciativa.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
