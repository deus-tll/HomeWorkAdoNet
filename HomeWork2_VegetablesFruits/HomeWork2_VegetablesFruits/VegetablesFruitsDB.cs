using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace HomeWork2_VegetablesFruits
{
	internal class VegetablesFruitsDB
	{
		private DbConnection? _connection;
		private DbProviderFactory? _factory;
		private string? _connectionString = "";
		private DbDataAdapter? _adapter;

		public async void ConnectBase()
		{
			_connection?.Dispose();

			try
			{
				_connection = _factory?.CreateConnection();

				if (_connection is not null)
				{
					_connection.ConnectionString = _connectionString;
					await _connection.OpenAsync();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection Failed!\n\n" + ex.Message);
				return;
			}
		}

		public async void DisconnectBase()
		{
			if (_connection is not null)
			{
				await _connection.DisposeAsync();
				MessageBox.Show("Connection Interrupted!");
			}
		}

		public async Task<DataTable> GetTableByQuery(string query)
		{
			_adapter = _factory?.CreateDataAdapter();
			if (_adapter is not null && _connection is not null)
			{
				_adapter.SelectCommand = _connection.CreateCommand();
				_adapter.SelectCommand.CommandText = query;
				await Task.Run<DataTable>(() =>
				{
					DataTable t = new();
					_adapter.Fill(t);
					return t;
				});
			}

			return new DataTable();
		}

		public List<string> GetProvidersList()
		{
			List<string> providers = new();

			DataTable table = DbProviderFactories.GetFactoryClasses();

			string? tmp;
			foreach (DataRow provider in table.Rows)
			{
				tmp = provider["InvariantName"].ToString();

				if (tmp is not null)
					providers.Add(tmp);
			}

			return providers;
		}

		public string? ChangingProvider(string? provider)
		{
			if (provider is not null)
			{
				_factory = DbProviderFactories.GetFactory(provider);
				_connectionString = GetConnectionString(provider);

				return _connectionString;
			}
			return null;
		}

		private string? GetConnectionString(string provider) 
		{
			string? result = null;
			ConnectionStringSettingsCollection settingsCollection = ConfigurationManager.ConnectionStrings;
			if (settingsCollection is not null)
			{
				foreach (ConnectionStringSettings item in settingsCollection)
				{
					if (item.ProviderName == provider)
					{
						result = item.ConnectionString;
						break;
					}
				}
			}

			return result;
		}
	}
}
