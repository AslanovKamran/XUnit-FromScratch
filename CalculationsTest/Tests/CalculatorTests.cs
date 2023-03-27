using UnitTesting.Models;

namespace CalculationsTest.Tests
{
	public class CalculatorTests
	{
		public Calculator calc { get; init; } = new ();
		[Fact]
		public void Add_GivenInts_ReturnsInt()
		{
			
			var actual = calc.Add(2, 1);
			Assert.Equal(3, actual);
		}

		[Fact]
		public void Add_GivenDoubles_ReturnsDouble()
		{
			var actual = calc.AddDouble(1.23, 3.55);
			Assert.Equal(4.78, actual, 1);
		}

		[Fact]
		public void FiboNumbers_ShouldNotContainZero()
		{
			Assert.DoesNotContain(0, calc.FiboNumbers);
		}

		
	}
}