using Items;
using Classes;
using Entities;
using View;
using System.Runtime.CompilerServices;
using TowerArena.Entities;

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
            Mochila = new Mochila(new List<Item>());
            Mochila.Items.Add(Classe.Arma);
            Andar = 1;

            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        public Jogador(string nome, Classe classe,int nivel ,int andar, int vidaAtual, int manaAtual, List<Item> items) : this(nome, classe) 
        { 
            Nivel = nivel;
            Mochila = new Mochila(items);
            Mochila.Items.Add(Classe.Arma);
            Andar = andar;
            VidaAtual= vidaAtual;
            ManaAtual= manaAtual;
        }
               
        public void SubirAndar()
        {
            Andar++;
            LevelUp();
        }

        public void LevelUp()
        {
            Nivel++;
            if (Nivel == 10)
                EscolhaDeSubClasse();
            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;

            for(int i=0; i < Classe.Habilidades.Count; i++) 
            {
                Classe.Habilidades[i].ResetarUsos();
            }
            
            
        }
        private void MudarClasse(Classe classe)
        {
            Classe =  classe;

        }
        private void EscolhaDeSubClasse()
        {                           
            MudarClasse(Classe.MostrarSubclasses());
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
