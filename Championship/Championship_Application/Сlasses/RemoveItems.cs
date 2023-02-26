using Championship_Application.Сlasses;
using Championship_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Championship_Application
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
					case Table.Players:
						RemovePlayer();
						break;

					case Table.Matches:
						RemoveMatch();
						break;

					case Table.Teams:
						RemoveTeam();
						break;

					case Table.Goals:
						RemoveGoal();
						break;
				}
			}
		}


		private async void RemovePlayer()
		{
			List<string> fields = new()
			{
				TextBox_PlayerPIB.Text,
				TextBox_PlayerCountry.Text,
				TextBox_PlayerNumber.Text
			};

			if (!CheckFields(fields))
				return;

			Player? player = _app.GetPlayer(TextBox_PlayerPIB.Text, TextBox_PlayerCountry.Text, Convert.ToInt16(TextBox_PlayerNumber.Text));
			if (player is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити гравця?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemovePlayer(player);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void RemoveMatch()
		{
			Team? team1 = ComboBox_MatchTeam1.SelectedItem as Team;
			if (team1 is null) return;

			Team? team2 = ComboBox_MatchTeam2.SelectedItem as Team;
			if (team2 is null) return;

			DateTime? date = DatePicker_MatchDate.SelectedDate;
			if (date is null) return;

			Match? match = _app.GetMatch(team1, team2, (DateTime)date);
			if (match is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити матч?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveMatch(match);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void RemoveTeam()
		{
			if (string.IsNullOrEmpty(TextBox_TeamName.Text) || string.IsNullOrEmpty(TextBox_TeamCity.Text))
				return;

			Team? team = _app.GetTeamByNameAndCity(TextBox_TeamName.Text, TextBox_TeamCity.Text);

			if (team is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити команду?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveTeam(team);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}


		private async void RemoveGoal()
		{
			Goal? goal = DataGrid_EditingGoals.SelectedItem as Goal;
			if (goal is null) return;

			MessageBoxResult result = MessageBox.Show("Видалити інформацію про гол?", "Підтвердити...", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result != MessageBoxResult.Yes) return;

			_app.RemoveGoal(goal);

			await _app.SaveAllChanges(Btn_RemoveItem);
			Switches();
		}
	}
}
