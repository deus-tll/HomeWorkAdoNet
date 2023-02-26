using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Championship_Models.Models
{
	[Table("Teams")]
	public class Team
	{
		[Key]
		public int ID { get; set; }

		[MaxLength(150)]
		public string? Name { get; set; }

		public string? City { get; set; }

		public int NumberOfWins { get; set; }

		public int NumberOfDefeats { get; set; }

		public int NumberOfDraws { get; set; }

		public int NumberOfGoalsScored { get; set; }

		public int NumberOfMissedGoals { get; set; }
	}
}
