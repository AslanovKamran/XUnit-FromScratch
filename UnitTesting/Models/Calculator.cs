
namespace UnitTesting.Models
{
	public class Calculator
	{
		public readonly List<int> FiboNumbers = new() { 1, 1, 2, 3, 5, 8, 13 };
		public int Add(int a, int b) => a + b;
		public double AddDouble(double a, double b) => a + b;
	}
}
