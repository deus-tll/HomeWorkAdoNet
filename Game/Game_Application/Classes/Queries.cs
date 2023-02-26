using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game_Application
{
	public partial class MainWindow : Window
	{
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
