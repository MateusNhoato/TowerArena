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

        public Mochila Mochila { get; private set; }
       
      
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
        public Jogador(string nome, Classe clase,int nivel ,int andar, int vidaAtual, int manaAtual, List<Item> items) : this(nome, clase) 
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
            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        
        public void BeberPocao(Item pocao)
        {
            if(pocao is PocaoVida)
            {
                VidaAtual += VidaTotal / 3;
                if(VidaAtual > VidaTotal)
                    VidaAtual = VidaTotal;
            }
            else
            {
                ManaAtual += ManaTotal / 3;
                if(ManaAtual > ManaTotal)
                    ManaAtual = ManaTotal;
            }             
            Mochila.Items.Remove(pocao);
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
