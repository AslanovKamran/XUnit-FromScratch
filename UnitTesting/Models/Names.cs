
namespace UnitTesting.Models
{
	public class Names
	{
		public string Nickname { get; set; } = string.Empty;
		public string MakeFullName(string fName, string lName) => fName + " " +  lName;
	}
}
