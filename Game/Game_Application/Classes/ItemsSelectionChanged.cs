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



		private void Dgv_EditingStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Game_Models.Models.Style? style = Dgv_EditingStyle.SelectedItem as Game_Models.Models.Style;

			if (style is null)
				return;

			TextBox_StyleName.Text = style.Name;
		}


		private void Dgv_EditingCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Country? country = Dgv_EditingCountry.SelectedItem as Country;

			if (country is null) return;

			TextBox_CountryName.Text = country.Name;
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
			if (ComboBox_CitiesInThisCompany.Items.Count > 0)
				ComboBox_CitiesInThisCompany.SelectedItem = ComboBox_CitiesInThisCompany.Items[0];
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
	}
}
