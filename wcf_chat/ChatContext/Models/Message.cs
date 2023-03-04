using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatContext.Models
{
	public class Message
	{
		public int Id { get; set; }
		public string Content { get; set; }
		public DateTime SendDateTime { get; set; }

		public int ContactId { get; set; }
		public virtual Contact Contact { get; set; }
	}

	public class MessageConfiguration : EntityTypeConfiguration<Message>
	{
		public MessageConfiguration()
		{
			HasKey(x => x.Id);
			Property(i => i.Id)
				.HasColumnName("Id")
				.HasColumnType("int")
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			Property(p => p.Content)
				.HasColumnName("Content")
				.HasMaxLength(500)
				.HasColumnType("nvarchar")
				.IsRequired();

			Property(p => p.SendDateTime)
				.HasColumnName("SendDateTime")
				.HasColumnType("datetime")
				.IsRequired();

			Property(p => p.ContactId)
				.HasColumnName("ContactId")
				.HasColumnType("int")
				.IsRequired();

			ToTable("Messages");
		}
	}
}
