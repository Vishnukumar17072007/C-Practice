using System;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.Stack_and_Queue
{
    class GQueue<T>
    {
        private List<T> arr = new List<T>();
        private int count = 0;
        public bool IsEmpty()
        {
            if(count == 0)
            {
                return true;
            }
            return false;
        }

        public void Push(T item)
        {
            arr.Add(item);
            count++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty.");
            }
            T FirstElement = arr[0];
            arr.Remove(FirstElement);
            count--;
            return FirstElement;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return arr[count - 1];
        }

        public void Display()
        {
            for(int i = 0; i<count; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
