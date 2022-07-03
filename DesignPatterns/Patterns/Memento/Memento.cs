using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Memento
{
    internal class Memento
    {
        private readonly string stateA;
        private readonly string stateB;

        public Memento(string stateA, string stateB)
        {
            this.stateA = stateA;
            this.stateB = stateB; 
        }

        public string getStateA() => this.stateA;

        public string getStateB() => this.stateB; 
    }
}
