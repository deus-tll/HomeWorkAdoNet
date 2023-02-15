using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace HomeWork2_VegetablesFruits
{
	internal class VegetablesFruitsDB
	{
		private DbConnection? _connection;
		private DbProviderFactory? _factory;
		private string? _connectionString = "";
		private DbDataAdapter? _adapter;
		private DbDataAdapter? _adapterEditing;
		private DataTable? _tableEditing;
		private DbCommandBuilder? _commandBuilder;


		//В .NET Core з цим поскладніше, в інтернеті довелось шукати як зробити, щоб працювало
		//я вписував у Package Manager Console ось це 
		/*
			Find-Package SQLClient
			Install-Package System.Data.SqlClient -ProjectName HomeWork2_VegetablesFruits
		*/
		//а також те що в конструкторі
		public VegetablesFruitsDB() 
		{
			DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
		}

		public async Task ConnectBase()
		{
			_connection?.Dispose();

			try
			{
				_connection = _factory?.CreateConnection();

				if (_connection is null)
					throw new Exception("Connection wasn`t created.");
				
				_connection.ConnectionString = _connectionString;
				await _connection.OpenAsync();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection Failed!\n\n" + ex.Message);
				return;
			}

			MessageBox.Show("The Connection Was Successful!");
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
				return await Task.Run<DataTable>(() =>
				{
					DataTable t = new();
					_adapter.Fill(t);
					return t;
				});
			}

			return new DataTable();
		}


		public async Task<DataTable> GetTableByTableName(string table_name)
		{
			_adapterEditing = _factory?.CreateDataAdapter();
			if (_adapterEditing is not null && _connection is not null)
			{
				_adapterEditing.SelectCommand = _connection.CreateCommand();
				_adapterEditing.SelectCommand.CommandText = $"select * from [{table_name}]";
				_commandBuilder = _factory?.CreateCommandBuilder();

				if (_commandBuilder is not null)
				{
					_commandBuilder.DataAdapter = _adapterEditing;

					return await Task.Run<DataTable>(() =>
					{
						_tableEditing = new();
						_adapterEditing.Fill(_tableEditing);
						return _tableEditing;
					});
				}
			}

			return new DataTable(table_name);
		}

		public void SaveChanges()
		{
			if (_tableEditing is not null)
				_adapterEditing?.Update(_tableEditing);
		}

		public static async Task<List<string>> GetProvidersList()
		{
			return await Task.Run<List<string>>(() =>
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
			});
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

		private static string? GetConnectionString(string provider) 
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

		public async Task<DataView> Query_ShowAllInfo()
		{
			string query = "select * from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowAllProducts()
		{
			string query = "select Name from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowAllColors()
		{
			string query = "select distinct Color from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowMaxCaloricContent()
		{
			string query = "select Max(CaloricContent) as 'Max Caloric Content' from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowMinCaloricContent()
		{
			string query = "select Min(CaloricContent) as 'Min Caloric Content' from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowAvgCaloricContent()
		{
			string query = "select Avg(CaloricContent) as 'Avg Caloric Content' from VegetablesFruits";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowCountVegetables()
		{
			string query = "select Count(ID) as 'Count of Vegetables' from VegetablesFruits where Type = 'Vegetable'";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowCountFruits()
		{
			string query = "select Count(ID) as 'Count of Fruits' from VegetablesFruits where Type = 'Fruit'";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowVegetablesFruitsWithCaloricContentLessThanSpec(string value)
		{
			string query = $"select * from VegetablesFruits where CaloricContent < {value}";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowVegetablesFruitsWithCaloricContentMoreThanSpec(string value)
		{
			string query = $"select * from VegetablesFruits where CaloricContent > {value}";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowVegetablesFruitsCaloricContentInRange(string value1, string value2)
		{
			string query = $"select * from VegetablesFruits where CaloricContent between {value1} and {value2}";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}

		public async Task<DataView> Query_ShowVegetablesFruitsWithColorRedOrYellow()
		{
			string query = "select * from VegetablesFruits where Color in ('Red', 'Yellow')";
			DataTable table = await GetTableByQuery(query);
			return table.AsDataView();
		}
	}
}
