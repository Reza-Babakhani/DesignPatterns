using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Decorator
{
    internal class AdditionalDecorator : Component
    {
        private Component component;

        public AdditionalDecorator(Component component)
        {
            this.component = component;
        }

        public void Apply(string data)
        {
            var modified = "++"+data + "++";
            component.Apply(modified);
        }
    }
}
