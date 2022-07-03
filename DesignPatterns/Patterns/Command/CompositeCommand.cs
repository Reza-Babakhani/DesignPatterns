using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    internal class CompositeCommand : Command
    {
        List<Command> commands = new List<Command>();

        public void add(Command command)
        {
            commands.Add(command);

        }
        public void Execute()
        {
            foreach(Command command in commands)
            {
                command.Execute();
            }
        }
    }
}
