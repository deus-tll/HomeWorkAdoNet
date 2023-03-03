using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.Entities
{
	public class Venue
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Country { get; set; }
		public string? City { get; set; }

		public virtual ICollection<Tournament> Tournaments { get; set; } = new HashSet<Tournament>();
	}

	public class VenueConfigure : IEntityTypeConfiguration<Venue>
	{
		public void Configure(EntityTypeBuilder<Venue> builder)
		{
			builder.ToTable("Venues")
			.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(128);

			builder.Property(x => x.Country)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(100);

			builder.Property(x => x.City)
				.IsRequired()
				.IsUnicode()
				.HasMaxLength(100);
		}
	}
}
