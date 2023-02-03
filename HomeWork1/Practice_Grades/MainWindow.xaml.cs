using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_Grades
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private const string CONNECTION_STRING = "Data Source=DEUS\\SQLSERVER;Initial Catalog=GradesDB;Integrated Security=true";
		private SqlConnection? _connection;
		private SqlDataAdapter? _adapter;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void UpdateGroupNames()
		{
			SqlDataAdapter adapterGroupNames = new SqlDataAdapter("select distinct GroupName from Grades", _connection);
			DataTable table = new();
			adapterGroupNames.Fill(table);
			cmb_GroupNames.ItemsSource = table.AsDataView();
			cmb_GroupNames.DisplayMemberPath = "GroupName";
			cmb_GroupNames.SelectedValuePath = "GroupName";

			cmb_GroupNames.SelectedItem = cmb_GroupNames.Items[0];
		}

		private void UpdateDataGrid(string query)
		{
			if (_connection == null)
				return;
			
			recordsList.ItemsSource = null;
			_adapter?.Dispose();
			_adapter = new SqlDataAdapter(query, _connection);
			DataTable table = new();
			_adapter.Fill(table);
			recordsList.ItemsSource = table.AsDataView();
		}

		private void btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			ConnectBase();
		}

		private void ConnectBase()
		{
			_connection?.Dispose();

			try
			{
				_connection = new SqlConnection(CONNECTION_STRING);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Connection Failed!\n\n" + ex.Message);
				return;
			}
			MessageBox.Show("The Connection Was Successful!");
			_connection.Open();


			UpdateGroupNames();
		}

		private void btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DisconnectBase();
		}

		private void DisconnectBase()
		{
			if (_connection is not null)
			{
				_connection.Dispose();
				MessageBox.Show("Connection Interrupted!");
			}
		}

		private void btn_ShowAllInfo_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from Grades");
		}

		private void btn_ShowAllPIB_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select PIB from Grades");
		}

		private void btn_ShowAllAvgGrades_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select AverageGrade from Grades");
		}

		private void btn_ShowStudentsWithMinGradeMoreThanSpecified_Click(object sender, RoutedEventArgs e)
		{	
			UpdateDataGrid($"select PIB from Grades where MinGrade > {sliderGrade.Value}");
		}

		private void btn_ShowAllNamesOfSubjectsWithMinAvgGrade_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select distinct SubWithMinGrade from Grades");
		}

		private void btn_ShowMinAvgGrade_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select Min(AverageGrade) as 'Min Average Grade' from Grades");
		}

		private void btn_ShowMaxAvgGrade_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select Max(AverageGrade) as 'Max Average Grade' from Grades");
		}

		private void btn_CountOfStudentsWithMinAvgGradeMath_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select Count(*) as 'Count of Students' from Grades where SubWithMinGrade = 'Math'");
		}

		private void btn_CountOfStudentsWithMaxAvgGradeMath_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select Count(*) as 'Count of Students' from Grades where SubWithMaxGrade = 'Math'");
		}

		private void btn_CountOfStudentsInEachGroup_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Count(ID) as 'Count of Students' from Grades group by GroupName");
        }

		private void btn_AverageGradeOfGroup_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select Avg([AverageGrade]) as 'Average Grade' from Grades where [GroupName] = '{cmb_GroupNames.SelectedValue}'");
        }

		private void btn_UpdateGroupNames_Click(object sender, RoutedEventArgs e)
		{
			UpdateGroupNames();
		}
	}
}
