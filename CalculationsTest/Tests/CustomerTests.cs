using UnitTesting.Models;
using Xunit;

namespace CalculationsTest.Tests
{
	public class CustomerTests
	{
		[Fact]
		public void GetOrdersCountByName_NotNull()
		{
			var customer = new Customer();
			var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersCountByName(null!));
			Assert.Equal("Name can't be null or empty", exceptionDetails.Message);
		}

		[Fact]
		public void LoyalCustomerForOrdersG100()
		{
			const int LoyalCustomerDiscount = 10;
			var customer = CustomerFactory.CreateCustomer(101);
			var actual = Assert.IsType<LoyalCustomer>(customer);
			Assert.Equal(LoyalCustomerDiscount, actual.Discount);
		}

	}
}
