using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Championship_Models.Models
{
	[Table("Matches")]
	public class Match
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int Team1Id { get; set; }
		public virtual Team? Team1 { get; set; }

		[Required]
		public int Team2Id { get; set; }
		public virtual Team? Team2 { get; set; }

		public virtual ICollection<Goal> Goals { get; set; } = new HashSet<Goal>();

		[Required]
		public DateTime DateOfTheMatch { get; set; }
	}
}
