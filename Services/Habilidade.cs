using Entities;
using Delegates;
using Enums;

namespace Services
{
    internal delegate void Efeito(CriaturaBase conjurador, CriaturaBase receptor);
    
    internal class Habilidade
    {
        public string Nome { get; private set; }
        public int CustoDeMana { get; private set; }
        public string Descricao { get; private set; }
        public Efeito Efeito { get; private set; }
        public TipoDeHabilidade Tipo { get; private set; }
        public int QuantidadeDeUsos { get; private set; }
        
        public Habilidade(string nome, int custoDeMana, string descricao,Efeito efeito, TipoDeHabilidade tipo)
        {
            Nome = nome;
            CustoDeMana = custoDeMana;
            Descricao = descricao;
            Efeito = efeito;
            Tipo = tipo;

                  
        }
        
        public void DiminuirUso()
        {
            QuantidadeDeUsos--;
        }

        public void ResetarUsos()
        {
            if (Tipo == TipoDeHabilidade.Buff || Tipo == TipoDeHabilidade.Debuff)
                QuantidadeDeUsos = 1;
            else
                QuantidadeDeUsos = 3;
        }


        public override string ToString()
        {
            return $"{Nome} | Custo De Mana: {CustoDeMana} | Usos Disponíveis: {QuantidadeDeUsos} | {Descricao}";
        }

    }
}
