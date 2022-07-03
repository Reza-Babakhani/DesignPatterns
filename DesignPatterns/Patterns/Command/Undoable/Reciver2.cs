using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Command.Undoable
{
    internal class Reciver2
    {
        private string content;

        public void doSomething()
        {
            content="++"+content+"++";
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string value)
        {
            content=value;
        }
    }
}
