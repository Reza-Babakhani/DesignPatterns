using DesignPatterns.Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class TemplateMethodDemo
    {
        public static void Run()
        {
            ConcreteClassA a = new();
            ConcreteClassB b = new();

            a.TemplateMethod();

            b.TemplateMethod();

        }
    }
}
