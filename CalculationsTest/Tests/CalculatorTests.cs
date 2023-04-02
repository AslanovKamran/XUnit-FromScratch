using CalculationsTest.DataShare;
using CalculationsTest.Fixtures;
using System.Collections.Immutable;
using UnitTesting.Models;
using Xunit.Abstractions;

namespace CalculationsTest.Tests
{
	public class CalculatorTests : IClassFixture<CalculatorFixture>, IDisposable
	{
		private readonly CalculatorFixture _calculatorFixture;
		private readonly ITestOutputHelper _testOutputHelper;
		private readonly MemoryStream _memoryStream;
		public CalculatorTests(CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper)
		{
			_calculatorFixture = calculatorFixture;
			_testOutputHelper = testOutputHelper;
			_memoryStream = new MemoryStream();

			_testOutputHelper.WriteLine("Constructor");
		}

		[Fact]
		[Trait("Category", "Fibo")]
		public void CheckFiboNumbers()
		{

			List<int> expected = new() { 1, 1, 2, 3, 5, 8, 13 };
			Assert.Equal(expected, _calculatorFixture.Calc.FiboNumbers);

		}


		[Fact]
		[Trait("Category", "Fibo")]
		public void Add_GivenInts_ReturnsInt()
		{
			_testOutputHelper.WriteLine($"Add_GivenInts_ReturnsInt is being executed at {DateTime.Now.Hour} : {DateTime.Now.Minute}");
			var actual = _calculatorFixture.Calc.Add(2, 1);
			Assert.Equal(3, actual);
		}

		[Fact]
		[Trait("Category", "Fibo")]

		public void Add_GivenDoubles_ReturnsDouble()
		{
			var actual = _calculatorFixture.Calc.AddDouble(1.23, 3.55);
			Assert.Equal(4.78, actual, 1);
		}

		[Fact]
		[Trait("Category", "Fibo")]
		public void FiboNumbers_ShouldNotContainZero()
		{
			Assert.DoesNotContain(0, _calculatorFixture.Calc.FiboNumbers);
		}

		[Fact]
		[Trait("Category", "Fibo")]
		public void FiboNumbers_ShoulContainThirteen()
		{
			Assert.Contains(13, _calculatorFixture.Calc.FiboNumbers);
		}

		[Theory]//Written once executed n times
		[MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
		public void IsOdd_TestOddAndEven(int value, bool expected)
		{
			_testOutputHelper.WriteLine("Value to test: " + value);
			var result = _calculatorFixture.Calc.IsOdd(value);
			_testOutputHelper.WriteLine("Expected output: " + expected);
			Assert.Equal(expected, result);
		}

		//XUnit will take care of disposable objects itself
		public void Dispose()
		{
			_memoryStream.Dispose();
		}
	}
}