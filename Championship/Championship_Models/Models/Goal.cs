using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Championship_Models.Models
{
	[Table("Goals")]
	public class Goal
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int MatchId { get; set; }
		public virtual Match? Match { get; set; }

		[Required]
		public int PlayerId { get; set; }
		public virtual Player? Player { get; set; }

		[Required]
		public Int16 Time { get; set; }

		[Required]
		public Int16 Minute { get; set; }
	}
}
