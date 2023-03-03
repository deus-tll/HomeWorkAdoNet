using Chess_Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.Context
{
	public class ChessDB : DbContext
	{
		public ChessDB() { }
		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseLazyLoadingProxies()
					  .UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["ChessDB_ConnectionString"].ConnectionString);

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new СompetitionConfigure());
			modelBuilder.ApplyConfiguration(new TournamentConfigure());
			modelBuilder.ApplyConfiguration(new VenueConfigure());
			modelBuilder.ApplyConfiguration(new ParticipantConfigure());
		}

		public DbSet<Сompetition> Competitions { get; set; }
		public DbSet<Tournament> Tournaments { get; set; }
		public DbSet<Venue> Venues { get; set; }
		public DbSet<Participant> Participants { get; set; }

	}
}
