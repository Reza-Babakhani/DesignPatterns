using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Mediator
{
    internal abstract class Mediator
    {
       public abstract void Change(Colleague colleague);//Anything in common
    }
}
