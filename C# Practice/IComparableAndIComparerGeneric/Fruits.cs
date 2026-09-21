using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.IComparableAndIComparerGeneric
{
    public class Fruits : IComparable<Fruits>
    {
        public string Name;
        public int Price;

        public Fruits(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Fruits other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }

    public class NameSort : IComparer<Fruits>
    {
        public int Compare(Fruits a, Fruits b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }
}
