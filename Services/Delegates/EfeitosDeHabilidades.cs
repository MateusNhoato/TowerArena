
using Entities;
using Enums;
using Items;
using Menu;
using Services;
using View;
using Classes;

namespace Delegates
{
    internal class EfeitosDeHabilidades
    {
        #region Habilidade de ataque
        public static void AtaqueDesarmado(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal + new Random().Next(0, 3));
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }

            Thread.Sleep(1000);

        }

        public static void AtaqueDesarmadoComDobroDeAcerto(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal + new Random().Next(0, 3));
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }

            Thread.Sleep(1000);

        }
        public static void Ataque1x(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);
        }

        public static void Ataque1xComDobroDeAcerto(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);
        }
        public static void Ataque1EMeioX(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano((conjurador.PoderTotal * 3) / 2 + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);
        }
        public static void Ataque2x(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal * 2 + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);
        }
        public static void Ataque2EMeioX(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano((conjurador.PoderTotal * 5) / 2 + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);
        }

        public static void Ataque3x(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal * 3 + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }

            Thread.Sleep(1000);
        }
        public static void Ataque1xComDebuffDefesa2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            BuffDefesa2(conjurador, receptor);
            Ataque1x(conjurador, receptor);

        }

        public static void Ataque1EMeioXComDebuffDefesa2(CriaturaBase conjurador, CriaturaBase receptor)
        {           
            Ataque1EMeioX(conjurador, receptor);
            DebuffDefesa2(conjurador, receptor);

        }

        public static void Ataque1xComLifeSteal(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano(conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                conjurador.AlterarVida(dano / 2);

                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                Console.WriteLine($"     {conjurador.Nome} ganha {dano / 2} de vida.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");

            }
            Thread.Sleep(1000);

        }

        public static void Ataque2xComLifeSteal(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano((conjurador.PoderTotal * 2) + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                conjurador.AlterarVida(dano / 2);

                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                Console.WriteLine($"     {conjurador.Nome} ganha {dano / 2} de vida.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");
            }
            Thread.Sleep(1000);
        }
        #endregion
        #region Buffs e Debuffs
        public static void BuffForca10(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarForca(10);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Força.");
            Thread.Sleep(500);
        }

        public static void BuffAgilidade2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarAgilidade(2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Agilidade.");
            Thread.Sleep(500);
        }
        public static void BuffAgilidade5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarAgilidade(5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Agilidade.");
            Thread.Sleep(500);
        }
        public static void BuffDefesa2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Defesa.");
            Thread.Sleep(500);
        }
        public static void BuffDefesa5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Defesa.");
            Thread.Sleep(500);
        }
        public static void BuffForca5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarForca(5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Força.");
            Thread.Sleep(500);
        }
        public static void BuffVida15(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(15);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Vida.");
            Thread.Sleep(500);
        }

        public static void BuffIntelecto2(CriaturaBase conjurador, CriaturaBase receptor)
        {

            conjurador.AlterarIntelecto(2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta seu Intelecto.");
            Thread.Sleep(500);
        }
        public static void BuffIntelecto5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarIntelecto(5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta seu Intelecto.");
            Thread.Sleep(500);
        }
        public static void BuffForca10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = conjurador.ForcaTotal / 10;
            conjurador.AlterarForca(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Força.");
            Thread.Sleep(500);
        }
        public static void BuffAgilidade10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = conjurador.AgilidadeTotal / 10;
            conjurador.AlterarAgilidade(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Agilidade.");
            Thread.Sleep(500);
        }
        public static void BuffIntelecto10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = conjurador.IntelectoTotal / 10;
            conjurador.AlterarIntelecto(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta seu Intelecto.");
            Thread.Sleep(500);
        }

        public static void BuffDefesa10Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = conjurador.DefesaTotal / 5;
            conjurador.AlterarDefesa(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Defesa.");
            Thread.Sleep(500);
        }

        public static void BuffAgilidade20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.AgilidadeTotal / 5;

            conjurador.AlterarAgilidade(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Agilidade.");
            Thread.Sleep(500);
        }

        public static void BuffVida20Porcento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = conjurador.VidaTotal / 5;

            conjurador.AlterarVida(buff);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} aumenta sua Vida.");
            Thread.Sleep(500);
        }

        public static void DebuffDefesa2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(-2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve sua Defesa reduzida.");
            Thread.Sleep(500);
        }
        public static void DebuffForca2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarForca(-2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve sua Força reduzida.");
            Thread.Sleep(500);
        }
        public static void DebuffAgilidade2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarAgilidade(-2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve sua Agilidade reduzida.");
            Thread.Sleep(500);
        }

        public static void DebuffIntelecto2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarIntelecto(-2);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve seu Intelecto reduzido.");
            Thread.Sleep(500);
        }

        public static void DebuffIntelecto5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarIntelecto(-5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve seu Intelecto reduzido.");
            Thread.Sleep(500);
        }
        public static void DebuffDefesa5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarDefesa(-5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve sua Defesa reduzida.");
            Thread.Sleep(500);
        }


        public static void DebuffAgilidade5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarAgilidade(-5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve sua Agilidade reduzida.");
            Thread.Sleep(500);
        }

        public static void DebuffForca5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            receptor.AlterarForca(-5);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} teve seu Intelecto reduzido.");
            Thread.Sleep(500);
        }

        public static void DebuffDefesa2EDebuffStatusPrincipal2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa2(conjurador, receptor);

            if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Agilidade)
                DebuffAgilidade2(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Forca)
                DebuffForca2(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Intelecto)
                DebuffIntelecto2(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Defesa)
                DebuffDefesa2(conjurador, receptor);
            else
                DebuffAgilidade2(conjurador, receptor);

        }
        public static void DebuffDefesa5EDebuffStatusPrincipal5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa5(conjurador, receptor);

            if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Agilidade)
                DebuffAgilidade5(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Forca)
                DebuffForca5(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Intelecto)
                DebuffIntelecto5(conjurador, receptor);
            else if (receptor.Classe.AtributoPrincipal == AtributoPrincipal.Defesa)
                DebuffDefesa5(conjurador, receptor);
            else
                DebuffAgilidade5(conjurador, receptor);

        }
        public static void BuffVida15EDefesa2(CriaturaBase conjurador, CriaturaBase receptor)
        {
            BuffVida15(conjurador, receptor);
            BuffDefesa2(conjurador, receptor);
        }

        public static void BuffVida30EDefesa5(CriaturaBase conjurador, CriaturaBase receptor)
        {
            BuffVida15(conjurador, receptor);
            BuffVida15(conjurador, receptor);
            BuffDefesa5(conjurador, receptor);
        }


        #endregion
        #region Habilidades especiais
        // arqueiro
        public static void TiroPreciso(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDanoNaAgilidade(conjurador.PoderTotal * 3 / 2 + conjurador.Classe.Arma.Dano);
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");
            }
            Thread.Sleep(1000);
        }

        // Ladrão
        public static void Fuga(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (JogoPrincipal.Round == 10)
            {
                conjurador.AlterarMana(8);
                Combate.AcaoDoJogador(conjurador, receptor);
                return;
            }

            if (Combate.Iniciativa(conjurador, receptor))
                Combate.Luta = false;

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
            if(conjurador.Classe is Ladrao)
            {
                conjurador.AlterarVida((contPocaoVida + contPocaoMana) * 2);
                conjurador.AlterarMana((contPocaoVida + contPocaoMana) * 2);
            }
            else
            {
                conjurador.AlterarAcerto((contPocaoVida + contPocaoMana) * 2);
                conjurador.AlterarForca((contPocaoVida + contPocaoMana));
            }


            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} roubou:\n     [{contPocaoVida}] Poções de Vida\n     [{contPocaoMana}] Poções de Mana\n     de {receptor.Nome}.");
            Thread.Sleep(1500);
        }
        // Cavaleiro
        public static void TrocacaoFranca(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(2);
            int dano = conjurador.VidaTotal / 4;

            conjurador.ReceberDanoVerdadeiro(dano);

            if (conjurador.VidaAtual <= 0)
                conjurador.SetarVidaPara1();

            receptor.ReceberDanoVerdadeiro(dano);

            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {conjurador.Nome} recebe {dano} de dano.");
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }

        public static void GolpeDeEscudo(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(2);
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano((conjurador.PoderTotal + conjurador.DefesaTotal + conjurador.Classe.Arma.Dano));
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");
            }
            Thread.Sleep(1000);
        }

        public static void InstanciaDeDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(2);
            BuffDefesa10Porcento(conjurador, receptor);
        }
        public static void Investida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarDefesa(2);
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                int dano = receptor.ReceberDano((conjurador.PoderTotal * 3) + conjurador.Classe.Arma.Dano);
                if (dano < 0)
                    dano = 0;
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");
            }


            Thread.Sleep(1000);
        }

        // Ranger


        public static void Ataque1xComLobo(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque1xComDobroDeAcerto(conjurador, receptor);
            AtaqueDesarmadoComDobroDeAcerto(conjurador, receptor);
        }

        public static void Pega(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 3; i++)
            {
                Ataque1xComDobroDeAcerto(conjurador, receptor);
                AtaqueDesarmadoComDobroDeAcerto(conjurador, receptor);

                if (receptor.PorcentagemVida() <= 0)
                    break;
            }

        }
        public static void MelhorAmigoDoRanger(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(conjurador.VidaTotal / 2);
            Console.WriteLine($"     Juntos somos mais fortes! {conjurador.Nome} e seu Lobo juntaram suas Vidas.");

        }
        // Ladino

        public static void PilhagemConturbada(CriaturaBase conjurador, CriaturaBase receptor)
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
            Thread.Sleep(1500);
        }

        public static void Rasteira(CriaturaBase conjurador, CriaturaBase receptor)
        {

            DebuffAgilidade5(conjurador, receptor);
            DebuffIntelecto5(conjurador, receptor);
            DebuffDefesa5(conjurador, receptor);
            DebuffForca5(conjurador, receptor);

            BuffAgilidade5(conjurador, receptor);
            BuffIntelecto5(conjurador, receptor);
            BuffDefesa5(conjurador, receptor);
            BuffForca5(conjurador, receptor);

        }
        public static void GolpeEstatistico(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int dano = receptor.ReceberDanoVerdadeiro(conjurador.AgilidadeTotal + conjurador.PoderTotal + conjurador.DefesaTotal);
            if (dano < 0)
                dano = 0;
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(1000);
        }
        public static void EstreiaDoAstro(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int n = new Random().Next(0, 2);
            int dano;
            if (receptor.CheckarAcerto(conjurador.Acerto * 2))
            {
                if (n == 0)
                    dano = receptor.ReceberDano((conjurador.AgilidadeTotal * 2) + conjurador.Classe.Arma.Dano);
                else
                    dano = receptor.ReceberDanoNaAgilidade((conjurador.AgilidadeTotal * 2) + conjurador.Classe.Arma.Dano);

                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            }
            else
            {
                CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                Console.WriteLine($"     {receptor.Nome} desviou!");
            }
            Thread.Sleep(1000);
        }

        // Mercenario
        public static void GolpeDesleal(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa5EDebuffStatusPrincipal5(conjurador, receptor);
            Ataque1EMeioX(conjurador, receptor);
        }
        public static void ComboSangrento(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 3; i++)
                Ataque1xComLifeSteal(conjurador, receptor);
        }
        // Espadachim

        public static void Retalhar(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 2; i++)
            {
                receptor.AlterarDefesa(-2);
                if (receptor.CheckarAcerto(conjurador.Acerto * 2))
                {
                    int dano = receptor.ReceberDano(conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                    if (dano < 0)
                        dano = 0;
                    CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                    Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                }

                else
                {
                    CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                    Console.WriteLine($"     {receptor.Nome} desviou!");
                }
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

            receptor.AlterarDefesa(-2);
            int danoVerdadeiro = receptor.DefesaExtra / 2;

            if (danoVerdadeiro < 0)
                danoVerdadeiro *= -1;
            else
                danoVerdadeiro = 0;


            int dano = receptor.ReceberDanoVerdadeiro(danoVerdadeiro * 10);
            CombateView.ImprimirTelaDeCombate(conjurador, receptor);
            Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
            Thread.Sleep(500);

        }
        public static void Vendaval(CriaturaBase conjurador, CriaturaBase receptor)
        {
            for (int i = 0; i < 4; i++)
            {
                if (receptor.CheckarAcerto(conjurador.Acerto * 2))
                {
                    receptor.AlterarDefesa(-2);
                    int dano = receptor.ReceberDano(conjurador.PoderTotal + conjurador.Classe.Arma.Dano);
                    if (dano < 0)
                        dano = 0;
                    CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                    Console.WriteLine($"     {receptor.Nome} recebe {dano} de dano.");
                }
                else
                {
                    CombateView.ImprimirTelaDeCombate(conjurador, receptor);
                    Console.WriteLine($"     {receptor.Nome} desviou!");
                }
                Thread.Sleep(500);
            }
        }
        // mago
        public static void ImagemDeFogo(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarVida(conjurador.VidaTotal / 4);
            Console.WriteLine($"     {conjurador.Nome} invoca uma cópia de si mesmo.");

        }

        // feiticeiro
        public static void Demonificacao(CriaturaBase conjurador, CriaturaBase receptor)
        {
            conjurador.AlterarAgilidade(10);
            conjurador.AlterarIntelecto(10);
            conjurador.AlterarDefesa(10);
            conjurador.AlterarForca(10);

            conjurador.Classe.AlterarPropriedadeEspecial();
        }
        public static void MaldiçãoDeSangue(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (conjurador.Classe.PropriedadeEspecial == true)
                Ataque2xComLifeSteal(conjurador, receptor);
            else
                Ataque2x(conjurador, receptor);

        }
        public static void MaldiçãoDaDor(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (conjurador.Classe.PropriedadeEspecial == true)
                Ataque2x(conjurador, receptor);
            else
                Ataque1EMeioX(conjurador, receptor);

        }
        public static void BarreiraDeSangue(CriaturaBase conjurador, CriaturaBase receptor)
        {
            if (conjurador.Classe.PropriedadeEspecial == false)            
                conjurador.ReceberDanoVerdadeiro(conjurador.VidaTotal / 4);

            BuffDefesa10Porcento(conjurador, receptor);
            conjurador.AlterarVida(conjurador.VidaTotal / 2);
        }
        #endregion



    }
}


