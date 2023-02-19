using Championship_Application.Сlasses;
using Championship_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;


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
			switch (table)
			{
				case Table.Teams: Dgv_RecordsListEditing.ItemsSource = _app.GetTeams(); break;
			}
		}


		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Cmb_TablesList.ItemsSource = Enum.GetValues(typeof(Table)).Cast<Table>();
			Cmb_TablesList.SelectedItem = Cmb_TablesList.Items[0];
		}


		private void Btn_ReadDataByTables_Click(object sender, RoutedEventArgs e)
		{
			Table table = (Table)Cmb_TablesList.SelectedValue;

			FillDataGridOnEditingPage(table);
		}


		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			_app.SaveChanges();
		}
	}
}
