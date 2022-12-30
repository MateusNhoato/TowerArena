namespace Items
{
    abstract class Arma : Item
    {
        
        public int Dano { get; protected set; }

        public override string ToString()
        {
            return $"     {Nome} | Dano: {Dano}";
        }
    }
}
