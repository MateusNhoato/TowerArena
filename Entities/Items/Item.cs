
using Enums;

namespace Items
{
    abstract class Item
    {
        public string? Nome { get; protected private set; }

        public string? Descricao { get; protected private set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Item)
                return false;
            Item other = obj as Item;
            return Nome.Equals(other.Nome);
        }

        public override string ToString()
        {
            return $"{Nome} {Descricao}";
        }
    }
}
