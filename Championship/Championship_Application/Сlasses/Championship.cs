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
		Teams,
		Matches,
		Players,
		Goals
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


		public ObservableCollection<Match> GetMatches()
		{
			DB.Matches.Load();
			return DB.Matches.Local.ToObservableCollection();
		}


		public ObservableCollection<Player> GetPlayers()
		{
			DB.Players.Load();
			return DB.Players.Local.ToObservableCollection();
		}

		public ObservableCollection<Goal> GetGoals()
		{
			DB.Goals.Load();
			return DB.Goals.Local.ToObservableCollection();
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


		public void AddPlayer(string pib, string country, short number, string position, Team team)
		{
			Player player = new()
			{
				PIB = pib,
				Country = country,
				Number = number,
				Position = position,
				Team = team
			};

			DB.Players.Add(player);
			DB.SaveChanges();
		}


		public void RemovePlayer(Player player)
		{
			DB.Players.Remove(player);
		}


		public void AddMatch(Team team1, Team team2, DateTime date)
		{
			Match match = new()
			{
				Team1 = team1,
				Team2 = team2,
				DateOfTheMatch = date
			};

			DB.Matches.Add(match);
			DB.SaveChanges();
		}


		public void RemoveMatch(Match match)
		{
			DB.Matches.Remove(match);
		}


		public void AddGoal(Match match, Player player, short time, short minute)
		{
			Goal goal = new()
			{
				Match = match,
				MatchId = match.Id,
				Player = player,
				Time = time,
				Minute = minute
			};

			DB.Matches.Load();
			Match? resMatch = DB.Matches.FirstOrDefault(m => m.Id == match.Id);
			if (resMatch != null)
			{
				resMatch.Goals.Add(goal);
			}

			DB.Goals.Add(goal);
			DB.SaveChanges();
		}


		public void RemoveGoal(Goal goal)
		{
			DB.Goals.Remove(goal);
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


		public Team? GetTeamByNameAndCity(string name, string city)
		{
			DB.Teams.Load();
			return DB.Teams.FirstOrDefault(t => t.Name == name && t.City == city);
		}


		public Match? GetMatchById(int id)
		{
			DB.Matches.Load();
			return DB.Matches.FirstOrDefault(m => m.Id == id);
		}


		public Player? GetPlayer(string pib, string country, short number)
		{
			DB.Players.Load();
			return DB.Players.FirstOrDefault(p => p.PIB == pib && p.Country == country && p.Number == number);
		}


		public Match? GetMatch(Team team1, Team team2, DateTime dateOfTheMatch)
		{
			DB.Matches.Load();
			return DB.Matches.FirstOrDefault(m => m.Team1.Name == team1.Name && m.Team2.Name == team2.Name && m.DateOfTheMatch == dateOfTheMatch);
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


		public bool IsThereTeamAlready(string name, string city)
		{
			DB.Teams.Load();
			return DB.Teams.Any(t => t.Name == name && t.City == city);
		}


		public bool IsThereMatchAlready(int teamId1, int teamId2, DateTime dateOfTheMatch)
		{
			DB.Matches.Load();
			return DB.Matches.Any(v => (v.Team1Id == teamId1 && v.Team2Id == teamId2) ||
									   (v.Team2Id == teamId1 && v.Team1Id == teamId2) && 
									    v.DateOfTheMatch == dateOfTheMatch);
		}


		public IEnumerable GetDifferenceInGoalsForEachTeam()
		{
			DB.Teams.Load();
			DB.Matches.Load();
			DB.Goals.Load();

			return from match in DB.Matches.Local.ToObservableCollection()
				   group match by match.Team1 into teamMatches
				   select new
				   {
					   Team = teamMatches.Key,
					   GoalsScored = teamMatches.Sum(m => m.Goals.Count(g => g.Player.Team == teamMatches.Key)),
					   GoalsConceded = teamMatches.Sum(m => m.Team2 == teamMatches.Key ? m.Goals.Count : 0)
									   + teamMatches.Sum(m => m.Team1 == teamMatches.Key ? m.Goals.Count(g => g.Player.Team != teamMatches.Key) : 0)
				   };
		}


		public IEnumerable GetAllInfoAboutMatch()
		{
			DB.Matches.Load();

			return from m in DB.Matches.Local.ToObservableCollection()
				   select new {TeamID = m.Id , Team1 = m.Team1.Name, Team2 = m.Team2.Name, m.DateOfTheMatch };
		}

		public IEnumerable GetMatchesBySpecDate(DateTime date)
		{
			DB.Matches.Load();

			return from m in DB.Matches.Local.ToObservableCollection()
				   where m.DateOfTheMatch == date
				   select new { TeamID = m.Id, Team1 = m.Team1.Name, Team2 = m.Team2.Name, m.DateOfTheMatch };
		}

		public IEnumerable GetMatchesBySpecTeam(string teamName)
		{
			DB.Matches.Load();

			return from m in DB.Matches.Local.ToObservableCollection()
				   where m.Team1.Name == teamName || m.Team2.Name == teamName
				   select new { TeamID = m.Id, Team1 = m.Team1.Name, Team2 = m.Team2.Name, m.DateOfTheMatch };
		}

		public IEnumerable GetPlayersWhoScoredGoalsInSpecDate(DateTime date)
		{
			DB.Matches.Load();
			DB.Goals.Load();

			return from g in DB.Goals.Local.ToObservableCollection()
				   join m in DB.Matches.Local.ToObservableCollection() on g.MatchId equals m.Id
				   where m.DateOfTheMatch == date
				   select new { PlayerPIB = g.Player.PIB };
		}
	}
}
