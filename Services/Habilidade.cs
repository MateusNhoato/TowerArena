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
        private int _usosMaximo;
        
        public Habilidade(string nome, int custoDeMana,int quantidadeDeUsos, string descricao,Efeito efeito, TipoDeHabilidade tipo)
        {
            Nome = nome;
            CustoDeMana = custoDeMana;
            Descricao = descricao;
            Efeito = efeito;
            Tipo = tipo;

            _usosMaximo = quantidadeDeUsos;
            QuantidadeDeUsos = quantidadeDeUsos;
                  
        }
        
        public void DiminuirUso()
        {
            QuantidadeDeUsos--;
        }

        public void ResetarUsos()
        {
            QuantidadeDeUsos = _usosMaximo;
        }


        public override string ToString()
        {
            return $"{Nome} | Custo De Mana: {CustoDeMana} | Usos Disponíveis: {QuantidadeDeUsos} | {Descricao}";
        }

    }
}
