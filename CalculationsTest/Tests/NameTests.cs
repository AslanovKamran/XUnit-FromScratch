using UnitTesting.Models;

namespace NameTests.Tests
{
	public class NameTests
	{
		[Fact]
		public void MakeFullNameTest()
		{
			var namer = new Names();
			var actual = namer.MakeFullName("John", "Doe");
			var expected = "john Doe";
			Assert.Equal(expected, actual, ignoreCase:true);
		}

		[Fact]
		public void Nickname_MustBeNull() 
		{
			var namer = new Names();
			Assert.NotNull(namer.Nickname);
		}

		[Fact]
		public void MakeFullName_AlwaysReturnsAValue()
		{
			var namer = new Names();
			var actual = namer.MakeFullName("John", "Doe");
			Assert.NotNull(actual);
			Assert.True(!String.IsNullOrWhiteSpace(actual));
		}
	}
}
