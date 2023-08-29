using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Linked_List<T>
    {
        public LinkedList<T> List { get; set; }

        public void AddFirst(T value)
        {
            List.AddFirst(value);
        }

        public void AddLast(T value)
        {
            List.AddLast(value);
        }

        public void Clear()
        {
            List.Clear();
        }
    }
}
