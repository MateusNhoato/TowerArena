using Classes;

namespace Rpg_De_Console.Entities
{
    internal abstract class CriaturaBase
    {
        public int Nivel { get; protected private set; }
        public Classe? Classe { get; protected private set;}
        public string? Nome { get; protected private set; }


        public int VidaBase { get; protected private set; } = 5;
        public int ManaBase { get; protected private set; } = 5;
        public int PoderBase { get; protected private set; } = 5;
        public int DefesaBase { get; protected private set; } = 5;
        public int IniciativaBase { get; protected private set; } = 5;

        public int VidaAtual { get; protected private set; }
        public int ManaAtual { get; protected private set; }

        public CriaturaBase() { }
        public CriaturaBase(string nome, Classe classe)
        {
            Nome = nome;
            Classe = classe;

        }
        public CriaturaBase(int nivel, string nome, int vidaBase, int manaBase, int poderBase, int defesaBase, int iniciativaBase)
        {
            Nivel = nivel;
            Nome = nome;
            VidaBase = vidaBase;
            ManaBase = manaBase;
            PoderBase = poderBase;
            DefesaBase = defesaBase;
            IniciativaBase = iniciativaBase;

        }
        public CriaturaBase(int nivel, Classe? classe, string? nome, int vidaBase, int manaBase, int poderBase, int defesaBase, int iniciativaBase, int vidaAtual, int manaAtual) : this(nivel, nome,  vidaBase,  manaBase,  poderBase,  defesaBase, iniciativaBase)
        {
            Nome = nome;           
            VidaAtual = vidaAtual;
            ManaAtual = manaAtual;
        }

       
       

        public int VidaTotal
        {
            get { 
                if(Classe != null)
                    return VidaBase + Classe.VidaPorNivel * Nivel;
                return VidaBase;
            }
        }

        public int ManaTotal
        {
            get {
                if (Classe != null)
                    return ManaBase + Classe.ManaPorNivel * Nivel;
                return ManaBase;
            }
        }

        public int PoderTotal
        {
            get {
                if (Classe != null)
                    return PoderBase + Classe.PoderPorNivel * Nivel;
                return PoderBase;
            }
        }

        public int DefesaTotal
        {
            get {
                if (Classe != null) 
                    return DefesaBase + Classe.DefesaPorNivel * Nivel;
                return DefesaBase;
            }
        }

        public int IniciativaTotal
        {
            get {
                if (Classe != null)
                    return IniciativaBase + Classe.IniciativaPorNivel * Nivel;
                return IniciativaBase;
            }
        }

        public int PorcentagemVida()
        {
            return (int)Math.Floor(Convert.ToDouble(VidaAtual / VidaTotal)) * 100;
        }


        public override string ToString()
        {
            return $"{Nome} ({Classe.Nome}) | Nv: {Nivel}";
        }
    }
}
