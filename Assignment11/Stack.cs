using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class StackQueue<T>
    {
        public Stack<T> Stack { get; set; }
        public Queue<T> Queue { get; set; }

        public void Push(T item)
        {
            Stack.Push(item);
        }

        public void Pop()
        {
            Stack.Pop();
        }

        public void DisplayAll()
        {
            foreach (var item in Stack)
            {
                Console.WriteLine(item);
            }
        }

        public void Dequeue(T item)
        {
            Queue.Enqueue(item);
        }

        public void Enqueue(T item)
        {
            Queue.Enqueue(item);
        }

        public void DisplayQueue()
        {
            foreach (var item in Queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
