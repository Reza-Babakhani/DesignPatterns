using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Observer
{
    internal class ConcreteSubject:Subject
    {
        private string value;

        public void setValue(string value)
        {
            this.value = value;
            notify();
        }

        public string getValue()
        {
            return this.value;
        }


    }
}
