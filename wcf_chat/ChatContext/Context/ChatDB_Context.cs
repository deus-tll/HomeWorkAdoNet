using ChatContext.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ChatContext.Context
{
	public class ChatDB_Context : DbContext
	{
		public ChatDB_Context() : base("ChatDB_ConnectionString") { }

		public ChatDB_Context(string connectionString) : base(connectionString) {  }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new MessageConfiguration());
			modelBuilder.Configurations.Add(new ContactConfiguration());
		}

		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Message> Messages { get; set; }
	}
}
