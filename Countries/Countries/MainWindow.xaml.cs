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

namespace Countries
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private CountriesDB DB = new();


		public MainWindow()
		{
			InitializeComponent();
		}


		private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out _);
		}


		private void Btn_GetAllInfo_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetAllInfo();
		}


		private void Btn_GetCountriesNames_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountriesNames();
		}


		private void Btn_GetCapitalsNames_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCapitalsNames();
		}


		private void Btn_GetEuropeanCountriesNames_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetEuropeanCountriesNames();
		}


		private void Btn_GetCountriesNamesWithAreaMoreThanSpec_Click(object sender, RoutedEventArgs e)
		{
			if(int.TryParse(TextBox_Area.Text, out int value))
				recordsListQueries.ItemsSource = DB.GetCountriesNamesWithAreaMoreThanSpec(value);
		}


		private void Btn_GetCountriesWhereNameContains_A_U_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountriesWhereNameContains_A_U();
		}


		private void Btn_GetCountriesWhereNameContains_A_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountriesWhereNameContains_A();
		}


		private void Btn_GetCountriesNamesWithinSpecRangeByArea_Click(object sender, RoutedEventArgs e)
		{
			if (int.TryParse(TextBox_StartRange.Text, out int value1) && int.TryParse(TextBox_EndRange.Text, out int value2))
				recordsListQueries.ItemsSource = DB.GetCountriesNamesWithinSpecRangeByArea(value1, value2);
		}


		private void Btn_GetCountriesNamesWithPopulationMoreThanSpec_Click(object sender, RoutedEventArgs e)
		{
			if (int.TryParse(TextBox_Population.Text, out int value))
				recordsListQueries.ItemsSource = DB.GetCountriesNamesWithPopulationMoreThanSpec(value);
		}


		private void Btn_GetTop5CountriesByArea_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetTop5CountriesByArea();
		}


		private void Btn_GetTop5CountriesByPopulation_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetTop5CountriesByPopulation();
		}


		private void Btn_GetCountryWithMaxArea_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountryWithMaxArea();
		}


		private void Btn_GetCountryWithMaxPopulation_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountryWithMaxPopulation();
		}


		private void Btn_GetCountryWithMinAreaInAfrica_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetCountryWithMinAreaInAfrica();
		}


		private void Btn_GetAverageAreOfAsianCountries_Click(object sender, RoutedEventArgs e)
		{
			recordsListQueries.ItemsSource = DB.GetAverageAreOfAsianCountries();
		}
	}
}
