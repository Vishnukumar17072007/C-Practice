using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace C__Practice.QueuePractice
{
    class RationShopQueue
    {
        private Queue RQueue = new Queue();
        private int count = 0;
        public void addPerson()
        {
            count++;
            RQueue.Enqueue($"Person{count}");
            Console.WriteLine($"Person{count} has entered the queue.");
        }
        public void clearQueue()
        {
            while(count > 0)
            {
                Console.WriteLine(RQueue.Dequeue()+" has exit the queue.");
                count--;
            }
        }
    }
}
