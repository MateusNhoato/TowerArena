using Items;
using Classes;
using Rpg_De_Console.Entities;
using View;

namespace Entities
{
    internal class Jogador : CriaturaBase
    {
        public List<Item> Items { get; private set; }

        private int _round;

        private int RoundsParaLevelUp
        {
            get { return Nivel * Nivel + 2; }
        }
        public int Round
        {
            get { return _round; }
        }
        public Jogador(string nome, Classe classe) : base(nome, classe) 
        {
            Nome = nome;
            Nivel = 1;
            Classe = classe;        
            _round= 1;
            Items = new List<Item> {  };

            VidaAtual = VidaTotal;
            ManaAtual = ManaTotal;
        }
        public Jogador(string nome, Classe clase,int nivel ,int round, int vidaAtual, int manaAtual, List<Item> items) : this(nome, clase) 
        { 
            Nivel = nivel;
            Items = items;
            _round = round;
            VidaAtual= vidaAtual;
            ManaAtual= manaAtual;
        }
        

        public void AumentarRound()
        {
            _round++;
            if(LevelUp())
            {
                Console.WriteLine(Texto.linha);
                Console.WriteLine($"\n   Você evoluiu! Nivel: {Nivel}");
            }               
        }

        private bool LevelUp()
        {
            if(_round >= RoundsParaLevelUp)
            {
                Nivel++;
                return true;
            }
            return false;
        }

       

    }
}
