
using Items;

using Entities;
using Delegates;
using Enums;
using Services;

namespace Classes
{
    internal class Espadachim : Classe
    {
        
        public Espadachim() 
        {
            Nome = "Espadachim";
            Arma = new EspadaCurta();
          
            VidaPorNivel = 8;
            ManaPorNivel= 3;
            PoderPorNivel = 5;
            DefesaPorNivel = 6;
            IniciativaPorNivel = 3;

            AdicionarHabilidades();
        }

        private protected override void AdicionarHabilidades()
        {
            string descricao = "O Espachim investe contra seu alvo e ataca duas vezes rapidamente.";
            Habilidade habilidade = new Habilidade("Golpe Duplo", 2, descricao, EfeitosDeHabilidades.HabilidadeAtaque2x, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "Concentrando-se no combate defensivo, o Espadachim aumenta sua defesa.";
            habilidade = new Habilidade("Instância De Defesa", 3, descricao, EfeitosDeHabilidades.BuffDefesa, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "Golpe que atordoa o alvo, diminuindo sua defesa.";
            habilidade = new Habilidade("Golpe Debilitante", 3, descricao, EfeitosDeHabilidades.DebuffDefesa, TipoDeHabilidade.Debuff);
            Habilidades.Add(habilidade);
        }




    }
}
