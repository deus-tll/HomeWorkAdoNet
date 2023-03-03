using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.Entities
{
	public class Participant
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Surname { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string? Rating { get; set; }
		public virtual ICollection<Сompetition> Сompetitions { get; set; } = new HashSet<Сompetition>();
		public virtual ICollection<Tournament> Tournaments { get; set; } = new HashSet<Tournament>();
	}

	public class ParticipantConfigure : IEntityTypeConfiguration<Participant>
	{
		public void Configure(EntityTypeBuilder<Participant> builder)
		{
			builder.ToTable("Participants")
			.HasKey(x => x.Id);

			builder.HasMany(p => p.Tournaments)
				.WithMany(t => t.Participants)
				.UsingEntity(j => j.ToTable("ParticipantsTournaments"));

			builder.Property(x => x.Name)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(128);

			builder.Property(x => x.Surname)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(128);

			builder.Property(x => x.Rating)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(50);

			builder.Property(p => p.DateOfBirth)
				.IsRequired();
		}
	}
}
