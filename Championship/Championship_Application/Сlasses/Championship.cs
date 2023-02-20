using Championship_DatabaseContext;
using Championship_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Championship_Application.Сlasses
{
	public enum Table
	{
		Teams
	}

	public class Championship
	{
		private readonly string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["ChampionshipDB_ConnectionString"].ConnectionString;
		private readonly ChampionshipDB DB;


		public Championship() => DB = new ChampionshipDB(CONNECTION_STRING);


		public ObservableCollection<Team> GetTeams()
		{
			DB.Teams.Load();
			return DB.Teams.Local.ToObservableCollection();
		}


		public void AddTeam(string Name, string City, int NumberOfWins, int NumberOfDefeats, int NumberOfDraws, int NumberOfGoalsScored, int NumberOfMissedGoals)
		{
			Team team = new()
			{
				Name = Name,
				City = City,
				NumberOfWins = NumberOfWins,
				NumberOfDefeats = NumberOfDefeats,
				NumberOfDraws = NumberOfDraws,
				NumberOfGoalsScored = NumberOfGoalsScored,
				NumberOfMissedGoals = NumberOfMissedGoals
			};

			DB.Teams.Add(team);
			DB.SaveChanges();
		}


		public void RemoveTeam(Team team)
		{
			DB.Teams.Remove(team);
		}


		public async Task<int> SaveAllChanges(Button sender)
		{
			sender.IsEnabled = false;
			try
			{
				return await DB.SaveChangesAsync();
			}
			finally
			{
				sender.IsEnabled = true;
			}
		}


		public bool IsTeamAlreadyInBase(string name, string city)
		{
			DB.Teams.Load();
			return DB.Teams.Any(t => t.Name == name && t.City == city);
		}


		public Team? GetTeamByNameAndCity(string name, string city)
		{
			DB.Teams.Load();
			return DB.Teams.FirstOrDefault(t => t.Name == name && t.City == city);
		}


		public IEnumerable FindTeamByName(string name)
		{
			DB.Teams.Load();
			return DB.Teams.ToList().Where(t => t.Name == name);
		}


		public IEnumerable FindTeamsByCity(string city)
		{
			DB.Teams.Load();
			return DB.Teams.ToList().Where(t => t.City == city);
		}


		public IEnumerable FindInfoByNameAndCity(string name, string city)
		{
			DB.Teams.Load();
			return DB.Teams.ToList().Where(t => t.Name == name && t.City == city);
		}


		public IEnumerable GetTeamWithMostWins()
		{
			DB.Teams.Load();
			return DB.Teams.ToList().OrderByDescending(t => t.NumberOfWins).Take(1);
		}


		public IEnumerable GetTeamWithMostLosses()
		{
			DB.Teams.Load();
			return DB.Teams.ToList().OrderByDescending(t => t.NumberOfDefeats).Take(1);
		}


		public IEnumerable GetTeamWithMostDraws()
		{
			DB.Teams.Load();
			return DB.Teams.ToList().OrderByDescending(t => t.NumberOfDraws).Take(1);
		}


		public IEnumerable GetTeamWithMostGoalsScored()
		{
			DB.Teams.Load();
			return DB.Teams.ToList().OrderByDescending(t => t.NumberOfGoalsScored).Take(1);
		}


		public IEnumerable GetTeamWithMostMissedGoals()
		{
			DB.Teams.Load();
			return DB.Teams.ToList().OrderByDescending(t => t.NumberOfMissedGoals).Take(1);
		}
	}
}
