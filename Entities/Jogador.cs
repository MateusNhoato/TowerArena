using Classes;
using Items;

namespace Entities
{
    internal class Jogador : CriaturaBase
    {

        public int Andar { get; private set; }


        public Jogador(string nome, Classe classe) : base(nome, classe)
        {
            Nome = nome;
            Nivel = 1;
            Classe = classe;
            Mochila = new Mochila();
            Mochila.Items.Insert(0, Classe.Arma);
            Andar = 1;

            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        public Jogador(string nome, Classe classe, int nivel, int andar, int vidaAtual, int manaAtual, List<Item> items, int dinheiro) : this(nome, classe)
        {
            Nivel = nivel;
            Mochila = new Mochila(items);
            Mochila.Items.Add(Classe.Arma);
            Andar = andar;
            VidaAtual = vidaAtual;
            ManaAtual = manaAtual;
            Mochila.AlterarDinheiro(dinheiro);
        }

        public void SubirAndar()
        {
            Andar++;
            LevelUp();
        }

        public void LevelUp()
        {
            Nivel++;
            if (Nivel == 11)
                EscolhaDeSubClasse();

            for (int i = 0; i < Classe.Habilidades.Count; i++)
            {
                Classe.Habilidades[i].ResetarUsos();
            }
        }
        private void MudarClasse(Classe classe)
        {
            Classe = classe;

        }
        private void EscolhaDeSubClasse()
        {
            MudarClasse(Classe.MostrarSubclasses());
        }

        public void RegeneracaoPosCombate()
        {
            VidaAtual += ForcaTotal;
            ManaAtual += IntelectoTotal / 2;

            if (VidaAtual > VidaTotal)
                VidaAtual = VidaTotal;
            if (ManaAtual > ManaTotal)
                ManaAtual = ManaTotal;
        }


        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Jogador))
                return false;

            Jogador outro = obj as Jogador;
            return Nome.Equals(outro.Nome);
        }
    }
}
