using Items;
using Classes;
using Entities;
using View;

namespace Entities
{
    internal class Jogador : CriaturaBase
    {
        
        public int Andar { get; private set; }

        public List<Item> Items { get; private set; }
        
      
        public Jogador(string nome, Classe classe) : base(nome, classe) 
        {
            Nome = nome;
            Nivel = 1;
            Classe = classe;        
            Items = new List<Item> {  };
            Andar = 1;

            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        public Jogador(string nome, Classe clase,int nivel ,int andar, int vidaAtual, int manaAtual, List<Item> items) : this(nome, clase) 
        { 
            Nivel = nivel;
            Items = items;
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
            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }

       

    }
}
