using Classes;
using Enums;
using Items;


namespace Entities
{
    internal abstract class CriaturaBase
    {
        public int Nivel { get; protected private set; }
        public Classe? Classe { get; protected private set; }
        public Mochila? Mochila { get; protected private set; }
        public string? Nome { get; protected private set; }

        public int VidaAtual { get; protected private set; }
        public int ManaAtual { get; protected private set; }

        public int ForcaExtra { get; private set; } = 0;
        public int DefesaExtra { get; private set; } = 0;
        public int AgilidadeExtra { get; private set; } = 0;
        public int VidaExtra { get; protected set; } = 0;
        public int IntelectoExtra { get; protected set; } = 0;

        public int EsquivaExtra { get; private set; } = 0;
        public int AcertoExtra { get; private set; } = 0;

        public CriaturaBase() { }
        public CriaturaBase(string nome, Classe classe)
        {
            Nome = nome;
            Classe = classe;

        }
        public CriaturaBase(int nivel, string nome)
        {
            Nivel = nivel;
            Nome = nome;

        }
        public CriaturaBase(int nivel, Classe? classe, string? nome, int vidaAtual, int manaAtual) : this(nivel, nome)
        {
            VidaAtual = vidaAtual;
            ManaAtual = manaAtual;
            Classe = classe;
        }


        public virtual int VidaTotal
        {
            get
            {
                return (Classe != null) ? Classe.VidaPorNivel * Classe.DefesaPorNivel * Nivel : 0;

            }
        }

        public virtual int ManaTotal
        {
            get
            {
                return (Classe != null) ?  Classe.ManaPorNivel  * Classe.IntelectoPorNivel * Nivel: 0;
            }
        }

        public int PoderTotal
        {
            get
            {
                if (Classe != null)
                {
                    if (Classe.AtributoPrincipal == AtributoPrincipal.Agilidade)
                        return AgilidadeTotal;
                    else if (Classe.AtributoPrincipal == AtributoPrincipal.Forca)
                        return ForcaTotal;
                    else if (Classe.AtributoPrincipal == AtributoPrincipal.Defesa)
                        return DefesaTotal;
                    else if (Classe.AtributoPrincipal == AtributoPrincipal.Intelecto)
                        return IntelectoTotal;
                    else
                        return (AgilidadeTotal >= ForcaTotal) ? AgilidadeTotal : ForcaTotal;
                }
                return 0;
            }

        }
        public int Esquiva
        {
            get
            {
                return AgilidadeTotal + 10 + EsquivaExtra;
            }
        }
        public int ForcaTotal
        {
            get
            {
                return (Classe != null) ? Classe.ForcaPorNivel * Nivel + ForcaExtra : 0;
            }
        }
        public int Acerto
        {
            get
            {
                return (Classe != null) ? PoderTotal + new Random().Next(1, 21) + AcertoExtra: 0;
            }
        }
        public int IntelectoTotal
        {
            get
            {
                return (Classe != null) ? Classe.IntelectoPorNivel * Nivel + IntelectoExtra : 0;
            }
        }

        public int DefesaTotal
        {
            get
            {
                return (Classe != null) ? Classe.DefesaPorNivel * Nivel + DefesaExtra : 0;
            }
        }


        public int AgilidadeTotal
        {
            get
            {
                return (Classe != null) ? Classe.AgilidadePorNivel * Nivel + AgilidadeExtra : 0;
            }
        }

        public double PorcentagemVida()
        {
            return (double)VidaAtual / VidaTotal * 100;
        }

        public bool CheckarAcerto(int acerto)
        {
            return acerto > Esquiva;
        }


        public int ReceberDano(int dano)
        {
            int danoTotal;
            if (DefesaTotal > 0)
                danoTotal = dano - DefesaTotal;
            else
                danoTotal = dano;

            if (danoTotal > 0)
            {
                VidaAtual -= danoTotal;
            }
            return danoTotal;
        }

        public int ReceberDanoVerdadeiro(int dano)
        {
            VidaAtual -= dano;
            return dano;
        }
        public int ReceberDanoNaAgilidade(int dano)
        {
            int danoTotal;

            if (AgilidadeTotal > 0)
                danoTotal = dano - AgilidadeTotal;
            else
                danoTotal = dano;

            if (danoTotal > 0)
            {
                VidaAtual -= danoTotal;
            }
            return danoTotal;
        }
        public int ReceberDanoNoIntelecto(int dano)
        {
            int danoTotal;

            if (AgilidadeTotal > 0)
                danoTotal = dano - IntelectoTotal;
            else
                danoTotal = dano;

            if (danoTotal > 0)
            {
                VidaAtual -= danoTotal;
            }
            return danoTotal;
        }
        public int ReceberDanoNaForca(int dano)
        {
            int danoTotal;

            if (AgilidadeTotal > 0)
                danoTotal = dano - ForcaTotal;
            else
                danoTotal = dano;

            if (danoTotal > 0)
            {
                VidaAtual -= danoTotal;
            }
            return danoTotal;
        }
        public void SetarVidaPara1()
        {
            VidaAtual = 1;
        }

        public bool CheckarMana(int custoDeMana)
        {
            if (ManaAtual >= custoDeMana)
            {
                ManaAtual -= custoDeMana;
                return true;
            }
            return false;
        }

        public void AlterarDefesa(int quantia)
        {
            DefesaExtra += quantia;
        }

        public void AlterarForca(int quantia)
        {
            ForcaExtra += quantia;
        }

        public void AlterarAgilidade(int quantia)
        {
            AgilidadeExtra += quantia;
        }

        public void AlterarIntelecto(int quantia)
        {
            IntelectoExtra += quantia;
        }

        public void AlterarVida(int quantia)
        {
            VidaExtra += quantia;
            VidaAtual += VidaExtra;
        }
        public void AlterarMana(int quantia)
        {
            ManaAtual += quantia;
            if (ManaAtual > ManaTotal)
                ManaAtual = ManaTotal;
        }

        public void AlterarAcerto(int quantia)
        {
            AcertoExtra += quantia;
        }
        public void AlterarEsquiva(int quantia)
        {
            EsquivaExtra += quantia;
        }

        public void ZerarAtributosExtras()
        {
            AgilidadeExtra = 0;
            ForcaExtra = 0;
            DefesaExtra = 0;
            IntelectoExtra= 0;
            AcertoExtra = 0;
            EsquivaExtra = 0;

            VidaAtual -= VidaExtra;
            VidaExtra = 0;
            if (VidaAtual <= 0)
                VidaAtual = 1;
        }

        public void BeberPocao(Item pocao)
        {
            if (pocao is PocaoVida)
            {
                VidaAtual += VidaTotal / 3;
                if (VidaAtual > VidaTotal)
                    VidaAtual = VidaTotal;
            }
            else if (pocao is PocaoMana)
            {
                ManaAtual += ManaTotal / 3;
                if (ManaAtual > ManaTotal)
                    ManaAtual = ManaTotal;
            }
            else
            {
                if (pocao is PocaoAgilidade)
                    AgilidadeExtra += 20;

                else if (pocao is PocaoForca)
                    ForcaExtra += 20;

                else if (pocao is PocaoIntelecto)
                    IntelectoExtra += 20;
                else
                    DefesaExtra += 20;
            }

            Mochila.Items.Remove(pocao);
            Console.WriteLine($"     {Nome} bebeu uma {pocao.Nome}.");
        }

        public override string ToString()
        {
            return $"{Nome} ({Classe.Nome}) | Nv: {Nivel}";
        }
    }
}
