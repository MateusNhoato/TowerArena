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
            Descricao = "Um conjurador das trevas que utiliza maldições e magias de sangue para lutar.";
            Arma = new Grimorio();

        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Maldição que causa dano ao inimigo." +
                "\n          Se 'Demonificação' estiver ativa, 'Maldição da Dor' causa mais dano.";
            Habilidade habilidade = new Habilidade("Maldição da Dor", 8, 20, descricao, EfeitosDeHabilidades.MaldiçãoDaDor);
            Habilidades.Add(habilidade);


            descricao = "Maldição que causa dano ao inimigo." +
                "\n          Se 'Demonificação' estiver ativa, o Feiticeiro recupera metade do dano causado em Vida.";
            habilidade = new Habilidade("Maldição de Sangue", 14, 4, descricao, EfeitosDeHabilidades.MaldiçãoDeSangue);
            Habilidades.Add(habilidade);


            descricao = "O Feiticeiro usa seu próprio sangue para fazer uma barreira poderosa (aumenta Defesa e Vida Temporária)." +
                "\n          O Feiticeiro gasta 1/4 de sua Vida Máxima para utilizar esta habilidade." +
                "\n          Se 'Demonificação' estiver ativa, esta habilidade não gasta Vida..";
            habilidade = new Habilidade("Barreira de Sangue", 10, 3, descricao, EfeitosDeHabilidades.BarreiraDeSangue);
            Habilidades.Add(habilidade);


            descricao = "O Feiticeiro se transforma em um demônio." +
                "\n          Além de ganhar 10 em cada atributo, todas as habilidades do feiticeiro se fortalecem.";
            habilidade = new Habilidade("Demonificação", 70, 1, descricao, EfeitosDeHabilidades.Demonificacao);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("    Regeneração (Passiva): O Feiticeiro recupera 1/4 de sua Força Total em Vida no começo de seu turno.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
