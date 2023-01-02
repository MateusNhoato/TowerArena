namespace Items
{
    abstract class Arma : Item
    {

        public abstract int Dano { get; }

        public override string ToString()
        {
            return $"     {Nome}";
        }
    }
}
