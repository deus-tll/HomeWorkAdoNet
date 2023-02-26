using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Championship_Models.Models
{
	[Table("Players")]
	public class Player
	{
		[Key]
		public int ID { get; set; }

		[Required]
		[StringLength(200)]
		public string? PIB { get; set; }

		[Required]
		[StringLength(100)]
		public string? Country { get; set; }

		[Required]
		public short Number { get; set; }

		[Required]
		[StringLength(100)]
		public string? Position { get; set; }

		[AllowNull]
		public int TeamId { get; set; }
		public virtual Team? Team { get; set; }
	}
}
