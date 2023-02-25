using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Models.Models
{
	[Table("Companies")]
	public class Company
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string? Name { get; set; }

		public virtual ICollection<City> Cities { get; set; } = new HashSet<City>();
	}
}
