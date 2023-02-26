using Championship_Application.Сlasses;
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
		private void FillTabItemHeaders()
		{
			TabItem_Players.Header = Table.Players;
			TabItem_Teams.Header = Table.Teams;
			TabItem_Matches.Header = Table.Matches;
			TabItem_Goals.Header = Table.Goals;
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
					case Table.Players:
						SwitchToPlayersPage();
						break;

					case Table.Matches:
						SwitchToMatchesPage();
						break;

					case Table.Teams:
						SwitchToTeamsPage();
						break;

					case Table.Goals:
						SwitchToGoalsPage();
						break;
				}
			}
		}


		private void SwitchToPlayersPage()
		{
			DataGrid_EditingPlayers.ItemsSource = _app.GetPlayers();
		}

		private void SwitchToMatchesPage()
		{
			DataGrid_EditingMatches.ItemsSource = _app.GetMatches();

			var collection = _app.GetTeams();
			ComboBox_MatchTeam1.ItemsSource = collection;
			if (ComboBox_MatchTeam1.Items.Count > 0)
				ComboBox_MatchTeam1.SelectedItem = ComboBox_MatchTeam1.Items[0];

			ComboBox_MatchTeam2.ItemsSource = collection;
			if (ComboBox_MatchTeam2.Items.Count > 0)
				ComboBox_MatchTeam2.SelectedItem = ComboBox_MatchTeam2.Items[0];
		}

		private void SwitchToTeamsPage()
		{
			DataGrid_EditingTeams.ItemsSource = _app.GetTeams();

			ComboBox_AllPlayers.ItemsSource = _app.GetPlayers();
			if (ComboBox_AllPlayers.Items.Count > 0)
				ComboBox_AllPlayers.SelectedItem = ComboBox_AllPlayers.Items[0];
		}

		private void SwitchToGoalsPage()
		{
			DataGrid_EditingGoals.ItemsSource = _app.GetGoals();

			ComboBox_GoalPlayer.ItemsSource = _app.GetPlayers();
			if (ComboBox_GoalPlayer.Items.Count > 0)
				ComboBox_GoalPlayer.SelectedItem = ComboBox_GoalPlayer.Items[0];
		}
	}
}
