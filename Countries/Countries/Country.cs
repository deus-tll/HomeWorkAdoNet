using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
