using DesignPatterns.Patterns.Behavioral.TemplateMethod;

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
