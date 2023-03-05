using Dapper;
using MailingList_Application.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MailingList_Application.DatabaseContext
{
	public class MailingListDB
	{
		private readonly string? CONNECTION_STRING = System.Configuration.ConfigurationManager.ConnectionStrings["MailingListDB_ConnectionString"].ConnectionString;
		private IDbConnection? _connection;


		public void ConnectBase()
		{
			_connection?.Dispose();

			try
			{
				_connection = new SqlConnection(CONNECTION_STRING);
				_connection.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Не вдалось під'єднатися!\n\n" + ex.Message);
				return;
			}

			MessageBox.Show("З'єднання було успішно встановлено!");
		}


		public void DisconnectBase()
		{
			if (_connection is not null)
			{
				_connection.Dispose();
				MessageBox.Show("З'єднання було перервано!");
			}
		}


		#region Queries Part 1
		public async Task<IEnumerable> GetAllCustomers()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllCustomers()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllCustomersEmails()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllCustomersEmails()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllSections()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllSections()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllSharesProducts()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllSharesProducts()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllCities()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllCities()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllCountries()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAllCountries()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllCustomersByCity(string _city)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetAllCustomersByCity(@city)",
				new
				{
					city = _city
				})
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllCustomersByCountry(string _country)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetAllCustomersByCountry(@country)",
				new
				{
					country = _country
				})
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAllSharesByCountry(string _country)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetAllSharesByCountry(@country)",
				new
				{
					country = _country
				})
				.Result
				.ToList();
			});
		}
		#endregion


		#region Queries Part 2
		public async Task<IEnumerable> GetCountCustomersInEachCity()
		{
			return await Task.Run<IEnumerable>(() =>
			{ 
				return _connection.QueryAsync("select * from dbo.GetCountCustomersInEachCity()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetCountCustomersInEachCountry()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetCountCustomersInEachCountry()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetCountCitiesInEachCountry()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetCountCitiesInEachCountry()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetAverageCountOfCitiesByAllCountry()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetAverageCountOfCitiesByAllCountry()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetSectionsCertCustomersFromCertCountryInterested(string _country, string _email)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetSectionsCertCustomersFromCertCountryInterested(@country, @buyer_email)",
				new
				{
					country = _country,
					buyer_email = _email
				})
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetSharesProductsCertSectionInRangeDate(string _section, DateTime _startDate, DateTime _endDate)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetSharesProductsCertSectionInRangeDate(@section, @startDate, @endDate)",
				new
				{
					section = _section,
					startDate = _startDate,
					endDate = _endDate
				})
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetSharesProductsCertCustomer(string _email)
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync($"select * from dbo.GetSharesProductsCertCustomer(@buyer_email)",
				new
				{
					buyer_email = _email
				})
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetTop3CountryByCountOfCustomers()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetTop3CountryByCountOfCustomers()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetTop1CountryByCountOfCustomers()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetTop1CountryByCountOfCustomers()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetTop3CityByCountOfCustomers()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetTop3CityByCountOfCustomers()")
				.Result
				.ToList();
			});
		}


		public async Task<IEnumerable> GetTop1CityByCountOfCustomers()
		{
			return await Task.Run<IEnumerable>(() =>
			{
				return _connection.QueryAsync("select * from dbo.GetTop1CityByCountOfCustomers()")
				.Result
				.ToList();
			});
		}
		#endregion
	}
}
