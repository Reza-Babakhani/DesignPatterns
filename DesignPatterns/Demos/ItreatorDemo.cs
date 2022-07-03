using DesignPatterns.Patterns.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class ItreatorDemo
    {
        public static void Run()
        {
            Container container = new Container();


            while (container.MoveNext())
            {
                Console.WriteLine(container.Current);
            }
            container.Pop();
            container.Reset();

            while (container.MoveNext())
            {
                Console.WriteLine(container.Current);
            }
        }
    }
}
