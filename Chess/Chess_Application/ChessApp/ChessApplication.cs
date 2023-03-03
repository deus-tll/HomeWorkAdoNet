using Chess_Application.Context;
using Chess_Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Application.ChessApp
{
	public enum Page
	{
		Participants,
		Venues,
		Tournaments,
		Competitions
	}
	public class ChessApplication
	{
		private readonly ChessDB DB = new();


		public async Task<int> SaveAllChanges(Button sender)
		{
			sender.Enabled = false;
			try
			{
				return await DB.SaveChangesAsync();
			}
			finally
			{
				sender.Enabled = true;
			}
		}


		public ObservableCollection<Participant> GetParticipants()
		{
			DB.Participants.Load();
			return DB.Participants.Local.ToObservableCollection();
		}


		public ObservableCollection<Venue> GetVenues()
		{
			DB.Venues.Load();
			return DB.Venues.Local.ToObservableCollection();
		}


		public ObservableCollection<Tournament> GetTournaments()
		{
			DB.Tournaments.Load();
			return DB.Tournaments.Local.ToObservableCollection();
		}


		public ObservableCollection<Сompetition> GetCompetitions()
		{
			DB.Competitions.Load();
			return DB.Competitions.Local.ToObservableCollection();
		}


		public void AddParticipant(string name, string surname, DateTime birth, string rating)
		{
			Participant participant = new()
			{
				Name = name,
				Surname = surname,
				DateOfBirth = birth,
				Rating = rating
			};

			DB.Participants.Add(participant);
		}


		public void RemoveParticipant(Participant participant)
		{
			DB.Participants.Remove(participant);
		}


		public void AddVenue(string name, string country, string city)
		{
			Venue venue = new()
			{
				Name = name,
				Country = country,
				City = city
			};

			DB.Venues.Add(venue);
		}


		public void RemoveVenue(Venue venue)
		{
			DB.Venues.Remove(venue);
		}


		public void AddTournament(string name, Venue venue, Participant? champion, DateTime? dateStart, DateTime? dateEnd)
		{
			Tournament tournament = new()
			{
				Name = name,
				Venue = venue,
				Champion = champion,
				DateOfStart = dateStart,
				DateOfEnd = dateEnd
			};

			DB.Tournaments.Add(tournament);
		}


		public void RemoveTournament(Tournament tournament)
		{
			DB.Tournaments.Remove(tournament);
		}





		public Participant? GetParticipant(int id)
		{
			DB.Participants.Load();
			return DB.Participants.Local.FirstOrDefault(x => x.Id == id);
		}
	}
}
