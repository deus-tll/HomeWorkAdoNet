using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatContext.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }

		public virtual ICollection<Message> Messages { get; set; } = new HashSet<Message>();
	}

	public class ContactConfiguration : EntityTypeConfiguration<Contact>
	{
		public ContactConfiguration()
		{
			HasKey(x => x.Id);
			Property(i => i.Id)
				.HasColumnName("Id")
				.HasColumnType("int")
				.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

			Property(p => p.Name)
				.HasColumnName("Name")
				.HasMaxLength(100)
				.HasColumnType("nvarchar")
				.IsRequired();

			Property(p => p.Surname)
				.HasColumnName("Surname")
				.HasMaxLength(100)
				.HasColumnType("nvarchar")
				.IsRequired();

			Property(p => p.Login)
				.HasColumnName("Login")
				.HasMaxLength(50)
				.HasColumnType("nvarchar")
				.IsRequired();

			Property(p => p.Password)
				.HasColumnName("Password")
				.HasMaxLength(30)
				.HasColumnType("nvarchar")
				.IsRequired();

			Property(p => p.Phone)
				.HasColumnName("Phone")
				.HasMaxLength(25)
				.HasColumnType("nvarchar")
				.IsRequired();

			ToTable("Contacts");
		}
	}
}
