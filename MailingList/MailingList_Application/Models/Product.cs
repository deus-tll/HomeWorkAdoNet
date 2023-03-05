using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList_Application.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public decimal Price { get; set; }
		public int SectionID { get; set; }
		public Section? Section { get; set; }
		public int ShareID { get; set; }
		public Share? Share { get; set; }
	}
}
