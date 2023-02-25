using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Models.Models
{
	[Table("Styles")]
	public class Style
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }
	}
}
