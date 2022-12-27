using Items;
using Entities;
using Services;
using Delegates;
using Enums;

namespace Classes
{
    internal class Arqueiro : Classe
    {
        public Arqueiro()
        {
            Nome = "Arqueiro";
            Arma = new ArcoEFlecha();

            VidaPorNivel = 5;
            ManaPorNivel = 5;
            PoderPorNivel = 6;
            DefesaPorNivel = 4;
            IniciativaPorNivel = 5;

            AdicionarHabilidades();
        }

        private protected override void AdicionarHabilidades()
        {
            string descricao = "Após canalizar sua concentração, o arqueiro dispara uma poderosa flecha no ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 2, descricao, EfeitosDeHabilidades.HabilidadeAtaque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O arqueiro se prepara durante uma rodada e aumenta seu poder.";
            habilidade = new Habilidade("Mente Afiada", 3, descricao, EfeitosDeHabilidades.BuffPoder, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            
        }

       

    }
}
