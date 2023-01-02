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
            Habilidade habilidade = new Habilidade("Tiro Certeiro", 6, 10, descricao, EfeitosDeHabilidades.Ataque1xComLobo, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ranger recebe a benção de seu companheiro animal, aumentado a Agilidade de ambos até o fim do combate.";
            habilidade = new Habilidade("Aspecto Lupino", 9, 2, descricao, EfeitosDeHabilidades.BuffAgilidade10Porcento, TipoDeHabilidade.Buff);
            Habilidades.Add(habilidade);

            descricao = "O Ranger e seu companheiro animal lutam e morrem como um só.\n          Até o fim do combate o Ranger recebe a vida de seu Lobo como vida extra.";
            habilidade = new Habilidade("Melhor Amigo do Ranger", 15, 2, descricao, EfeitosDeHabilidades.MelhorAmigoDoRanger, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);

            descricao = "O Ranger atira 3 flechas rapidamente, seu Lobo morde o alvo três vezes";
            habilidade = new Habilidade("Pega!", 20, 2, descricao, EfeitosDeHabilidades.Pega, TipoDeHabilidade.Ataque);
            Habilidades.Add(habilidade);
        }

        public override void ListarHabilidadesDaClasse()
        {
            Console.WriteLine("     Companheiro Animal(Passiva): Toda vez que um Ranger utiliza uma habilidade ofensiva seu Lobo ataca o mesmo alvo.");
            base.ListarHabilidadesDaClasse();
        }
    }
}
