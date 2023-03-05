using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList_Application.Models
{
	public class Section
	{
		public int ID { get; set; }
		public string? Name { get; set; }

		public ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
	}
}
