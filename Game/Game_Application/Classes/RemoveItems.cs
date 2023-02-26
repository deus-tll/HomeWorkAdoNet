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
	}
}
