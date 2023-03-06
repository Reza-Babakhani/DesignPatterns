namespace DesignPatterns.Patterns.Creational.Builder
{
	internal interface IBuilder
	{
		void SetOptionA(string optionA);
		void SetOptionB(string optionB);
		void SetOptionC(string optionC);

		Product GetResult();
	}
}
