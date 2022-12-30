
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
            Thread.Sleep( 1000 );
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
            DebuffDefesa(conjurador, receptor);
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
            int dano = receptor.ReceberDano((conjurador.PoderTotal * conjurador.PoderTotal  * 2) + conjurador.Classe.Arma.Dano);
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
            receptor.AlterarPoder(10);
        }

        public static void BuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarIniciativa(10);
        }

        public static void BuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(10);
        }
        public static void BuffVida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarVida(25);
        }

        public static void BuffPoder20Porcento(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.PoderTotal /5;

            receptor.AlterarPoder(buff);
        }

        public static void BuffDefesa20Porcento(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.DefesaTotal / 5;

            receptor.AlterarDefesa(buff);
        }

        public static void BuffIniciativa20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.IniciativaTotal / 5;

            receptor.AlterarIniciativa(buff);
        }

        public static void BuffVida20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.VidaTotal / 5;

            receptor.AlterarVida(buff);
        }

        public static void DebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(-5);
        }

        public static void DebuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        { 
            receptor.AlterarIniciativa(-5);
        }

        public static void DebuffPoder(CriaturaBase conjurador, CriaturaBase receptor)
        {           
            receptor.AlterarPoder(-5);
        }

        public static void DebuffPoderEDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa(conjurador, receptor);
            DebuffPoder(conjurador, receptor);

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
            for(int i=1; i<n; n--)
            {
                if (i >= receptor.Mochila.Items.Count)
                    break;
                Item item = receptor.Mochila.Items[i];

                conjurador.Mochila.Items.Add(item);
                receptor.Mochila.RemoverConsumivelDaMochila(item);
                if(item is PocaoVida)
                    contPocaoVida++;
                else
                    contPocaoMana++;
            }
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} roubou:\n     [{contPocaoVida}] Poções de Vida\n     [{contPocaoMana}] Poções de Mana\n     de {receptor.Nome}.");
            MenuPrincipal.AperteEnterParaContinuar();
        }
        // Guerreiro
        public static void TrocacaoFranca(CriaturaBase conjurador,CriaturaBase receptor)
        {
            int dano = conjurador.VidaTotal / 2;
            conjurador.ReceberDanoVerdadeiro(dano);
            
            if (conjurador.VidaAtual <= 0)
                conjurador.SetarVidaPara1();

            receptor.ReceberDanoVerdadeiro(dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} recebe {dano} de dano.");
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);         
        }
        // Ranger
        
        
        public static void Ataque2xRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque2x(conjurador, receptor);
            AtaqueDesarmado(conjurador, receptor);
        }

        public static void Ataque3xRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 3; i++)
            {
                Ataque1x(conjurador, receptor);
                AtaqueDesarmado(conjurador, receptor);
            }
          
        }
        public static void VidaExtraLoboRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(conjurador.VidaTotal);
            Console.WriteLine($"     Juntos somos mais fortes! {conjurador.Nome} e seu Lobo possuem {conjurador.VidaTotal} de vida.");

        }
            
        #endregion

    }
}
