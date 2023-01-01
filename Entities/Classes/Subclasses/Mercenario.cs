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
    internal class Mercenario : Ladrao
    {
        public Mercenario() 
        {
            Nome = "Mercenário";
            Descricao = "Combatente sanguinário que usa qualquer método para vencer.";
            Arma = new Sabre();

        
        }

        public override void AdicionarHabilidades()
        {
            string descricao = "Uma flecha que acerta o ponto vital do alvo.";
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 4, 10, descricao, EfeitosDeHabilidades.Ataque2xRanger, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ranger recebe a benção de seu companheiro animal, aumentado o poder de ambos até o fim do combate.";
            habilidade = new Habilidade("Aspecto Lupino", 5, 4, descricao, EfeitosDeHabilidades.BuffPoder10Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Ranger e seu companheiro animal lutam e morrem como um só.\n          Até o fim do combate o Ranger recebe a vida de seu Lobo como vida extra.";
            habilidade = new Habilidade("Melhor Amigo do Ranger", 30, 1, descricao, EfeitosDeHabilidades.MelhorAmigoDoRanger, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ranger atira 3 flechas rapidamente, seu Lobo morde o alvo três vezes";
            habilidade = new Habilidade("Pega!", 15, 3, descricao, EfeitosDeHabilidades.Pega, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     (Passiva): Para cada 100 de Gold em sua mochila, o Mercenário ganha 1 ponto em cada atributo.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
