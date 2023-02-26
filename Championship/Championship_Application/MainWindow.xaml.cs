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
	}
}
