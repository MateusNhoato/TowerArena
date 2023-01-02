using Delegates;
using Enums;
using Items;
using Services;

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
            string descricao = descricao = "";
            Habilidade habilidade = new Habilidade("Símbolo da Dor", 8, 10, descricao, EfeitosDeHabilidades.Ataque1EMeioX, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);


            descricao = "";
            habilidade = new Habilidade("Símbolo de Sangue", 20, 2, descricao, EfeitosDeHabilidades.ImagemDeFogo, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);


            descricao = "";
            habilidade = new Habilidade("", 20, 3, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);


            descricao = "O Feiticeiro se transforma em um demônio." +
                "\n          Além de ganhar 10 em cada atributo, todas as habilidades do feiticeiro se fortalecem.";
           // habilidade = new Habilidade("Demonificação", 70, 1, descricao, EfeitosDeHabilidades.Demonificacao, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Leve Como Pedra(Passiva): ");
            base.ListarHabilidadesDaClasse();
        }
    }
}
