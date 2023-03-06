namespace DesignPatterns.Patterns.Creational.AbstractFactory
{
	internal interface IAandBFactory
	{
		IProductA CreateA();
		IProductB CreateB();

	}
}
