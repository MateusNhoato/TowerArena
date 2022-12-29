
using Entities;
using Inimigos;
using Services;
using View;
using Items;

namespace Delegates
{
    internal class EfeitosDeHabilidades
    {
        public static void Ataque1x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano;

            receptor.ReceberDano(dano);
        }
        public static void Ataque2x(CriaturaBase conjurador, CriaturaBase receptor)
        {
          
            int dano = (conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano) * 2;

            receptor.ReceberDano(dano);
        }
        public static void Ataque3x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = (conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano) * 3;

            receptor.ReceberDano(dano);
        }
        public static void Ataque4x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = (conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano) * 4;

            receptor.ReceberDano(dano);
        }
        public static void Ataque5x(CriaturaBase conjurador, CriaturaBase receptor)
        {

            int dano = (conjurador.PoderTotal * conjurador.PoderTotal + conjurador.Classe.Arma.Dano) * 5;

            receptor.ReceberDano(dano);
        }

        public static void BuffPoder(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.PoderTotal /5;

            receptor.AlterarPoder(buff);
        }

        public static void BuffDefesa(CriaturaBase conjurador, CriaturaBase receptor) 
        {
            int buff = receptor.DefesaTotal / 5;

            receptor.AlterarDefesa(buff);
        }

        public static void BuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.IniciativaTotal / 5;

            receptor.AlterarIniciativa(buff);
        }

        public static void BuffVida(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int buff = receptor.VidaTotal / 5;

            receptor.AlterarVida(buff);
        }

        public static void DebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.DefesaTotal / 6) * -1;

            receptor.AlterarDefesa(debuff);
        }

        public static void DebuffIniciativa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.IniciativaTotal / 6) * -1;

            receptor.AlterarIniciativa(debuff);
        }

        public static void DebuffPoder(CriaturaBase conjurador, CriaturaBase receptor)
        {
            int debuff = (receptor.PoderTotal / 6) * -1;

            receptor.AlterarPoder(debuff);
        }

        public static void DebuffPoderEDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            DebuffDefesa(conjurador, receptor);
            DebuffPoder(conjurador, receptor);

        }

        public static void Ataque1xComDebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque1x(conjurador, receptor);
            BuffDefesa(conjurador, receptor);
        }

        public static void Ataque2xComDebuffDefesa(CriaturaBase conjurador, CriaturaBase receptor)
        {
            Ataque2x(conjurador, receptor);
            BuffDefesa(conjurador, receptor);
        }

        // fuga do ladrão
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



            for(int i=1; i<n; n--)
            {
                if (i >= receptor.Mochila.Items.Count)
                    break;
                Item item = receptor.Mochila.Items[i];

                conjurador.Mochila.Items.Add(item);
                receptor.Mochila.RemoverConsumivelDaMochila(item);

            }
        }
        public static void TrocacaoFranca(CriaturaBase conjurador,CriaturaBase receptor)
        {
            int dano = conjurador.VidaTotal / 2;
            conjurador.ReceberDanoVerdadeiro(dano);
            if(conjurador.VidaAtual >=0)
            {
                int dif = (conjurador.VidaAtual * -1) + 1;
                conjurador.AlterarVida(dif);
            }


            receptor.ReceberDanoVerdadeiro(dano);
        }
    }
}
