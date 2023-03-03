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
		private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ChatDB_ConnectionString"].ConnectionString;

		public ChatDB_Context() : base() { }

		public ChatDB_Context(string connectionString) : base() { CONNECTION_STRING = connectionString; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			
		}

		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Message> Messages { get; set; }
	}
}
