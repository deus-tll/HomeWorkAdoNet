using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game_Models.Models
{
	[Table("Games")]
	public class Game
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }


		[Required]
		public DateTime ReleaseDate { get;set; }


		[Required]
		public int StyleId { get; set; }
		public virtual Style? Style { get; set; }


		[Required]
		public int CompanyId { get; set; }
		public virtual Company? Company { get; set; }


		[Required]
		[MaxLength(12)]
		public string? Mode { get; set; }


		[Required]
		public int SoldCopies { get; set; }
	}
}
