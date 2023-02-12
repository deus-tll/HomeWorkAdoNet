using System;
using System.Collections.Generic;
using System.Data;
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

namespace StationeryCompany
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly StationeryCompanyDB DB = new();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void UpdateTableList()
		{
			string query = "select table_name from INFORMATION_SCHEMA.TABLES";
			DataTable dataTable = DB.GetTableByQueries(query);

			for (int i = 1; i < dataTable.Rows.Count; i++)
			{
				if (dataTable.Rows[i]["table_name"].ToString().ToLower().Contains("archive"))
				{
					dataTable.Rows[i].Delete();
				}
			}

			Cmb_TablesList.ItemsSource = dataTable.AsDataView();

			if (Cmb_TablesList.Items.Count == 0)
				return;

			Cmb_TablesList.DisplayMemberPath = "table_name";
			Cmb_TablesList.SelectedValuePath = "table_name";

			Cmb_TablesList.SelectedItem = Cmb_TablesList.Items[0];
		}


		private void UpdateDataGrid(string query)
		{
			recordsListQueries.ItemsSource = null;
			recordsListQueries.ItemsSource = DB.GetTableByQueries(query).AsDataView();
		}


		private void Btn_ReadData_Click(object? sender, RoutedEventArgs? e)
		{
			recordsListEditing.ItemsSource = null;

			if(Cmb_TablesList.Items.Count == 0)
				return;

			recordsListEditing.ItemsSource = DB.GetTableByName(Cmb_TablesList.SelectedValue.ToString()).AsDataView();

		}

		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			DB.SaveChanges();
			Btn_ReadData_Click(null, null);
        }

		private void Btn_UpdateTablesList_Click(object sender, RoutedEventArgs e)
		{
			UpdateTableList();
        }

		private void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			DB.ConnectBase();
			UpdateTableList();
		}

		private void Btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DB.DisconnectBase();
			Cmb_TablesList.ItemsSource = null;
			recordsListQueries.ItemsSource = null;
			recordsListEditing.ItemsSource = null;
		}

		private void TextBox_CountDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out int result);
		}

		private void Btn_ManagersWithMostSalesByNumberOfUnits_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.ManagersWithMostSalesByNumberOfUnits();");
		}

		private void Btn_ManagersWithMostSalesByHighestTotalProfit_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.ManagersWithMostSalesByHighestTotalProfit();");
		}

		private void Btn_ManagersWithMostSalesByHighestTotalProfitInRangeDate_Click(object sender, RoutedEventArgs e)
		{
			DateTime? selectedStartDate = DatePicker_StartDate.SelectedDate;
			DateTime? selectedEndDate = DatePicker_EndDate.SelectedDate;
			if (selectedStartDate.HasValue && selectedEndDate.HasValue)
			{
				string formattedStartDate = selectedStartDate.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
				string formattedEndDate = selectedEndDate.Value.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

				UpdateDataGrid($"select * from dbo.ManagersWithMostSalesByHighestTotalProfitInRangeDate('{formattedStartDate}', '{formattedEndDate}');");
			}
		}

		private void Btn_BuyerCompaniesPurchaseWithLargestAmount_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.BuyerCompaniesPurchaseWithLargestAmount();");
		}

		private void Btn_TypeStationeryWithMostSalesByNumberOfSales_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.TypeStationeryWithMostSalesByNumberOfSales();");
		}

		private void Btn_TypeStationeryWithMostProfitableStationeries_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.TypeStationeryWithMostProfitableStationeries();");
		}

		private void Btn_MostPopularStationeries_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from dbo.MostPopularStationeries();");
		}

		private void Btn_StationeriesThatNotSoldInSpecCountOfDays_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select * from dbo.StationeriesThatNotSoldInSpecCountOfDays({TextBox_CountDays.Text});");
		}
	}
}
