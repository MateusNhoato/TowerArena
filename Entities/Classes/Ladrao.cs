
using Items;
using Entities;
using Delegates;
using Enums;
using Services;

namespace Classes
{
    internal class Ladrao : Classe
    {
        public Ladrao()
        {
            Nome = "Ladrão";
            Arma = new Adaga();
         
            VidaPorNivel = 4;
            ManaPorNivel = 4;
            PoderPorNivel = 5;
            DefesaPorNivel = 4;
            IniciativaPorNivel = 8;

            AdicionarHabilidades();
        }

        private protected override void AdicionarHabilidades()
        {
            
            string descricao = "Apunhalada que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Golpe Visceral", 2, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "";
            habilidade = new Habilidade("", 2, descricao, EfeitosDeHabilidades.BuffPoder, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            // fuga
            descricao = "O Ladrão força uma jogada nova jogada de Iniciativa contra o inimigo. \n          Se ele ganhar, ele foge e vai para o próximo round (não é possível utilizar essa habilidade no round 10).";
            habilidade = new Habilidade("Plano de Mestre", 7, descricao, EfeitosDeHabilidades.Fuga, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }
        // habilidades




    }
}
