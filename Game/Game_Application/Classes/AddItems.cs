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
	}
}
