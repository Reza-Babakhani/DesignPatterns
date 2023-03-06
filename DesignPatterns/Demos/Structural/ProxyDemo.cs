using DesignPatterns.Patterns.Structural.Proxy;

namespace DesignPatterns.Demos.Structural
{
	internal class ProxyDemo
	{

		public static void Run()
		{
			var proxyImage = new ProxyImage("test.jpg");

			var client = new Client(proxyImage);
			client.DisplayImage();

		}
	}
}
