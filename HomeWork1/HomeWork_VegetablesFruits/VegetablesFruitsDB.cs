using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWork_VegetablesFruits
{
    public class VegetablesFruitsDB
    {
		private const string CONNECTION_STRING = "Data Source=DEUS\\SQLSERVER;Initial Catalog=VegetablesFruitsDB;Integrated Security=true";
		private SqlConnection? _connection;
		private SqlDataAdapter? _adapter;

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
			if (_connection is not null)
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
			DataTable table= new();
			_adapter.Fill(table);
			return table;
		}
	}
}
