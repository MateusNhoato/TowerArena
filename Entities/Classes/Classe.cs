﻿
using Items;
using Entities;
using Services;
using View;

namespace Classes
{
    internal abstract class Classe
    {
        
        public string? Nome { get; protected private set; }
        public string Descricao { get; protected private set; }
        public Arma? Arma { get; protected private set; }

        public  List<Habilidade> Habilidades { get; } = new List<Habilidade>();

        public int VidaPorNivel { get; protected private set; }
        public int ManaPorNivel { get; protected private set; }
        public int PoderPorNivel { get; protected private set; }
        public int DefesaPorNivel { get; protected private set; }
        public int IniciativaPorNivel { get; protected private set; }

        public abstract void AdicionarHabilidades();
        public abstract Classe MostrarSubclasses();

        public static Classe? Parse(string input)
        {
            if(string.IsNullOrEmpty(input))
                throw new ArgumentNullException("input");
           Classe classe;
            if (input == "Espadachim")
                classe = new Espadachim();
            else if (input == "Ladrão")
                classe = new Ladrao();
            else if (input == "Conjurador")
                classe = new Conjurador();
            else if (input == "Arqueiro")
                classe = new Arqueiro();
            else
                classe = null;

            return classe;
        }


        private protected static Classe OpcoesSubClasses(Classe classe1, Classe classe2)
        {
            Texto.SelecaoSubClasse();
            Console.WriteLine($"     1- {classe1}");
            Console.WriteLine($"     2- {classe2}");

            string resposta = "";
            do
            {
                if (resposta == "1" || resposta == "2")
                    break;
                Console.Write("     Digite a opção desejada: ");
                resposta = Console.ReadLine();
            } while (true);
            Classe classe;
            if (resposta == "1")
                classe =  classe1;
            else
                classe =  classe2;
            return classe;
        }
        public void ListarHabilidadesDaClasse()
        {
            int i = 1;
            for(; i <= Habilidades.Count; i++)
            {
                Console.WriteLine($"     {i}- {Habilidades[i-1]}");
            }
            Console.WriteLine($"     {i}- Voltar");
        }

        

        public override string ToString()
        {
            return $"{Nome} | Arma: {Arma.Nome} | {Descricao}";
        }

    }
}
