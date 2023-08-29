using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class MyDictionary<T>
    {
        public Dictionary<string, T> Dictionary { get; set; }

        public void Add(string key, T value)
        {
            Dictionary.Add(key, value);
        }

        public void Remove(string key)
        {
            Dictionary.Remove(key);
        }

        public bool Contains(string key)
        {
            return Dictionary.ContainsKey(key);
        }
    }
}
