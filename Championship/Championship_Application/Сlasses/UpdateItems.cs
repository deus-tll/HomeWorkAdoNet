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
		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			TabItem? tabItem = TabControl_Editing.SelectedItem as TabItem;

			if (tabItem is not null)
			{
				switch ((Table)tabItem.Header)
				{
					case Table.Players:
						UpdatePlayer();
						break;

					case Table.Matches:
						UpdateMatch();
						break;

					case Table.Teams:
						UpdateTeam();
						break;

					case Table.Goals:
						UpdateGoal();
						break;
				}
			}
		}


		private async void UpdatePlayer()
		{
			List<string> fields = new()
			{
				TextBox_PlayerPIB.Text,
				TextBox_PlayerCountry.Text,
				TextBox_PlayerNumber.Text,
				TextBox_PlayerPosition.Text
			};

			if (!CheckFields(fields))
				return;

			Player? player = DataGrid_EditingPlayers.SelectedItem as Player;
			if (player == null) return;


			player.PIB = TextBox_PlayerPIB.Text;
			player.Country = TextBox_PlayerCountry.Text;
			player.Number = Convert.ToInt16(TextBox_PlayerNumber.Text);
			player.Position = TextBox_PlayerPosition.Text;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}

		private async void UpdateMatch()
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

			Match? match = DataGrid_EditingMatches.SelectedItem as Match;
			if (match is null) return;

			match.Team1 = team1;
			match.Team2 = team2;
			match.DateOfTheMatch = (DateTime)date;

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}

		private async void UpdateTeam()
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

			Team? team = DataGrid_EditingTeams.SelectedItem as Team;

			if (team is null)
				return;

			team.Name = TextBox_TeamName.Text;
			team.City = TextBox_TeamCity.Text;
			team.NumberOfWins = Convert.ToInt32(TextBox_NumberOfWins.Text);
			team.NumberOfDefeats = Convert.ToInt32(TextBox_NumberOfDefeats.Text);
			team.NumberOfDraws = Convert.ToInt32(TextBox_NumberOfDraws.Text);
			team.NumberOfGoalsScored = Convert.ToInt32(TextBox_NumberOfGoalsScored.Text);
			team.NumberOfMissedGoals = Convert.ToInt32(TextBox_NumberOfMissedGoals.Text);

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}

		private async void UpdateGoal()
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

			Goal? goal = DataGrid_EditingGoals.SelectedItem as Goal;
			if (goal is null) return;

			goal.Match = match;
			goal.MatchId = match.Id;
			goal.Player = player;
			goal.Time = Convert.ToInt16(TextBox_GoalTime.Text);
			goal.Minute = Convert.ToInt16(TextBox_GoalMinute.Text);

			await _app.SaveAllChanges(Btn_SaveChanges);
			Switches();
		}
	}
}
