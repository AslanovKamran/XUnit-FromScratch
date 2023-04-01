using CalculationsTest.Fixtures;
using UnitTesting.Models;

namespace CustomerTests.Tests
{
	[Collection("Customer")]
	public class CustomerTests
	{
		private readonly CustomerFixture _customerFixture;
		public CustomerTests(CustomerFixture customerFixture)
		{
			_customerFixture = customerFixture;
		}
		[Fact]
		public void GetOrdersCountByName_NotNull()
		{
			
			var exceptionDetails = Assert.Throws<ArgumentException>(() => _customerFixture.Customer.GetOrdersCountByName(null!));
			Assert.Equal("Name can't be null or empty", exceptionDetails.Message);
		}

		[Fact]
		public void LoyalCustomerForOrdersG100()
		{
			const int LoyalCustomerDiscount = 10;

			var actual = Assert.IsType<LoyalCustomer>(CustomerFactory.CreateCustomer(101));
			Assert.Equal(LoyalCustomerDiscount, actual.Discount);
		}

	}
}
