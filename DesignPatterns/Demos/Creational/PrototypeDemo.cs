using DesignPatterns.Patterns.Creational.Prototype;

namespace DesignPatterns.Demos.Creational
{
	internal class PrototypeDemo
	{
		public static void Run()
		{
			var obj = new ConcretePrototype("abcd");

			var copy = obj.Clone();

		}
	}
}
