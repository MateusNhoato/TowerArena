﻿using Classes;
using Items;
using Services;
using System.Collections.Specialized;

namespace Entities
{
    internal abstract class CriaturaBase
    {
        public int Nivel { get; protected private set; }
        public Classe? Classe { get; protected private set; }
        public Mochila? Mochila { get; protected private set; }
        public string? Nome { get; protected private set; }


        public int VidaBase { get; protected private set; } = 50;
        public int ManaBase { get; protected private set; } = 20;
        public int PoderBase { get; protected private set; } = 3;
        public int DefesaBase { get; protected private set; } = 3;
        public int IniciativaBase { get; protected private set; } = 3;

        public int VidaAtual { get; protected private set; }
        public int ManaAtual { get; protected private set; }

        public int PoderExtra { get; private set; } = 0;
        public int DefesaExtra { get; private set; } = 0;
        public int IniciativaExtra { get; private set; } = 0;
        public int VidaExtra { get; protected set; } = 0;

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
        public CriaturaBase(int nivel, Classe? classe, string? nome, int vidaBase, int manaBase, int poderBase, int defesaBase, int iniciativaBase, int vidaAtual, int manaAtual) : this(nivel, nome, vidaBase, manaBase, poderBase, defesaBase, iniciativaBase)
        {
            Nome = nome;
            VidaAtual = vidaAtual;
            ManaAtual = manaAtual;
        }


        public int VidaTotal
        {
            get
            {
                if (Classe != null)
                {
                    if(Nivel < 10)
                        return VidaBase + Classe.VidaPorNivel * Nivel + VidaExtra;
                    return VidaBase + Classe.VidaPorNivel * Nivel * 5 + VidaExtra;
                }
                    
                return VidaBase;
            }
        }

        public int ManaTotal
        {
            get
            {
                if (Classe != null)
                    return ManaBase + Classe.ManaPorNivel * Nivel;
                return ManaBase;
            }
        }

        public int PoderTotal
        {
            get
            {
                if (Classe != null)
                    return PoderBase + Classe.PoderPorNivel * Nivel + PoderExtra;
                return PoderBase;
            }
        }

        public int DefesaTotal
        {
            get
            {
                if (Classe != null)
                {
                    if(Nivel < 10)
                    {
                        int aux = DefesaBase + Classe.DefesaPorNivel * Nivel + DefesaExtra;
                        if(aux > 0)
                        return (aux > 0) ? aux : 1; 
                    }
                    int total = DefesaBase + Classe.DefesaPorNivel * Nivel * 2 + DefesaExtra;
                    return (total > 0) ? total : 1;
                }
                return DefesaBase;
            }
        }

        public int IniciativaTotal
        {
            get
            {
                if (Classe != null)
                    return IniciativaBase + Classe.IniciativaPorNivel * Nivel + IniciativaExtra;
                return IniciativaBase;
            }
        }

        public double PorcentagemVida()
        {
            return (double)VidaAtual / VidaTotal * 100;
        }
        

        public int ReceberDano(int dano)
        {
            int danoTotal = dano / DefesaTotal;
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
        public int ReceberDanoNaIniciativa(int dano)
        {
            int danoTotal = dano / IniciativaTotal;
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

        public void AlterarPoder(int quantia)
        {
            PoderExtra += quantia;
        }

        public void AlterarIniciativa(int quantia)
        {
            IniciativaExtra += quantia;
        }

        public void AlterarVida(int quantia)
        {
            VidaExtra += quantia;
            VidaAtual+= VidaExtra;            
        }
        public void AlterarMana(int quantia)
        {
            ManaAtual += quantia;
            if (ManaAtual > ManaTotal)
                ManaAtual = ManaTotal;
        }
        public void ZerarAtributosExtras()
        {
            IniciativaExtra = 0;
            PoderExtra = 0;
            DefesaExtra = 0;
            VidaAtual -= VidaExtra;
            VidaExtra = 0;           
        }

        public void BeberPocao(Item pocao)
        {
            if (pocao is PocaoVida)
            {
                VidaAtual += VidaTotal / 3;
                if (VidaAtual > VidaTotal)
                    VidaAtual = VidaTotal;
            }
            else
            {
                ManaAtual += ManaTotal / 3;
                if (ManaAtual > ManaTotal)
                    ManaAtual = ManaTotal;
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
