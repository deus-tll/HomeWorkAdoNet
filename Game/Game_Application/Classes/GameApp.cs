using Game_DatabaseContext.Classes;
using Game_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Game_Application.Classes
{
	public enum Table
	{
		Games,
		Companies,
		Styles,
		Countries,
		Cities
	}

	public class GameApp
	{
		private readonly string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["GameDB_ConnectionString"].ConnectionString;
		private readonly GameDB DB;


		public GameApp() => DB = new GameDB(CONNECTION_STRING);


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


		public ObservableCollection<Game> GetGames()
		{
			DB.Games.Load();
			return DB.Games.Local.ToObservableCollection();
		}


		public ObservableCollection<Company> GetCompanies()
		{
			DB.Companies.Load();
			return DB.Companies.Local.ToObservableCollection();
		}


		public ObservableCollection<Style> GetStyles()
		{
			DB.Styles.Load();
			return DB.Styles.Local.ToObservableCollection();
		}


		public ObservableCollection<Country> GetCountries()
		{
			DB.Countries.Load();
			return DB.Countries.Local.ToObservableCollection();
		}


		public ObservableCollection<City> GetCities()
		{
			DB.Cities.Load();
			return DB.Cities.Local.ToObservableCollection();
		}


		public Game? GetGameByName(string name)
		{
			DB.Games.Load();
			return DB.Games.FirstOrDefault(v => v.Name == name);
		}


		public City? GetCityByName(string name)
		{
			DB.Cities.Load();
			return DB.Cities.FirstOrDefault(v => v.Name == name);
		}


		public Country? GetCountryByName(string name)
		{
			DB.Countries.Load();
			return DB.Countries.FirstOrDefault(v => v.Name == name);
		}


		public Style? GetStyleByName(string name)
		{
			DB.Styles.Load();
			return DB.Styles.FirstOrDefault(v => v.Name == name);
		}


		public Company? GetCompanyByName(string name)
		{
			DB.Companies.Load();
			return DB.Companies.FirstOrDefault(v => v.Name == name);
		}


		public bool IsThereStyleAlready(string name)
		{
			DB.Styles.Load();
			return DB.Styles.Any(s => s.Name == name);
		}


		public bool IsThereGameAlready(string name)
		{
			DB.Games.Load();
			return DB.Games.Any(s => s.Name == name);
		}


		public bool IsThereCountryAlready(string name)
		{
			DB.Countries.Load();
			return DB.Countries.Any(s => s.Name == name);
		}


		public bool IsThereCompanyAlready(string name)
		{
			DB.Companies.Load();
			return DB.Companies.Any(s => s.Name == name);
		}


		public bool IsThereCityAlready(string name)
		{
			DB.Cities.Load();
			return DB.Cities.Any(s => s.Name == name);
		}


		public bool IsThereCompanyAlreadyInCity(int cityId, string companyName)
		{
			DB.Cities.Load();
			City? city = DB.Cities.FirstOrDefault(c => c.Id == cityId);
			if (city is null)
				return false;

			return city.Companies.Any(c => c.Name == companyName);
		}


		public bool IsThereCityAlreadyInCompany(int companyId, string cityName)
		{
			DB.Companies.Load();
			Company? company = DB.Companies.FirstOrDefault(c => c.Id == companyId);
			if (company is null)
				return false;

			return company.Cities.Any(c => c.Name == cityName);
		}


		public void AddStyle(string name)
		{
			Style style = new()
			{
				Name = name
			};

			DB.Styles.Add(style);
			DB.SaveChanges();
		}


		public void RemoveStyle(Style style) => DB.Styles.Remove(style);


		public void AddCountry(string name)
		{
			Country country = new()
			{
				Name = name
			};

			DB.Countries.Add(country);
			DB.SaveChanges();
		}


		public void RemoveCountry(Country country) => DB.Countries.Remove(country);


		public void AddCity(string name, Country country)
		{
			City city = new()
			{
				Name = name,
				Country = country
			};

			DB.Cities.Add(city);
			DB.SaveChanges();
		}


		public void RemoveCity(City city) => DB.Cities.Remove(city);


		public void AddCompany(string name)
		{
			Company company = new()
			{
				Name = name
			};

			DB.Companies.Add(company);
			DB.SaveChanges();
		}


		public void RemoveCompany(Company company) => DB.Companies.Remove(company);


		public void AddGame(string name, DateTime date, Style style, Company company, string mode, int soldCopies)
		{
			Game game = new()
			{
				Name = name,
				ReleaseDate = date,
				Style = style,
				Company = company,
				Mode = mode,
				SoldCopies = soldCopies
			};

			DB.Games.Add(game);
			DB.SaveChanges();
		}


		public void RemoveGame(Game game) => DB.Games.Remove(game);


		public async Task<int> CountOfSingleplayerGames()
		{
			await DB.Games.LoadAsync();
			return await Task.Run<int> (() => DB.Games.Where(v => v.Mode == "Singleplayer").Count());
		}


		public async Task<int> CountOfMultiplayerGames()
		{
			await DB.Games.LoadAsync();
			return await Task.Run<int>(() => DB.Games.Where(v => v.Mode == "Multiplayer").Count());
		}


		public async Task<IEnumerable> GameWithMostSoldCopies(Style style)
		{
			await DB.Games.LoadAsync();
			return await Task.Run<IEnumerable>(() =>
			{
				var v = (from game in DB.Games.Local.ToObservableCollection()
						 where game.StyleId == style.Id
						orderby game.SoldCopies descending
						select new
						{
							GameName = game.Name,
							game.ReleaseDate,
							Style = game.Style.Name,
							game.Mode,
							Company = game.Company.Name,
							game.SoldCopies
						}).Take(1).ToList();
						

				return v;
			});
		}
		 

		public async Task<IEnumerable> Top5GamesWithMostSoldCopies(Style style)
		{
			await DB.Games.LoadAsync();
			return await Task.Run<IEnumerable>(() =>
			{
				var v = (from game in DB.Games.Local.ToObservableCollection()
						 where game.StyleId == style.Id
						 orderby game.SoldCopies descending
						 select new
						 {
							 GameName = game.Name,
							 game.ReleaseDate,
							 Style = game.Style.Name,
							 game.Mode,
							 Company = game.Company.Name,
							 game.SoldCopies
						 }).Take(5).ToList();


				return v;
			});
		}


		public async Task<IEnumerable> Top5GamesWithLowestSoldCopies(Style style)
		{
			await DB.Games.LoadAsync();
			return await Task.Run<IEnumerable>(() =>
			{
				var v = (from game in DB.Games.Local.ToObservableCollection()
						 where game.StyleId == style.Id
						 orderby game.SoldCopies
						 select new
						 {
							 GameName = game.Name,
							 game.ReleaseDate,
							 Style = game.Style.Name,
							 game.Mode,
							 Company = game.Company.Name,
							 game.SoldCopies
						 }).Take(5).ToList();


				return v;
			});
		}


		public async Task<IEnumerable> AllInfoAboutGames()
		{
			await DB.Games.LoadAsync();
			return await Task.Run<IEnumerable>(() =>
			{
				return from g in DB.Games.Local.ToObservableCollection()
					   select new { GameName = g.Name,
									g.ReleaseDate,
									Style = g.Style.Name,
									g.Mode,
									Company = g.Company.Name,
									g.SoldCopies};
			});
		}


		public async Task<IEnumerable> CompaniesAndStylesWithMostCount()
		{
			await DB.Games.LoadAsync();
			await DB.Companies.LoadAsync();

			return await Task.Run<IEnumerable>(() =>
			{
				return from game in DB.Games.Local.ToObservableCollection()
					   join company in DB.Companies on game.CompanyId equals company.Id
							group game by new { Company = company.Name, Style = game.Style.Name } into res
							let count = res.Count()
							orderby count descending
							select new { CompanyName = res.Key.Company, StyleName = res.Key.Style, GameCount = count };
			});
		}
	}
}
