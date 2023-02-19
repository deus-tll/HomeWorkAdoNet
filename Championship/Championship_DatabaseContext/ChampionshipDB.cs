using Microsoft.EntityFrameworkCore;
using Championship_Models.Models;
using System.Configuration;
using System.Data;

namespace Championship_DatabaseContext
{
	public class ChampionshipDB : DbContext
	{
		private readonly string? CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ChampionshipDB_ConnectionString"].ConnectionString;


		public ChampionshipDB() : base() { }


		public ChampionshipDB(string connectionString) : base() { CONNECTION_STRING = connectionString; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(CONNECTION_STRING);


		public DbSet<Team> Teams { get; set; }
	}
}
