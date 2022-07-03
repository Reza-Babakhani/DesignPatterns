using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command.Undoable
{
    internal interface UndoableCommand : Command
    {
        void UnExecute();
    }
}
