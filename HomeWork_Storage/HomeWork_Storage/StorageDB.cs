using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Data;
using System.Data.Common;

namespace HomeWork_Storage
{
	public class StorageDB
	{
		private readonly string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["StorageDB_Connection"].ConnectionString;

		private SqlConnection _connection;
		private SqlDataAdapter _adapter;
		private SqlDataAdapter _adapterEditing;
		private DataTable _tableEditing;
		private SqlCommandBuilder _commandBuilder;


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

		public DataTable GetTable(string query) 
		{
			if (_connection is null)
				return new DataTable();

			_adapter?.Dispose();
			_adapter = new SqlDataAdapter(query, _connection);
			DataTable table = new DataTable();
			_adapter.Fill(table);
			return table;
		}

		public DataTable GetData(string table_name)
		{
			_adapterEditing = new SqlDataAdapter($"select * from [{table_name}]", _connection);
			_commandBuilder = new SqlCommandBuilder(_adapterEditing);
			_tableEditing = new DataTable(table_name);
			_adapterEditing.Fill(_tableEditing);
			return _tableEditing;
		}

		public void SaveChanges()
		{
			_adapterEditing?.Update(_tableEditing);
		}

	}
}
