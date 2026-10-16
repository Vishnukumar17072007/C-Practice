using System;
using System.Collections;
using System.Text;

namespace C__Practice.StackPractice
{
    class ToDoList
    {
        private Stack toDoList = new Stack();
        public void create(string data)
        {
            toDoList.Push(data);
        }
        public void DisplayAllTask()
        {
            while (toDoList.Count > 0)
            {
                Console.WriteLine(toDoList.Pop());
            }
        }
    }
}
