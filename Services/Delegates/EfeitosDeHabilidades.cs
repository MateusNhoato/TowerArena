﻿
using Entities;
using Inimigos;
using Services;
using View;
using Items;
using Menu;

namespace Delegates
{
    internal class EfeitosDeHabilidades
    {
        #region Habilidade de ataque
        public static void AtaqueDesarmado(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano(conjurador.PoderTotal * conjurador.PoderTotal);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);

        }

        public static void Ataque1x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano(conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void Ataque2x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 2) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void Ataque3x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 3) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void Ataque4x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 4) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void Ataque5x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 5) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void Ataque1xComDebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque1x(conjurador, receptor);
            BuffDefesa(conjurador, receptor);
        }

        public static void Ataque2xComDebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa10(conjurador, receptor);
            Ataque2x(conjurador, receptor);

        }

        public static void Ataque1xComLifeSteal(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int dano = receptor.ReceberDano(conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
            conjurador.AlterarVida(dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Console.WriteLine($"     {conjurador.Nome} ganha {dano} de vida.");
            Thread.Sleep(1000);

        }

        public static void Ataque2xComLifeSteal(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 2) + conjurador.Classe.Arma.Dano);
            conjurador.AlterarVida(dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Console.WriteLine($"     {conjurador.Nome} ganha {dano} de vida.");
            Thread.Sleep(1000);
        }
        #endregion
        #region Buffs e Debuffs
        public static void BuffPoder(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarPoder(10);
            Console.WriteLine($"     {conjurador.Nome} aumenta seu Poder.");
            Thread.Sleep(500);
        }

        public static void BuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarIniciativa(10);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Iniciativa.");
            Thread.Sleep(500);
        }

        public static void BuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(10);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Defesa.");
            Thread.Sleep(500);
        }
        public static void BuffVida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(25);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Vida.");
            Thread.Sleep(500);
        }

        public static void BuffPoder10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.PoderTotal / 10;
            conjurador.AlterarPoder(buff);
            Console.WriteLine($"     {conjurador.Nome} aumenta seu Poder.");
            Thread.Sleep(500);
        }

        public static void BuffDefesa10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.DefesaTotal / 5;
            conjurador.AlterarDefesa(buff);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Defesa.");
            Thread.Sleep(500);
        }

        public static void BuffIniciativa20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.IniciativaTotal / 5;

            conjurador.AlterarIniciativa(buff);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Iniciativa.");
            Thread.Sleep(500);
        }

        public static void BuffVida20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.VidaTotal / 5;

            conjurador.AlterarVida(buff);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Vida.");
            Thread.Sleep(500);
        }

        public static void DebuffDefesa5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(-5);
            Console.WriteLine($"     {receptor.Nome} teve sua Defesa reduzida.");
            Thread.Sleep(500);
        }

        public static void DebuffDefesa10(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(-10);
            Console.WriteLine($"     {receptor.Nome} teve sua Defesa reduzida.");
            Thread.Sleep(500);
        }

        public static void DebuffIniciativa5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarIniciativa(-5);
            Console.WriteLine($"     {receptor.Nome} teve sua Iniciativa reduzida.");
            Thread.Sleep(500);
        }

        public static void DebuffPoder5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarPoder(-5);
            Console.WriteLine($"     {receptor.Nome} teve seu Poder reduzido.");
            Thread.Sleep(500);
        }

        public static void DebuffPoderEDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa5(conjurador, receptor);
            DebuffPoder5(conjurador, receptor);

        }
        public static void BuffVidaEDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            BuffVida(conjurador, receptor);
            BuffDefesa(conjurador, receptor);
        }

        public static void BuffVida2xEDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            BuffVida(conjurador, receptor);
            BuffVida(conjurador, receptor);
            BuffDefesa(conjurador, receptor);
        }


        #endregion
        #region Habilidades especiais
        // arqueiro
        public static void TiroPreciso(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int dano = receptor.ReceberDanoNaIniciativa((conjurador.PoderTotal * conjurador.PoderTotal * 2) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }

        // Ladrão
        public static void Fuga(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (JogoPrincipal.Round == 10)
            {
                conjurador.AlterarMana(7);
                Combate.AcaoDoJogador(conjurador, receptor);
                return;
            }

            if (Combate.Iniciativa(conjurador, receptor))
                Combate._combate = false;

        }

        public static void Assalto(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Random random = new Random();
            int n = random.Next(2, 4);
            int contPocaoVida = 0;
            int contPocaoMana = 0;
            for (int i = 1; i < n; n--)
            {
                if (i >= receptor.Mochila.Items.Count)
                    break;
                Item item = receptor.Mochila.Items[i];

                conjurador.Mochila.Items.Add(item);
                receptor.Mochila.RemoverConsumivelDaMochila(item);
                if (item is PocaoVida)
                    contPocaoVida++;
                else
                    contPocaoMana++;
            }
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} roubou:\n     [{contPocaoVida}] Poções de Vida\n     [{contPocaoMana}] Poções de Mana\n     de {receptor.Nome}.");
            MenuPrincipal.AperteEnterParaContinuar();
        }
        // Cavaleiro
        public static void TrocacaoFranca(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int danoConjurador = conjurador.VidaTotal / 4;
            int danoReceptor = conjurador.VidaTotal / 2;
            conjurador.ReceberDanoVerdadeiro(danoConjurador);

            if (conjurador.VidaAtual <= 0)
                conjurador.SetarVidaPara1();

            receptor.ReceberDanoVerdadeiro(danoReceptor);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} recebe {danoConjurador} de dano.");
            Console.WriteLine($"     {receptor.Nome} recebe {danoReceptor} de dano.");
            Thread.Sleep(1000);
        }

        public static void GolpeDeEscudo(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(5);
            int dano = receptor.ReceberDano((conjurador.DefesaTotal * conjurador.DefesaTotal) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }

        public static void InstanciaDeDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(5);
            BuffDefesa10Porcento(conjurador, receptor);
        }
        public static void Investida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(5);
            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal * 3) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }

        // Ranger


        public static void Ataque2xRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque2x(conjurador, receptor);
            AtaqueDesarmado(conjurador, receptor);
        }

        public static void Pega(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 3; i++)
            {
                Ataque1x(conjurador, receptor);
                AtaqueDesarmado(conjurador, receptor);

                if (receptor.PorcentagemVida() <= 0)
                    break;
            }

        }
        public static void MelhorAmigoDoRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(conjurador.VidaTotal / 2);
            Console.WriteLine($"     Juntos somos mais fortes! {conjurador.Nome} e seu Lobo possuem {conjurador.VidaTotal} de Vida.");

        }
        // Ladino

        public static void PilhagemConturbado(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.Nivel - conjurador.Nivel >= 4)
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome}: Bela tentativa, mas não gosto que toquem nos meus pertences.");
                MenuPrincipal.AperteEnterParaContinuar();
                return;
            }


            Random random = new Random();
            int n = random.Next(2, 4);
            int contPocaoVida = 0;
            int contPocaoMana = 0;

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            for (int i = 1; i <= n; n--)
            {
                if (i >= receptor.Mochila.Items.Count)
                    break;
                Item item = receptor.Mochila.Items[i];

                conjurador.BeberPocao(item);
                receptor.Mochila.RemoverConsumivelDaMochila(item);
                if (item is PocaoVida)
                    contPocaoVida++;
                else
                    contPocaoMana++;
            }
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} bebeu:\n     [{contPocaoVida}] Poções de Vida\n     [{contPocaoMana}] Poções de Mana\n     de {receptor.Nome}.");
            MenuPrincipal.AperteEnterParaContinuar();
        }

        public static void Rasteira(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int iniciativa = receptor.IniciativaTotal / 5;
            int defesa = receptor.DefesaTotal / 5;
            int poder = receptor.PoderTotal / 5;

            receptor.AlterarIniciativa(iniciativa * -1);
            receptor.AlterarDefesa(defesa * -1);
            receptor.AlterarPoder(poder * -1);

            conjurador.AlterarIniciativa(iniciativa);
            conjurador.AlterarDefesa(defesa);
            conjurador.AlterarPoder(poder);

        }
        public static void GolpeEstatistico(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int dano = receptor.ReceberDanoVerdadeiro(conjurador.IniciativaTotal + conjurador.PoderTotal + conjurador.DefesaTotal);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void EstreiaDoAstro(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int n = new Random().Next(0,2);
            int dano;
            if(n == 0)
                dano = receptor.ReceberDano((conjurador.IniciativaTotal * conjurador.IniciativaTotal * 2) + conjurador.Classe.Arma.Dano);
            else
                dano = receptor.ReceberDanoNaIniciativa((conjurador.IniciativaTotal * conjurador.IniciativaTotal * 2) + conjurador.Classe.Arma.Dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        #endregion

        // Espadachim

        public static void Retalhar(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 2; i++)
            {
                receptor.AlterarDefesa(-5);
                int dano = receptor.ReceberDano(conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano);

                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                Thread.Sleep(500);
            }

        }

        public static void SurtoDeAcao(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.ReceberDanoVerdadeiro(conjurador.VidaTotal / 4);
            conjurador.Classe.Habilidades.Find(hab => hab.Nome == "Surto de Ação").DiminuirUso();

            if (conjurador.PorcentagemVida() <= 0)
                return;

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            if (conjurador is Jogador)
            {

                Combate.AcaoDoJogador(conjurador, receptor);
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                if (receptor.PorcentagemVida() <= 0)
                    return;
                Combate.AcaoDoJogador(conjurador, receptor);
            }
            else
            {
                Combate.AcaoDoInimigo(conjurador, receptor);
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                if (receptor.PorcentagemVida() <= 0)
                    return;
                Combate.AcaoDoInimigo(conjurador, receptor);
            }
        }

        public static void PontoFraco(CriaturaBase conjurador, CriaturaBase receptor)
        {

            receptor.AlterarDefesa(-5);
            int danoVerdadeiro = receptor.DefesaExtra / 5;

            if (danoVerdadeiro < 0)
                danoVerdadeiro *= -1;
            else
                danoVerdadeiro = 0;


            int dano = receptor.ReceberDanoVerdadeiro(danoVerdadeiro * 30);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(500);

        }
        public static void Vendaval(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 4; i++)
            {
                receptor.AlterarDefesa(-5);
                int dano = receptor.ReceberDano(conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                Thread.Sleep(500);
            }
        }
        // mago
        public static void ImagemDeFogo(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(conjurador.VidaTotal / 2);
            Console.WriteLine($"     {conjurador.Nome} invoca uma cópia de si mesmo.");

        }


    }
}
