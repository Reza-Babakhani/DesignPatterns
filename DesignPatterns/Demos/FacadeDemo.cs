
using DesignPatterns.Patterns.Structural.Facade;

namespace DesignPatterns.Demos
{
	internal static class FacadeDemo
	{
		public static void Run()
		{
			Facade service = new Facade();
			service.doAll(new SubSysA(), true);
		}
	}
}
