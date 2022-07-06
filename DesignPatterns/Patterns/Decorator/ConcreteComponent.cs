using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    internal class ConcreteComponent : Component
    {
        public void Apply(string data)
        {
            Console.WriteLine("Applying normal way. data: "+data);
        }
    }
}
