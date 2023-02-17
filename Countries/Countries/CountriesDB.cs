using System.Data.Linq;
using System.Linq;
using System.Collections;
using System.Data;

namespace Countries
{
	internal class CountriesDB
	{
		private readonly string CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["CountriesDB_ConnectionString"].ConnectionString;
		private readonly DataContext _dbContext;

		public CountriesDB () => 
			_dbContext = new DataContext(CONNECTION_STRING);

		public IEnumerable GetAllInfo() =>
			_dbContext.GetTable<Country>().ToList();


		public IEnumerable GetCountriesNames() =>
			from c in _dbContext.GetTable<Country>()
			select new { Countries = c.Name };


		public IEnumerable GetCapitalsNames() =>
			from c in _dbContext.GetTable<Country>().ToList()
			select new { Capitals = c.Capital };


		public IEnumerable GetEuropeanCountriesNames() =>
			from c in _dbContext.GetTable<Country>().ToList()
			where c.PartOfTheWorld == "Europe"
			select new { Countries = c.Name };


		public IEnumerable GetCountriesNamesWithAreaMoreThanSpec(int value) => 
			from c in _dbContext.GetTable<Country>().ToList()
			where c.Area > value
			select new { Countries = c.Name };


		public IEnumerable GetCountriesWhereNameContains_A_U() => 
			from c in _dbContext.GetTable<Country>().ToList()
			where c.Name.ToLower().Contains('a') && c.Name.ToLower().Contains('u')
			select c;


		public IEnumerable GetCountriesWhereNameContains_A() => 
			from c in _dbContext.GetTable<Country>().ToList()
			where c.Name.ToLower().Contains('a') 
			select c;


		public IEnumerable GetCountriesNamesWithinSpecRangeByArea(int StartRange, int EndRange) =>
			from c in _dbContext.GetTable<Country>().ToList()
			where c.Area.Between(StartRange, EndRange) || c.Area.Between(EndRange, StartRange)
			select new { Countries = c.Name };


		public IEnumerable GetCountriesNamesWithPopulationMoreThanSpec(int value) =>
			from c in _dbContext.GetTable<Country>().ToList()
			where c.Population > value
			select new { Countries = c.Name };


		public IEnumerable GetTop5CountriesByArea() => 
			_dbContext.GetTable<Country>()
			.OrderByDescending(c => c.Area)
			.Take(5)
			.ToList();


		public IEnumerable GetTop5CountriesByPopulation() => 
			_dbContext.GetTable<Country>()
			.OrderByDescending(c => c.Population)
			.Take(5)
			.ToList();


		public IEnumerable GetCountryWithMaxArea() => 
			_dbContext.GetTable<Country>()
			.OrderByDescending(c => c.Area)
			.Take(1)
			.ToList();


		public IEnumerable GetCountryWithMaxPopulation() => 
			_dbContext.GetTable<Country>()
			.OrderByDescending(c => c.Population)
			.Take(1)
			.ToList();


		public IEnumerable GetCountryWithMinAreaInAfrica() =>
			_dbContext.GetTable<Country>()
			.Where(c => c.PartOfTheWorld == "Africa")
			.OrderBy(c => c.Area)
			.Take(1)
			.ToList();


		public DataView GetAverageAreOfAsianCountries()
		{
			double res = _dbContext.GetTable<Country>()
						 .Where(c => c.PartOfTheWorld == "Asia")
						 .Average(c => c.Area);

			DataTable table = new();

			table.Columns.Add("Average area of countries in Asia");
			table.Rows.Add(res);

			return table.AsDataView();
		}
			

	}
}
