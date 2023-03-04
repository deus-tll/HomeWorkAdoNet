using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


		public IEnumerable GetAllCustomers()
		{
			return _connection.Query("select * from dbo.GetAllCustomers()").ToList();
		}


		public IEnumerable GetAllCustomersEmails()
		{
			return _connection.Query("select * from dbo.GetAllCustomersEmails()").ToList();
		}


		public IEnumerable GetAllSections()
		{
			return _connection.Query("select * from dbo.GetAllSections()").ToList();
		}


		public IEnumerable GetAllSharesProducts()
		{
			return _connection.Query("select * from dbo.GetAllSharesProducts()").ToList();
		}


		public IEnumerable GetAllCities()
		{
			return _connection.Query("select * from dbo.GetAllCities()").ToList();
		}


		public IEnumerable GetAllCountries()
		{
			return _connection.Query("select * from dbo.GetAllCountries()").ToImmutableList();
		}


		public IEnumerable GetAllCustomersByCity(string city)
		{
			return _connection.Query($"select * from dbo.GetAllCustomersByCity('{city}')").ToList();
		}


		public IEnumerable GetAllCustomersByCountry(string country)
		{
			return _connection.Query($"select * from dbo.GetAllCustomersByCountry('{country}')").ToList();
		}


		public IEnumerable GetAllSharesByCountry(string country)
		{
			return _connection.Query($"select * from dbo.GetAllSharesByCountry('{country}')").ToList();
		}
	}
}
