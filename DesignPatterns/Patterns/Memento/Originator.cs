using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Memento
{
    internal class Originator
    {
        private string stateA;
        private string stateB;

        public void setStateA(string stateA)=>this.stateA=stateA;
        public void setStateB(string stateB) => this.stateB = stateB;

        public string getStateA() => this.stateA;
        public string getStateB() => this.stateB ;


        public Memento Save()
        {
            return new(this.stateA,this.stateB);
        }


        public void Undo(Memento state)
        {
            this.stateA = state.getStateA();
            this.stateB = state.getStateB();

        }

    }
}
