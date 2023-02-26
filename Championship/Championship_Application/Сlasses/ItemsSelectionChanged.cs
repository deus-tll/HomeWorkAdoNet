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
		private void DataGrid_EditingPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Player? player = DataGrid_EditingPlayers.SelectedItem as Player;
			if (player == null) return;


			TextBox_PlayerPIB.Text = player.PIB;
			TextBox_PlayerCountry.Text = player.Country;
			TextBox_PlayerNumber.Text = player.Number.ToString();
			TextBox_PlayerPosition.Text = player.Position;
		}

		private void DataGrid_EditingMatches_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Match? match = DataGrid_EditingMatches.SelectedItem as Match;
			if (match is null) return;

			DatePicker_MatchDate.SelectedDate = match.DateOfTheMatch;
			ComboBox_MatchTeam1.SelectedItem = match.Team1;
			ComboBox_MatchTeam2.SelectedItem = match.Team2;

			DataGrid_EditingMatchesGoals.ItemsSource = null;
			DataGrid_EditingMatchesGoals.ItemsSource = match.Goals;
		}

		private void DataGrid_EditingGoals_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Goal? goal = DataGrid_EditingGoals.SelectedItem as Goal;
			if (goal is null) return;

			TextBox_GoalMatchId.Text = goal.MatchId.ToString();
			ComboBox_GoalPlayer.SelectedItem = goal.Player;
			TextBox_GoalTime.Text = goal.Time.ToString();
			TextBox_GoalMinute.Text = goal.Minute.ToString();
		}

		private void DataGrid_EditingTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Team? team = DataGrid_EditingTeams.SelectedItem as Team;

			if (team is null)
				return;

			TextBox_TeamName.Text = team.Name;
			TextBox_TeamCity.Text = team.City;
			TextBox_NumberOfWins.Text = team.NumberOfWins.ToString();
			TextBox_NumberOfDefeats.Text = team.NumberOfDefeats.ToString();
			TextBox_NumberOfDraws.Text = team.NumberOfDraws.ToString();
			TextBox_NumberOfGoalsScored.Text = team.NumberOfGoalsScored.ToString();
			TextBox_NumberOfMissedGoals.Text = team.NumberOfMissedGoals.ToString();

			DataGrid_EditingTeamsPlayers.ItemsSource = team.Players;
		}
	}
}
