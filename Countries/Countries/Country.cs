using System.Data.Linq.Mapping;

namespace Countries
{
	[Table(Name = "Countries")]
	public class Country
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int ID { get; set; }

		[Column]
		public string? Name { get; set; }

		[Column]
		public string? Capital { get; set; }

		[Column]
		public int Population { get; set; }

		[Column]
		public int Area { get; set; }

		[Column]
		public string? PartOfTheWorld { get; set; }
	}
}
