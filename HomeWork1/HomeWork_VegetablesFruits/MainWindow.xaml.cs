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

namespace HomeWork_VegetablesFruits
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly VegetablesFruitsDB DB = new();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void UpdateDataGrid(string query)
		{
			recordsList.ItemsSource = null;
			recordsList.ItemsSource = DB.GetTable(query).AsDataView();
		}

		private void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			DB.ConnectBase();
		}

		private void Btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DB.DisconnectBase();
		}

		private void Btn_ShowAllInfo_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from VegetablesFruits");
		}

		private void Btn_ShowAllProducts_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Name from VegetablesFruits");
		}

		private void Btn_ShowAllColors_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select distinct Color from VegetablesFruits");
		}

		private void Btn_ShowMaxCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Max(CaloricContent) as 'Max Caloric Content' from VegetablesFruits");
		}

		private void Btn_ShowMinCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Min(CaloricContent) as 'Min Caloric Content' from VegetablesFruits");
		}

		private void Btn_ShowAvgCaloricContent_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Avg(CaloricContent) as 'Avg Caloric Content' from VegetablesFruits");
		}

		private void Btn_ShowCountVegetables_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Count(ID) as 'Count of Vegetables' from VegetablesFruits where Type = 'Vegetable'");
		}

		private void Btn_ShowCountFruits_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select Count(ID) as 'Count of Fruits' from VegetablesFruits where Type = 'Fruit'");
		}

		private void Btn_ShowVegetablesFruitsWithCaloricContentLessThanSpec_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select * from VegetablesFruits where CaloricContent < {sliderCaloricContent1.Value}");
		}

		private void Btn_ShowVegetablesFruitsWithCaloricContentMoreThanSpec_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select * from VegetablesFruits where CaloricContent > {sliderCaloricContent1.Value}");
		}

		private void Btn_ShowVegetablesFruitsCaloricContentInRange_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid($"select * from VegetablesFruits where CaloricContent between {sliderStartRange.Value} and {sliderEndRange.Value}");
		}

		private void Btn_ShowVegetablesFruitsWithColorRedOrYellow_Click(object sender, RoutedEventArgs e)
		{
			UpdateDataGrid("select * from VegetablesFruits where Color in ('Red', 'Yellow')");
		}
	}
}
