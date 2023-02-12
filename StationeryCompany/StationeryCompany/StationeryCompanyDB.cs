using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StationeryCompany
{
	public class StationeryCompanyDB
	{
		private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StationeryCompanyDB_Connection"].ConnectionString;

		private SqlConnection? _connection;
		private SqlDataAdapter? _adapterForQueries;
		private SqlDataAdapter? _adapterForEditing;
		private SqlCommandBuilder? _commandBuilder;
		private DataTable? _tableForEditing;

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
				MessageBox.Show("Connection Failed!\n\n" + ex.Message);
				return;
			}

			MessageBox.Show("The Connection Was Successful!");
		}

		public void DisconnectBase()
		{
			if (_connection != null)
			{
				_connection.Dispose();
				MessageBox.Show("Connection Interrupted!");
			}
		}

		public DataTable GetTableByQueries(string query)
		{
			if (_connection is null || _connection.ConnectionString == "")
				return new DataTable();

			_adapterForQueries?.Dispose();
			_adapterForQueries = new SqlDataAdapter(query, _connection);
			DataTable table = new DataTable();
			_adapterForQueries.Fill(table);
			return table;
		}

		public DataTable GetTableByName(string? tableName)
		{
			if (tableName is not null)
			{
				if (_connection is null || _connection.ConnectionString == "")
					return new DataTable(tableName);

				_adapterForEditing = new SqlDataAdapter($"select * from [{tableName}]", _connection);
				_commandBuilder = new SqlCommandBuilder(_adapterForEditing);
				_tableForEditing = new DataTable(tableName);
				_adapterForEditing.Fill(_tableForEditing);
				return _tableForEditing;
			}
			
			return new DataTable("");
		}

		public void SaveChanges()
		{
			if(_tableForEditing is not null)
				_adapterForEditing?.Update(_tableForEditing);
		}
	}
}
