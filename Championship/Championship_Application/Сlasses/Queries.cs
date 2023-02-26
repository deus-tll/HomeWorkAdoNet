using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Championship_Application
{
	public partial class MainWindow : Window
	{
		private void Btn_FindTeamByName_Click(object sender, RoutedEventArgs e)
		{
			if (TextBox_FindTeamByName.Text is not "")
			{
				Dgv_RecordsListQueries.ItemsSource = _app.FindTeamByName(TextBox_FindTeamByName.Text);
			}
		}


		private void Btn_FindTeamsByCity_Click(object sender, RoutedEventArgs e)
		{
			if (TextBox_FindTeamsByCity.Text is not "")
			{
				Dgv_RecordsListQueries.ItemsSource = _app.FindTeamsByCity(TextBox_FindTeamsByCity.Text);
			}
		}


		private void Btn_FindInfoByNameAndCity_Click(object sender, RoutedEventArgs e)
		{
			if (TextBox_FindInfoByTeam.Text is not "" && TextBox_FindInfoByCity.Text is not "")
			{
				Dgv_RecordsListQueries.ItemsSource = _app.FindInfoByNameAndCity(TextBox_FindInfoByTeam.Text, TextBox_FindInfoByCity.Text);
			}
		}


		private void Btn_GetTeamWithMostWins_Click(object sender, RoutedEventArgs e)
		{
			Dgv_RecordsListQueries.ItemsSource = _app.GetTeamWithMostWins();
		}


		private void Btn_GetTeamWithMostLosses_Click(object sender, RoutedEventArgs e)
		{
			Dgv_RecordsListQueries.ItemsSource = _app.GetTeamWithMostLosses();
		}


		private void Btn_GetTeamWithMostDraws_Click(object sender, RoutedEventArgs e)
		{
			Dgv_RecordsListQueries.ItemsSource = _app.GetTeamWithMostDraws();
		}


		private void Btn_GetTeamWithMostGoalsScored_Click(object sender, RoutedEventArgs e)
		{
			Dgv_RecordsListQueries.ItemsSource = _app.GetTeamWithMostGoalsScored();
		}


		private void Btn_GetTeamWithMostMissedGoals_Click(object sender, RoutedEventArgs e)
		{
			Dgv_RecordsListQueries.ItemsSource = _app.GetTeamWithMostMissedGoals();
		}
	}
}
