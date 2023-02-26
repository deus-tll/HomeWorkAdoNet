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
			FillTabItemHeaders();
		}

		


		private static bool CheckFields(List<string> fields)
		{
			foreach (var field in fields)
			{
				if (string.IsNullOrEmpty(field))
				{
					MessageBox.Show("Всі поля мають бути заповнені!");
					return false;
				}
			}

			return true;
		}


		private void TextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out _);
		}
		

		private async void Btn_AddPlayerToTheTeam_Click(object sender, RoutedEventArgs e)
		{
			Team? team = DataGrid_EditingTeams.SelectedItem as Team;
			if (team is null) return;

			Player? player = ComboBox_AllPlayers.SelectedItem as Player;
			if (player is null) return;

			if (team is not null && player is not null)
			{
				if (_app.IsTherePlayerAlreadyInTeam(team.ID, player.ID))
				{
					MessageBox.Show("В данній команді вже є такий гравець!");
					return;
				}

				team.Players.Add(player);
				await _app.SaveAllChanges(Btn_AddPlayerToTheTeam);
				Switches();
			}
			else
			{
				MessageBox.Show("Оберіть команду з таблиці!");
			}
		}

		private void Btn_RemovePlayerFromTheTeam_Click(object sender, RoutedEventArgs e)
		{
			Team? team = DataGrid_EditingTeams.SelectedItem as Team;
			if (team is null) return;

			if (team.Players.Count == 0) return;

			Player? player = DataGrid_EditingTeamsPlayers.SelectedItem as Player;
			if (player is null) return;

			team.Players.Remove(player);
		}

		
	}
}
