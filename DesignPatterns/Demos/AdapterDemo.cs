using DesignPatterns.Patterns.Structural.Adapter;
using DesignPatterns.Patterns.Structural.Adapter.SomeLibrary;

namespace DesignPatterns.Demos
{
	internal static class AdapterDemo
	{
		public static void Run()
		{
			Adaptee libraryClass = new Adaptee();

			Client client = new();

			client.Execute(new Adapter(libraryClass));
		}
	}
}
