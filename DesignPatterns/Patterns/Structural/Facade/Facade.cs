namespace DesignPatterns.Patterns.Structural.Facade
{
	internal class Facade
	{
		public void doAll(SubSysA a, bool doThis)
		{
			SysManage sys = new();
			var res1 = sys.Step1(a);

			sys.Step2(res1);
			sys.Step3(doThis);
			sys.Step4();

		}
	}
}
