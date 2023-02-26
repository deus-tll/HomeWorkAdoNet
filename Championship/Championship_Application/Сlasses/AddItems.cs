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
		private void Btn_AddItem_Click(object sender, RoutedEventArgs e)
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Players:
						AddPlayer();
						break;

					case Table.Matches:
						AddMatch();
						break;

					case Table.Teams:
						AddTeam();
						break;

					case Table.Goals:
						AddGoal();
						break;
				}
			}
		}

		private async void AddPlayer()
		{
			List<string> fields = new()
			{
				TextBox_PlayerPIB.Text,
				TextBox_PlayerCountry.Text,
				TextBox_PlayerNumber.Text,
				TextBox_PlayerPosition.Text
			};

			Team? team = ComboBox_PlayerTeam.SelectedItem as Team;
			if (team is null) return;

			if (!CheckFields(fields))
				return;

			_app.AddPlayer(TextBox_PlayerPIB.Text, TextBox_PlayerCountry.Text, Convert.ToInt16(TextBox_PlayerNumber.Text), TextBox_PlayerPosition.Text, team);

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private async void AddMatch()
		{
			DateTime? date = DatePicker_MatchDate.SelectedDate;
			if (date is null) return;

			Team? team1 = ComboBox_MatchTeam1.SelectedItem as Team;
			if (team1 is null) return;

			Team? team2 = ComboBox_MatchTeam2.SelectedItem as Team;
			if (team2 is null) return;

			if (team1 == team2)
			{
				MessageBox.Show("Команди повинні бути різними!");
				return;
			}

			if (_app.IsThereMatchAlready(team1.ID, team2.ID, (DateTime)date))
			{
				MessageBox.Show("Такий матч вже існує!");
				return;
			}

			_app.AddMatch(team1, team2, (DateTime)date);

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private async void AddTeam()
		{
			List<string> fields = new()
			{
				TextBox_TeamName.Text,
				TextBox_TeamCity.Text,
				TextBox_NumberOfWins.Text,
				TextBox_NumberOfDefeats.Text,
				TextBox_NumberOfDraws.Text,
				TextBox_NumberOfGoalsScored.Text,
				TextBox_NumberOfMissedGoals.Text,
			};

			if (!CheckFields(fields))
				return;

			if (_app.IsThereTeamAlready(TextBox_TeamName.Text, TextBox_TeamCity.Text))
			{
				MessageBox.Show("Така команда вже існує!");
				return;
			}

			_app.AddTeam(TextBox_TeamName.Text,
						 TextBox_TeamCity.Text,
						 Convert.ToInt32(TextBox_NumberOfWins.Text),
						 Convert.ToInt32(TextBox_NumberOfDefeats.Text),
						 Convert.ToInt32(TextBox_NumberOfDraws.Text),
						 Convert.ToInt32(TextBox_NumberOfGoalsScored.Text),
						 Convert.ToInt32(TextBox_NumberOfMissedGoals.Text));

			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}


		private async void AddGoal()
		{
			List<string> fields = new()
			{
				TextBox_GoalMatchId.Text,
				TextBox_GoalTime.Text,
				TextBox_GoalMinute.Text,
			};

			if (!CheckFields(fields))
				return;

			Match? match = _app.GetMatchById(Convert.ToInt32(TextBox_GoalMatchId.Text));
			if (match is null) return;

			Player? player = ComboBox_GoalPlayer.SelectedItem as Player;
			if (player is null) return;

			_app.AddGoal(match, player, Convert.ToInt16(TextBox_GoalTime.Text), Convert.ToInt16(TextBox_GoalMinute.Text));


			await _app.SaveAllChanges(Btn_AddItem);
			Switches();
		}
	}
}
