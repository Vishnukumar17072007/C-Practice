using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.IComparableAndIComparerGeneric
{
    public class NameSort : IComparer<Fruits>
    {
        public int Compare(Fruits a, Fruits b)
        {
            return a.Name.CompareTo(b.Name);
        }
    }
}
