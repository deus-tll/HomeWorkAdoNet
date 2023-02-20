using Championship_Application.Сlasses;
using Championship_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Championship_Application
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly Championship _app = new();


		public MainWindow()
		{
			InitializeComponent();
		}


		private void FillDataGridOnEditingPage(Table table)
		{
			Dgv_RecordsListEditing.ItemsSource = null;

			switch (table)
			{
				case Table.Teams: Dgv_RecordsListEditing.ItemsSource = _app.GetTeams(); break;
			}
		}


		private bool CheckTeamFields()
		{
			if (string.IsNullOrEmpty(TextBox_TeamName.Text) ||
				string.IsNullOrEmpty(TextBox_TeamCity.Text) ||
				string.IsNullOrEmpty(TextBox_NumberOfWins.Text) ||
				string.IsNullOrEmpty(TextBox_NumberOfDefeats.Text) ||
				string.IsNullOrEmpty(TextBox_NumberOfDraws.Text) ||
				string.IsNullOrEmpty(TextBox_NumberOfGoalsScored.Text) ||
				string.IsNullOrEmpty(TextBox_NumberOfMissedGoals.Text))
			{
				return false;
			}

			return true;
		}


		private async void AddTeam()
		{
			if (!CheckTeamFields())
			{
				MessageBox.Show("Всі поля мають бути заповнені!");
				return;
			}

			if (_app.IsTeamAlreadyInBase(TextBox_TeamName.Text, TextBox_TeamCity.Text))
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
			FillDataGridOnEditingPage(Table.Teams);
		}


		private async void UpdateTeamInfo()
		{
			if (!CheckTeamFields())
			{
				MessageBox.Show("Всі поля мають бути заповнені!");
				return;
			}

			if (_app.IsTeamAlreadyInBase(TextBox_TeamName.Text, TextBox_TeamCity.Text))
			{
				MessageBox.Show("Така команда вже існує!");
				return;
			}

			Team? team = Dgv_RecordsListEditing.SelectedItem as Team;

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
			FillDataGridOnEditingPage(Table.Teams);
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
			FillDataGridOnEditingPage(Table.Teams);
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Cmb_TablesList.ItemsSource = Enum.GetValues(typeof(Table)).Cast<Table>();
			Cmb_TablesList.SelectedItem = Cmb_TablesList.Items[0];
		}


		private void Dgv_RecordsListEditing_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			Team? team = Dgv_RecordsListEditing.SelectedItem as Team;

			if (team is null)
				return;

			TextBox_TeamName.Text = team.Name;
			TextBox_TeamCity.Text = team.City;
			TextBox_NumberOfWins.Text = team.NumberOfWins.ToString();
			TextBox_NumberOfDefeats.Text = team.NumberOfDefeats.ToString();
			TextBox_NumberOfDraws.Text = team.NumberOfDraws.ToString();
			TextBox_NumberOfGoalsScored.Text = team.NumberOfGoalsScored.ToString();
			TextBox_NumberOfMissedGoals.Text = team.NumberOfMissedGoals.ToString();
		}


		private void Btn_ReadDataByTables_Click(object sender, RoutedEventArgs e)
		{
			Table table = (Table)Cmb_TablesList.SelectedValue;

			FillDataGridOnEditingPage(table);
		}


		private void Btn_AddItem_Click(object sender, RoutedEventArgs e)
		{
			switch ((Table)Cmb_TablesList.SelectedValue)
			{
				case Table.Teams: AddTeam(); break;
			}
		}


		private void Btn_RemoveItem_Click(object sender, RoutedEventArgs e)
		{
			switch ((Table)Cmb_TablesList.SelectedValue)
			{
				case Table.Teams: RemoveTeam(); break;
			}
		}


		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			switch ((Table)Cmb_TablesList.SelectedValue)
			{
				case Table.Teams: UpdateTeamInfo(); break;
			}
		}


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


		private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out _);
		}
	}
}
