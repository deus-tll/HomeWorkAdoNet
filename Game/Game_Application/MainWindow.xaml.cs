using Game_Application.Classes;
using Game_Models.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_Application
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly GameApp _app = new();


		public MainWindow()
		{
			InitializeComponent();

			FillTabItemHeaders();
		}


		private void TabControl_Main_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.OriginalSource is TabControl)
			{
				TabItem? tabItem = TabControl_Main.SelectedItem as TabItem;

				if (tabItem is not null)
				{
					switch (tabItem.Tag)
					{
						case "Queries": SwitchToQueriesPage(); break;
					}
				}
			}
		}


		private void SwitchToQueriesPage()
		{
			ComboBox_GameWithMostSoldCopies.ItemsSource = null;
			ComboBox_GameWithMostSoldCopies.ItemsSource = _app.GetStyles();
			ComboBox_GameWithMostSoldCopies.DisplayMemberPath = "Name";
			if (ComboBox_GameWithMostSoldCopies.Items.Count > 0)
				ComboBox_GameWithMostSoldCopies.SelectedItem = ComboBox_GameWithMostSoldCopies.Items[0];
			

			ComboBox_Top5GamesWithMostSoldCopies.ItemsSource = null;
			ComboBox_Top5GamesWithMostSoldCopies.ItemsSource = _app.GetStyles();
			ComboBox_Top5GamesWithMostSoldCopies.DisplayMemberPath = "Name";
			if (ComboBox_Top5GamesWithMostSoldCopies.Items.Count > 0)
				ComboBox_Top5GamesWithMostSoldCopies.SelectedItem = ComboBox_Top5GamesWithMostSoldCopies.Items[0];

			ComboBox_Top5GamesWithLowestSoldCopies.ItemsSource = null;
			ComboBox_Top5GamesWithLowestSoldCopies.ItemsSource = _app.GetStyles();
			ComboBox_Top5GamesWithLowestSoldCopies.DisplayMemberPath = "Name";
			if (ComboBox_Top5GamesWithLowestSoldCopies.Items.Count > 0)
				ComboBox_Top5GamesWithLowestSoldCopies.SelectedItem = ComboBox_Top5GamesWithLowestSoldCopies.Items[0];
		}


		private void FillTabItemHeaders()
		{
			TabItem_Games.Header = Table.Games;
			TabItem_Companies.Header = Table.Companies;
			TabItem_Countries.Header = Table.Countries;
			TabItem_Styles.Header = Table.Styles;
			TabItem_Cities.Header = Table.Cities;
		}


		private void TabControl_Editing_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (e.OriginalSource is TabControl)
			{
				Switches();
			}
		}


		private void Switches() 
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Games:
						SwitchToGamesPage();
						break;

					case Table.Companies:
						SwitchToCompaniesPage();
						break;

					case Table.Countries:
						SwitchToCountriesPage();
						break;

					case Table.Styles:
						SwitchToStylesPage();
						break;

					case Table.Cities:
						SwitchToCitiesPage();
						break;
				}
			}
		}


		private void SwitchToGamesPage()
		{
			Dgv_EditingGames.ItemsSource = null;
			Dgv_EditingGames.ItemsSource = _app.GetGames();

			ComboBox_GameStyle.ItemsSource = null;
			ComboBox_GameStyle.ItemsSource = _app.GetStyles();
			ComboBox_GameStyle.DisplayMemberPath = "Name";
			if (ComboBox_GameStyle.Items.Count > 0)
				ComboBox_GameStyle.SelectedItem = ComboBox_GameStyle.Items[0];

			ComboBox_GameCompany.ItemsSource = null;
			ComboBox_GameCompany.ItemsSource = _app.GetCompanies();
			ComboBox_GameCompany.DisplayMemberPath = "Name";
			if (ComboBox_GameCompany.Items.Count > 0)
				ComboBox_GameCompany.SelectedItem = ComboBox_GameCompany.Items[0];

			if (ComboBox_GameMode.Items.Count is 0)
			{
				ComboBox_GameMode.Items.Add("Singleplayer");
				ComboBox_GameMode.Items.Add("Multiplayer");
				ComboBox_GameMode.SelectedItem = ComboBox_GameMode.Items[0];
			}
		}


		private void SwitchToCitiesPage()
		{
			Dgv_EditingCities.ItemsSource = null;
			Dgv_EditingCities.ItemsSource = _app.GetCities();

			if (Dgv_EditingCities.Items.Count is 0)
			{
				Grid_AddCompaniesToCity.IsEnabled = false;
				Grid_DeleteCompaniesToCity.IsEnabled = false;
			}
			else
			{
				Grid_AddCompaniesToCity.IsEnabled = true;
				Grid_DeleteCompaniesToCity.IsEnabled = true;
			}

			ComboBox_CityCountry.ItemsSource = null;
			ComboBox_CityCountry.ItemsSource = _app.GetCountries();
			ComboBox_CityCountry.DisplayMemberPath = "Name";
			if (ComboBox_CityCountry.Items.Count > 0)
				ComboBox_CityCountry.SelectedItem = ComboBox_CityCountry.Items[0];

			ComboBox_AllCompanies.ItemsSource = null;
			ComboBox_AllCompanies.ItemsSource = _app.GetCompanies();
			ComboBox_AllCompanies.DisplayMemberPath = "Name";
			if (ComboBox_AllCompanies.Items.Count > 0)
				ComboBox_AllCompanies.SelectedItem = ComboBox_AllCompanies.Items[0];
		}


		private void SwitchToCompaniesPage()
		{
			Dgv_EditingCompanies.ItemsSource = null;
			Dgv_EditingCompanies.ItemsSource = _app.GetCompanies();

			if (Dgv_EditingCompanies.Items.Count is 0)
			{
				Grid_AddCityToCompanies.IsEnabled = false;
				Grid_DeleteCityToCompanies.IsEnabled = false;
			}
			else
			{
				Grid_AddCityToCompanies.IsEnabled = true;
				Grid_DeleteCityToCompanies.IsEnabled = true;
			}

			ComboBox_AllCities.ItemsSource = null;
			ComboBox_AllCities.ItemsSource = _app.GetCities();
			ComboBox_AllCities.DisplayMemberPath = "Name";
			if (ComboBox_AllCities.Items.Count > 0)
				ComboBox_AllCities.SelectedItem = ComboBox_AllCities.Items[0];
		}


		private void SwitchToCountriesPage()
		{
			Dgv_EditingCountry.ItemsSource = null;
			Dgv_EditingCountry.ItemsSource = _app.GetCountries();
		}


		private void SwitchToStylesPage()
		{
			Dgv_EditingStyle.ItemsSource = null;
			Dgv_EditingStyle.ItemsSource = _app.GetStyles();
		}


		private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out _);
		}


		private static bool CheckFields(List<string> fields)
		{
			foreach (var field in fields)
			{
				if (string.IsNullOrEmpty(field))
				{
					MessageBox.Show("Всі поля мають бути заповнені!");
					return false;
				}
			}

			return true;
		}


		private async void Btn_AddCompanyToCity_Click(object sender, RoutedEventArgs e)
		{
			City? city = Dgv_EditingCities.SelectedItem as City;
			Company? company = ComboBox_AllCompanies.SelectedItem as Company;
			if (city is not null && company is not null && company.Name is not null)
			{

				if (_app.IsThereCompanyAlreadyInCity(city.Id, company.Name))
				{
					MessageBox.Show("В данному місті вже є філія цієї компанії!");
					return;
				}

				city.Companies.Add(company);
				await _app.SaveAllChanges(Btn_AddCompanyToCity);
				Switches();
			}
			else
			{
				MessageBox.Show("Оберіть місто з таблиці!");
			}

		}


		private async void Btn_DeleteCompanyFromThisCity_Click(object sender, RoutedEventArgs e)
		{
			City? city = Dgv_EditingCities.SelectedItem as City;

			if (city is null) return;

			if (city.Companies.Count == 0) return;

			Company? company = ComboBox_CompaniesInThisCity.SelectedItem as Company;

			if (company is null) return;

			city.Companies.Remove(company);
			await _app.SaveAllChanges(Btn_DeleteCompanyFromThisCity);
			Switches();
		}


		private async void Btn_AddCityToCompany_Click(object sender, RoutedEventArgs e)
		{
			Company? company = Dgv_EditingCompanies.SelectedItem as Company;
			City? city = ComboBox_AllCities.SelectedItem as City;
			if (city is not null && company is not null && city.Name is not null)
			{
				if (_app.IsThereCityAlreadyInCompany(company.Id, city.Name))
				{
					MessageBox.Show("В списку міст в яких знаходяться філії компанії це місто вже є!");
					return;
				}

				company.Cities.Add(city);
				await _app.SaveAllChanges(Btn_AddCityToCompany);
				Switches();
			}
			else
			{
				MessageBox.Show("Оберіть компанію з таблиці!");
			}

			
		}


		private async void Btn_DeleteCityFromThisCompany_Click(object sender, RoutedEventArgs e)
		{
			Company? company = Dgv_EditingCompanies.SelectedItem as Company;

			if (company is null) return;

			if (company.Cities.Count == 0) return;

			City? city = ComboBox_CitiesInThisCompany.SelectedItem as City;

			if (city is null) return;

			company.Cities.Remove(city);
			await _app.SaveAllChanges(Btn_DeleteCityFromThisCompany);
			Switches();
		}
	}
}
