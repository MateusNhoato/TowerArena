using Delegates;
using Enums;
using Services;

namespace Classes
{
    internal class Ranger : Arqueiro
    {
        public Ranger() 
        {
            Nome = "Ranger";
            Descricao = "Especialista em sobrevivência, combate oponentes com seu Lobo.";

        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Uma flecha que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 2, descricao, EfeitosDeHabilidades.Ataque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Arqueiro se prepara durante uma rodada, aumentando seu poder pelo resto do combate.";
            habilidade = new Habilidade("Mente Afiada", 2, descricao, EfeitosDeHabilidades.BuffPoder, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Uma devastadora sucessão de flechas.";
            habilidade = new Habilidade("Saraivada de Flechas", 4, descricao, EfeitosDeHabilidades.Ataque3x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

        }

    }
}
