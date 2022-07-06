using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Composite
{
    internal class Composite : Component
    {
        private List<Component> components=new List<Component>();

        public void addCommponent(Component component)
        {
            components.Add(component);
        }

        public void Operation()
        {
            foreach(Component component in components)
            {
                component.Operation();
            }
        }
    }
}
