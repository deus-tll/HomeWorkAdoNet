using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList_Application.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Patronymic { get; set; }
		public DateTime Birth { get; set; }
		public string? Gender { get; set; }
		public string? Email { get; set; }
		public int CityID { get; set; }
		public City? City { get; set; }

		public ICollection<Section> Sections { get; set; } = new HashSet<Section>();
	}
}
