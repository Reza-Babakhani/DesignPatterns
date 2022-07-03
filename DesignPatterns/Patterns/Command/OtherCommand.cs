using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command
{
    internal class OtherCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Other Command");
        }
    }
}
