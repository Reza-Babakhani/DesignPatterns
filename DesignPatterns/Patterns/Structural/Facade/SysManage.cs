namespace DesignPatterns.Patterns.Structural.Facade
{
	internal class SysManage
	{
		public string Step1(SubSysA a)
		{
			Console.WriteLine("Step1");

			return "abcd";
		}

		public SubSysB Step2(string s)
		{
			Console.WriteLine("Step2");
			return new SubSysB();
		}

		public void Step3(bool doThis)
		{
			Console.WriteLine("Step3");

		}

		public void Step4()
		{
			Console.WriteLine("Step4");
		}
	}
}
