using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Models.Models
{
	[Table("Countries")]
	public class Country
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string? Name { get; set; }
	}
}
