using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    internal class Leaf : Component
    {
        private string _name;
        public Leaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine("Operation on leaf "+_name);
        }
    }
}
