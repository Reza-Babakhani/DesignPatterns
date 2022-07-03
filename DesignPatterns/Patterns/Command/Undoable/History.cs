using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command.Undoable
{
    internal class History
    {
        private Stack<UndoableCommand> history = new();

        public void Push(UndoableCommand command)
        {
            history.Push(command);  
        }

        public UndoableCommand Pop()
        {
            return history.Pop();
        }
    }
}
