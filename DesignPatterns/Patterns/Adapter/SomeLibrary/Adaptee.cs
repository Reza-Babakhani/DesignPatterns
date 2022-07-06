using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter.SomeLibrary
{
    internal class Adaptee
    {
        public void run()
        {
            Console.WriteLine("runing external library with different signuture.");
        }
    }
}
