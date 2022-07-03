using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command.Undoable
{
    internal class SomethingCommand2 : UndoableCommand
    {
        private string prevContent;
        private Reciver2 reciver;//service
        private History history;

        public SomethingCommand2(Reciver2 reciver, History history)
        {
            this.reciver = reciver;
            this.history = history;
        }
        public void Execute()
        {
            prevContent = reciver.getContent();
            reciver.doSomething();
            history.Push(this);
        }

        public void UnExecute()
        {
            reciver.setContent(prevContent);
        }
    }
}
