using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace C__Practice.Stack_and_Queue
{
    public class GStack <T>
    {
        private List<T> arr = new List<T>();
        private int count = 0;
        public bool isEmpty()
        {
            if(count == 0)
            {
                return true;
            }
            return false;
        }

        public T Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return arr[count - 1];
        }

        public void Push(T item)
        {
            arr.Add(item);
            count++;
        }

        public T Pop()
        {
            if(isEmpty())
            {
                throw new InvalidOperationException("Stack is already Empty!");
            }
            T TopElement = arr[count - 1];
            arr.Remove(TopElement);
            count--;
            return TopElement;
        }

        public void Display()
        {
            if (!isEmpty())
            {
                for (int i = count-1; i >= 0; i--)
                {
                    Console.Write(arr[i] + ", ");
                }
            }
        }
    }
}
