using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Lists
{
    class CustomList<T>
    {
        private T[] items;
        public int Count { get { return internalCount; } } 
        private int internalCount;
        private const int defaultCapacity = 4;

        public CustomList()          //Constructor
        {
            items = new T[defaultCapacity];
            internalCount = 0;
        }

        public T this[int index]
        {
            get
            {
                if( index  < 0 || index >= internalCount)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if(index<0 || index >= internalCount)
                {
                    throw new IndexOutOfRangeException();
                }
                items[index] = value;
            }
        }

        public void Resize(int capacity)
        {
            T[] newArray = new T[capacity];
            for(int i = 0; i < internalCount; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }

        public void Add(T item)
        {
            if (internalCount == items.Length)
            {
                Resize(items.Length * 2);
            }
            items[internalCount] = item;
            internalCount++;
        }

        public void RemoveAt(int n)
        {
            for (int i = n; i<internalCount-1; i++)
            {
                items[i] = items[i + 1];
            }
            internalCount--;
        }

        public void Insert(int index, T item)
        {
            if(internalCount == items.Length)
            {
                Resize(items.Length * 2);
            }
            for(int i = internalCount; i > index; i--)
            {
                items[i] = items[i-1];
            }
            items[index] = item;
            internalCount++;
        }

        public void display()
        {
            for(int i = 0; i < internalCount; i++)
            {
                Console.Write(items[i] + ", ");
            }
        }
    }
}
