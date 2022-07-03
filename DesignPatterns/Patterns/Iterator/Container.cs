using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Iterator
{
    internal class Container : IEnumerator
    {
        int pos ;
        private List<string> list = new();

       
        public Container()
        {
            pos = -1;
            list.Add("foo");
            list.Add("bar");
            list.Add("baz");
            list.Add("qux");
        }

        public object Current => list[pos] ;

        public bool MoveNext()
        {
            if (list.Count > ++pos)
                return true;
            else
                return false;
        }

        public void Reset()
        {
            pos = -1;
        }


        public void Push(string value)
        {
            list.Add(value);
        }

        public string Pop()
        {
            var item= list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return item;
        }

    }
}
