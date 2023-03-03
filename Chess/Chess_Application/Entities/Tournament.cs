using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.Entities
{
	public class Tournament
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public int VenueId { get; set; }
		public virtual Venue? Venue { get; set; }	
		public DateTime? DateOfStart { get; set; }
		public DateTime? DateOfEnd { get; set; }
		public int? ChampionId { get; set; }
		public virtual Participant? Champion { get; set; }

		public virtual ICollection<Сompetition> Сompetitions { get; set; } = new HashSet<Сompetition>();
		public virtual ICollection<Participant> Participants { get; set; } = new HashSet<Participant>();
	}

	public class TournamentConfigure : IEntityTypeConfiguration<Tournament>
	{
		public void Configure(EntityTypeBuilder<Tournament> builder)
		{
			builder.ToTable("Tournaments")
			.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(128);

			builder.HasOne(m => m.Champion)
				.WithMany()
				.HasForeignKey(m => m.ChampionId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Property(x => x.ChampionId)
				.IsRequired(false);

			builder.HasMany(t => t.Сompetitions)
				.WithOne(m => m.Tournament)
				.HasForeignKey(m => m.TournamentId);

			builder.HasOne(t => t.Venue)
				.WithMany(l => l.Tournaments)
				.HasForeignKey(t => t.VenueId);

			builder.Property(p => p.DateOfStart)
				.IsRequired(false);

			builder.Property(p => p.DateOfEnd)
				.IsRequired(false);
		}
	}
}
