using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.State
{
    internal class Context
    {
        private State currentState;

        public void SetState(State state)
        {
            this.currentState = state;
        }


        public void Handle()
        {
            currentState.Handle();
        }
    }
}
