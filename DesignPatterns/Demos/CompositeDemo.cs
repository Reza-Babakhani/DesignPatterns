using DesignPatterns.Patterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class CompositeDemo
    {
        public static void Run()
        {
            Leaf l1 = new Leaf("l1");
            Leaf l2 = new Leaf("l2");
            Leaf l3 = new Leaf("l3");
            Leaf l4 = new Leaf("l4");


            Composite c1 = new Composite();
            Composite c2 = new Composite();

            c1.addCommponent(l1);
            c1.addCommponent(l2);

            c2.addCommponent(l3);
            c2.addCommponent(l4);


            Composite root = new Composite();

            root.addCommponent(c1);
            root.addCommponent(c2);


            root.Operation();

        }
    }
}
