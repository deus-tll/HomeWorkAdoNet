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


		private async void AddStyle()
		{
			List<string> fields = new()
			{
				TextBox_StyleName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereStyleAlready(TextBox_StyleName.Text))
			{
				MessageBox.Show("Такий стиль вже існує!");
				return;
			}

			_app.AddStyle(TextBox_StyleName.Text);

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private void Dgv_EditingStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Game_Models.Models.Style? style = Dgv_EditingStyle.SelectedItem as Game_Models.Models.Style;

			if (style is null)
				return;

			TextBox_StyleName.Text = style.Name;
		}


		private async void AddCountry()
		{
			List<string> fields = new()
			{
				TextBox_CountryName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCountryAlready(TextBox_CountryName.Text))
			{
				MessageBox.Show("Така країна вже існує!");
				return;
			}

			_app.AddCountry(TextBox_CountryName.Text);

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private void Dgv_EditingCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Country? country = Dgv_EditingCountry.SelectedItem as Country;

			if (country is null) return;

			TextBox_CountryName.Text = country.Name;
		}


		private async void AddCity()
		{
			List<string> fields = new()
			{
				TextBox_CityName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCityAlready(TextBox_CityName.Text))
			{
				MessageBox.Show("Таке місто вже існує!");
				return;
			}

			Country? country = ComboBox_CityCountry.SelectedItem as Country;

			if (country is not null)
			{
				_app.AddCity(TextBox_CityName.Text, country);

				await _app.SaveAllChanges(Btn_AddItem);
				Switches();
			}
		}


		private void Dgv_EditingCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			City? city = Dgv_EditingCities.SelectedItem as City;

			if (city is null) return;

			TextBox_CityName.Text = city.Name;
			ComboBox_CityCountry.SelectedItem = city.Country;

			Dgv_EditingCityCompanies.ItemsSource = null;
			Dgv_EditingCityCompanies.ItemsSource = city.Companies;

			ComboBox_CompaniesInThisCity.ItemsSource = null;
			ComboBox_CompaniesInThisCity.ItemsSource = city.Companies;
			ComboBox_CompaniesInThisCity.DisplayMemberPath = "Name";
			if (ComboBox_CompaniesInThisCity.Items.Count > 0)
				ComboBox_CompaniesInThisCity.SelectedItem = ComboBox_CompaniesInThisCity.Items[0];
		}


		private async void AddCompany()
		{
			List<string> fields = new()
			{
				TextBox_CompanyName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCompanyAlready(TextBox_CompanyName.Text))
			{
				MessageBox.Show("Така компанія вже існує!");
				return;
			}

			_app.AddCompany(TextBox_CompanyName.Text);

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private void Dgv_EditingCompanies_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Company? company = Dgv_EditingCompanies.SelectedItem as Company;

			if (company is null) return;

			TextBox_CompanyName.Text = company.Name;

			Dgv_EditingCompanyCities.ItemsSource = null;
			Dgv_EditingCompanyCities.ItemsSource = company.Cities;

			ComboBox_CitiesInThisCompany.ItemsSource = null;
			ComboBox_CitiesInThisCompany.ItemsSource = company.Cities;
			ComboBox_CitiesInThisCompany.DisplayMemberPath = "Name";
			if(ComboBox_CitiesInThisCompany.Items.Count > 0)
				ComboBox_CitiesInThisCompany.SelectedItem = ComboBox_CitiesInThisCompany.Items[0];
		}


		private async void AddGame()
		{
			List<string> fields = new()
			{
				TextBox_GameName.Text,
				TextBox_SoldCopies.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereGameAlready(TextBox_GameName.Text))
			{
				MessageBox.Show("Така гра вже існує!");
				return;
			}

			DateTime? date = DatePicker_GameRelease.SelectedDate;
			if (date is null) return;

            Game_Models.Models.Style? style = ComboBox_GameStyle.SelectedItem as Game_Models.Models.Style;
			if (style is null) return;

			Company? company = ComboBox_GameCompany.SelectedItem as Company;
			if (company is null) return;

			string? mode = ComboBox_GameMode.SelectedItem.ToString();
			if (mode is null) return;

			_app.AddGame(TextBox_GameName.Text, (DateTime)date, style, company, mode, Convert.ToInt32(TextBox_SoldCopies.Text));

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private void Dgv_EditingGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Game? game = Dgv_EditingGames.SelectedItem as Game;

			if (game is null) return;

			TextBox_GameName.Text = game.Name;
			DatePicker_GameRelease.SelectedDate = game.ReleaseDate;
			ComboBox_GameStyle.SelectedItem = game.Style;
			ComboBox_GameCompany.SelectedItem = game.Company;
			ComboBox_GameMode.SelectedItem = game.Mode;
			TextBox_SoldCopies.Text = game.SoldCopies.ToString();
		}


		private void Btn_AddItem_Click(object sender, RoutedEventArgs e)
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Games:
						AddGame();
						break;

					case Table.Companies:
						AddCompany();
						break;

					case Table.Countries:
						AddCountry();
						break;

					case Table.Styles:
						AddStyle();
						break;

					case Table.Cities:
						AddCity();
						break;
				}
			}
		}


		private async void UpdateGame()
		{
			List<string> fields = new()
			{
				TextBox_GameName.Text,
				TextBox_SoldCopies.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereGameAlready(TextBox_GameName.Text))
			{
				MessageBox.Show("Така гра вже існує!");
				return;
			}

			Game? game = Dgv_EditingGames.SelectedItem as Game;

			if (game is null) return;

			game.Name = TextBox_GameName.Text;
			game.ReleaseDate = (DateTime)DatePicker_GameRelease.SelectedDate;
			game.Style = ComboBox_GameStyle.SelectedItem as Game_Models.Models.Style;
			game.Company = ComboBox_GameCompany.SelectedItem as Company;
			game.Mode = ComboBox_GameMode.SelectedItem.ToString();
			game.SoldCopies = Convert.ToInt32(TextBox_SoldCopies.Text);

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}


		private async void UpdateCompany()
		{
			List<string> fields = new()
			{
				TextBox_CompanyName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCompanyAlready(TextBox_CompanyName.Text))
			{
				MessageBox.Show("Така компанія вже існує!");
				return;
			}

			Company? company = Dgv_EditingCompanies.SelectedItem as Company;

			if (company is null) return;

			company.Name = TextBox_CityName.Text;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}


		private async void UpdateCountry()
		{
			List<string> fields = new()
			{
				TextBox_CountryName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCountryAlready(TextBox_CountryName.Text))
			{
				MessageBox.Show("Така країна вже існує!");
				return;
			}

			Country? country = Dgv_EditingCountry.SelectedItem as Country;

			if (country is null) return;

			country.Name = TextBox_CountryName.Text;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}


		private async void UpdateStyle()
		{
			List<string> fields = new()
			{
				TextBox_StyleName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereStyleAlready(TextBox_StyleName.Text))
			{
				MessageBox.Show("Такий стиль вже існує!");
				return;
			}

			Game_Models.Models.Style? style = Dgv_EditingStyle.SelectedItem as Game_Models.Models.Style;

			if (style is null)
				return;

			style.Name = TextBox_StyleName.Text;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}


		private async void UpdateCity()
		{
			List<string> fields = new()
			{
				TextBox_CityName.Text
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereCityAlready(TextBox_CityName.Text))
			{
				MessageBox.Show("Таке місто вже існує!");
				return;
			}

			City? city = Dgv_EditingCities.SelectedItem as City;

			if (city is null) return;

			city.Name = TextBox_CityName.Text;
			city.Country = ComboBox_CityCountry.SelectedItem as Country;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}


		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Games:
						UpdateGame();
						break;

					case Table.Companies:
						UpdateCompany();
						break;

					case Table.Countries:
						UpdateCountry();
						break;

					case Table.Styles:
						UpdateStyle();
						break;

					case Table.Cities:
						UpdateCity();
						break;
				}
			}
		}


		private async void DeleteGame()
		{
			if (string.IsNullOrEmpty(TextBox_GameName.Text)) return;

			Game? game = _app.GetGameByName(TextBox_GameName.Text);

			if (game is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гру?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveGame(game);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void DeleteCompany()
		{
			if (string.IsNullOrEmpty(TextBox_CompanyName.Text)) return;

			Company? company = _app.GetCompanyByName(TextBox_CompanyName.Text);

			if (company is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гру?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveCompany(company);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void DeleteCountry()
		{
			if (string.IsNullOrEmpty(TextBox_CountryName.Text)) return;

			Country? country = _app.GetCountryByName(TextBox_CountryName.Text);

			if (country is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гру?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveCountry(country);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void DeleteStyle()
		{
			if (string.IsNullOrEmpty(TextBox_StyleName.Text)) return;

            Game_Models.Models.Style? style = _app.GetStyleByName(TextBox_StyleName.Text);

			if (style is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гру?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveStyle(style);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void DeleteCity()
		{
			if (string.IsNullOrEmpty(TextBox_CityName.Text)) return;

			City? city = _app.GetCityByName(TextBox_CityName.Text);

			if (city is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гру?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveCity(city);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private void Btn_RemoveItem_Click(object sender, RoutedEventArgs e)
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Games:
						DeleteGame();
						break;

					case Table.Companies:
						DeleteCompany();
						break;

					case Table.Countries:
						DeleteCountry();
						break;

					case Table.Styles:
						DeleteStyle();
						break;

					case Table.Cities:
						DeleteCity();
						break;
				}
			}
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

		private void SingleValueTable(int count, string column)
		{
			DataTable table = new();

			table.Columns.Add(column);
			table.Rows.Add(count);

			Dgv_Queries.ItemsSource = null;
			Dgv_Queries.ItemsSource = table.AsDataView();
		}

		private async void Btn_CountOfSingleplayerGames_Click(object sender, RoutedEventArgs e)
		{
			SingleValueTable(await _app.CountOfSingleplayerGames(), "Count of singleplayer games");
		}

		private async void Btn_CountOfMultiplayerGames_Click(object sender, RoutedEventArgs e)
		{
			SingleValueTable(await _app.CountOfMultiplayerGames(), "Count of multiplayer games");
		}

		private async void Btn_GameWithMostSoldCopies_Click(object sender, RoutedEventArgs e)
		{
			Game_Models.Models.Style? style = ComboBox_GameWithMostSoldCopies.SelectedItem as Game_Models.Models.Style;

			if (style is null) return;

			Dgv_Queries.ItemsSource = await _app.GameWithMostSoldCopies(style);
		}

		private async void Btn_Top5GamesWithMostSoldCopies_Click(object sender, RoutedEventArgs e)
		{
			Game_Models.Models.Style? style = ComboBox_Top5GamesWithMostSoldCopies.SelectedItem as Game_Models.Models.Style;

			if (style is null) return;

			Dgv_Queries.ItemsSource = await _app.Top5GamesWithMostSoldCopies(style);
		}

		private async void Btn_Top5GamesWithLowestSoldCopies_Click(object sender, RoutedEventArgs e)
		{
			Game_Models.Models.Style? style = ComboBox_Top5GamesWithLowestSoldCopies.SelectedItem as Game_Models.Models.Style;

			if (style is null) return;

			Dgv_Queries.ItemsSource = await _app.Top5GamesWithLowestSoldCopies(style);
		}

		private async void Btn_AllInfoAboutGames_Click(object sender, RoutedEventArgs e)
		{
			var collection = await _app.AllInfoAboutGames();
			Dgv_Queries.ItemsSource = await _app.AllInfoAboutGames();
		}

		private async void Btn_CompaniesAndStylesWithMostCount_Click(object sender, RoutedEventArgs e)
		{
			Dgv_Queries.ItemsSource = await _app.CompaniesAndStylesWithMostCount();
		}
	}
}
