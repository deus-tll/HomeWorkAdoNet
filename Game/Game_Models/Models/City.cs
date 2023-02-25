using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Models.Models
{
	[Table("Сities")]
	public class City
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string? Name { get; set; }

		[Required]
		public int CountryId { get; set; }
		public virtual Country? Country { get; set; }

		public virtual ICollection<Company> Companies { get; set; } = new HashSet<Company>();
	}
}
