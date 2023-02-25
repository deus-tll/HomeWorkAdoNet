using Game_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Game_DatabaseContext.Classes
{
	public class GameDB : DbContext
	{
		private readonly string? CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GameDB_ConnectionString"].ConnectionString;

		public GameDB() : base() { }

		public GameDB(string connectionString) : base()
		{ 
			CONNECTION_STRING = connectionString;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(CONNECTION_STRING).UseLazyLoadingProxies();


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Game>().HasCheckConstraint("CK_Games_Mode", "([Mode] in ('Singleplayer', 'Multiplayer'))");
		}

		public DbSet<Game> Games { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Style> Styles { get; set; }

	}
}
