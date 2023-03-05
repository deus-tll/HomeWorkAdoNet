using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList_Application.Models
{
	public class Share
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public int CountryID { get; set; }
		public Country? Country { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
	}
}
