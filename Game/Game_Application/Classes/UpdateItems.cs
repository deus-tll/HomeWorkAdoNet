using Game_Application.Classes;
using Game_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Game_Application
{
	public partial class MainWindow : Window
	{
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
	}
}
