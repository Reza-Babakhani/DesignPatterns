using DesignPatterns.Patterns.Adapter;
using DesignPatterns.Patterns.Adapter.SomeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class AdapterDemo
    {
        public static void Run()
        {
            Adaptee libraryClass=new Adaptee();

            Client client = new();

            client.Execute(new Adapter(libraryClass));
        }
    }
}
