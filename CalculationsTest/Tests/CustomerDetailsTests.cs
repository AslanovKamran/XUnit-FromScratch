using CalculationsTest.Fixtures;

namespace CustomerTests.Tests
{
	[Collection("Customer")]
	public class CustomerDetailsTests
	{
		private readonly CustomerFixture _customerFixture;
		public CustomerDetailsTests(CustomerFixture customerFixture)
		{
			_customerFixture = customerFixture;
		}

		[Fact]
		public void GetFullName_GivenFirstAndLastNames_ReturnsFullName() 
		{
			Assert.Equal("John Doe", _customerFixture.Customer.GetFullName("John", "Doe"));
		}
	}
}
