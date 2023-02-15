using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HomeWork2_VegetablesFruits
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly VegetablesFruitsDB DB = new();
		private Stopwatch? _timer;
		public MainWindow()
		{
			InitializeComponent();

			TxtBlock_TimeTakenByRequest.Text = "Time taken by executing request: ";
		}

		private async Task UpdateTablesList()
		{
			string query = "select table_name from INFORMATION_SCHEMA.TABLES";

			Cmb_TablesList.ItemsSource = null;

			DataTable? resultTable = await DB.GetTableByQuery(query);

			if (resultTable is not null)
				Cmb_TablesList.ItemsSource = resultTable.AsDataView();

			if (Cmb_TablesList.Items.Count == 0)
				return;

			Cmb_TablesList.DisplayMemberPath = "table_name";
			Cmb_TablesList.SelectedValuePath = "table_name";
			Cmb_TablesList.SelectedItem = Cmb_TablesList.Items[0];
		}

		private void UpdateDataGrid(DataView dataView)
		{
			recordsList.ItemsSource = null;

			if (dataView is not null)
				recordsList.ItemsSource = dataView;

			StopTimer();
		}

		private async void Btn_GetProviders_Click(object sender, RoutedEventArgs e)
		{
			Cmb_Providers.ItemsSource = null;
			List<string> providers = new();
			try
			{
				providers = await VegetablesFruitsDB.GetProvidersList();
			}
			finally
			{
				Cmb_Providers.ItemsSource = providers;
			}
		}

		private void Cmb_Providers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (Cmb_Providers.SelectedItem.ToString() is not null)
				TxtBox_ConnectionString.Text = DB.ChangingProvider(Cmb_Providers.SelectedItem.ToString());
		}

		private void Btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DB.DisconnectBase();
			Cmb_TablesList.ItemsSource = null;
			recordsList.ItemsSource = null;
			recordsListEditing.ItemsSource = null;
		}

		private async void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			await DB.ConnectBase();
			await UpdateTablesList();
		}

		private void StartTimer()
		{
			_timer = new Stopwatch();
			_timer.Start();
		}

		private void StopTimer()
		{
			if (_timer is not null)
			{
				_timer.Stop();
				TimeSpan timeTaken = _timer.Elapsed;
				TxtBlock_TimeTakenByRequest.Text = $"Time taken by executing request: {timeTaken.ToString(@"ss\.fffffff")}";
			}
		}

		private async void Btn_ShowAllInfo_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowAllInfo();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowAllProducts_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowAllProducts();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowAllColors_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowAllColors();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowMaxCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowMaxCaloricContent();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowMinCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowMinCaloricContent();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowAvgCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowAvgCaloricContent();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowCountVegetables_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowCountVegetables();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowCountFruits_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowCountFruits();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowVegetablesFruitsWithCaloricContentLessThanSpec_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowVegetablesFruitsWithCaloricContentLessThanSpec(sliderCaloricContent1.Value.ToString());
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowVegetablesFruitsWithCaloricContentMoreThanSpec_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowVegetablesFruitsWithCaloricContentMoreThanSpec(sliderCaloricContent2.Value.ToString());
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowVegetablesFruitsCaloricContentInRange_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowVegetablesFruitsCaloricContentInRange(sliderStartRange.Value.ToString(), sliderEndRange.Value.ToString()) ;
			UpdateDataGrid(dataView);
		}

		private async void Btn_ShowVegetablesFruitsWithColorRedOrYellow_Click(object sender, RoutedEventArgs e)
		{
			StartTimer();

			DataView? dataView = await DB.Query_ShowVegetablesFruitsWithColorRedOrYellow();
			UpdateDataGrid(dataView);
		}

		private async void Btn_ReadData_Click(object? sender, RoutedEventArgs? e)
		{
			recordsListEditing.ItemsSource = null;

			if (Cmb_TablesList.Items.Count == 0)
				return;

			string? select = Cmb_TablesList.SelectedValue.ToString();

			if (select is not null)
			{
				DataTable? resultTable = await DB.GetTableByQuery(select);

				if (resultTable is not null)
					recordsListEditing.ItemsSource = resultTable.AsDataView();
			}
		}

		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			DB.SaveChanges();
			Btn_ReadData_Click(null, null);
		}

		private async void Btn_UpdateTablesList_Click(object sender, RoutedEventArgs e)
		{
			await UpdateTablesList();
		}
	}
}
