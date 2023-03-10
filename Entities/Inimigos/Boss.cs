using Entities;
using Items;
using System;

namespace Inimigos
{
    internal class Boss : Inimigo
    {


        public Boss(int nivel, int andar) : base(nivel)
        {
            Random random = new Random();

            Nivel += 3;
            Nome = $"Chefe do Andar {andar} - " + NomeAleatorio(random.Next(1, 21985));
           
            Mochila.Items.Add(new PocaoVida());
            Mochila.Items.Add(new PocaoVida());
            Mochila.Items.Add(new PocaoMana());
            Mochila.Items.Add(new PocaoMana());

            // settando drops especiais
            for(int i=0; i<2; i++)
            {
                if(random.Next(11) <= 5)
                {
                    if (random.Next(11) <= 8)
                    {
                        Item pocao;
                        int pocaoEspecial = random.Next(0, 4);
                        if (pocaoEspecial == 0)
                            pocao = new PocaoAgilidade();
                        else if (pocaoEspecial == 1)
                            pocao = new PocaoForca();
                        else if (pocaoEspecial == 2)
                            pocao = new PocaoIntelecto();
                        else
                            pocao = new PocaoDefesa();
                        Mochila.Items.Add(pocao);
                    }
                    Mochila.AlterarDinheiro(30 + random.Next(1, 21));
                }
            }
            
            VidaAtual = VidaTotal * 3 / 2;
            ManaAtual = ManaTotal;

        }
    }
}
