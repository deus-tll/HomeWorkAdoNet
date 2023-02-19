using Championship_DatabaseContext;
using Championship_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


		public void SaveChanges()
		{
			DB.SaveChanges();
		}
	}
}
