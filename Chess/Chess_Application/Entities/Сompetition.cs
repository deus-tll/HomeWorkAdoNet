using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.Entities
{
	public class Сompetition
	{
		public int Id { get; set; }

		public int TournamentId { get; set; }
		public virtual Tournament? Tournament { get; set; }

		public int Player1Id { get; set; }
		public virtual Participant? Player1 { get; set; }

		public int Player2Id { get; set; }
		public virtual Participant? Player2 { get; set; }

		public int? WinnerId { get;set; }
		public virtual Participant? Winner { get;set; }

		public DateTime? TimeOfStart { get; set; }
		public DateTime? TimeOfEnd { get; set; }
	}

	public class СompetitionConfigure : IEntityTypeConfiguration<Сompetition>
	{
		public void Configure(EntityTypeBuilder<Сompetition> builder)
		{
			builder.ToTable("Сompetitions")
			.HasKey(x => x.Id);

			builder.HasOne(m => m.Tournament)
				.WithMany(t => t.Сompetitions)
				.HasForeignKey(m => m.TournamentId);

			builder.HasOne(m => m.Player1)
				.WithMany()
				.HasForeignKey(m => m.Player1Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasOne(m => m.Player2)
				.WithMany()
				.HasForeignKey(m => m.Player2Id)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Property(p => p.TimeOfStart)
				.IsRequired(false);

			builder.Property(p => p.TimeOfEnd)
				.IsRequired(false);
		}
	}
}
