using DesignPatterns.Patterns.Adapter.SomeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    internal class Adapter : Target
    {
        private Adaptee adaptee;
        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void apply()
        {
            adaptee.run();
        }
    }
}
