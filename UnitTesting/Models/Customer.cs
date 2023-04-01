

namespace UnitTesting.Models
{
	public class Customer
	{
		public string Name { get; set; } = String.Empty;

		public int GetOrdersCountByName(string name)
		{
			if (String.IsNullOrEmpty(name)) throw new ArgumentException("Name can't be null or empty");
			return 100;
		}

		public string GetFullName(string f, string l) => $"{f} {l}";
	}


	public class LoyalCustomer : Customer
	{
		public int Discount { get; set; } = 10;
	}

	public static class CustomerFactory
	{
		public static Customer CreateCustomer(int orderCount)
		{
			return orderCount <= 100 ? new Customer() : new LoyalCustomer();
		}
	}
}
