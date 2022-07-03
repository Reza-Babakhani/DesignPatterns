using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Memento
{
    internal class CareTaker
    {
        private List<Memento> mementoList = new();

        public void Push(Memento memento)
        {
            mementoList.Add(memento);
        }

        public Memento Pop()
        {

            var item = mementoList[mementoList.Count - 1];
            mementoList.RemoveAt(mementoList.Count - 1);
            return item;
        }
    }
}
