using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList_Application.Models
{
	public class City
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public int CountryID { get; set; }
		public Country? Country { get; set; }
	}
}
