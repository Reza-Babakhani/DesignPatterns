using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    internal class SomethingCommand : Command
    {
        private Reciver reciver;//service

        public SomethingCommand(Reciver reciver)
        {
            this.reciver = reciver;
        }
        public void Execute()
        {
            reciver.doSomething();  
        }
    }
}
