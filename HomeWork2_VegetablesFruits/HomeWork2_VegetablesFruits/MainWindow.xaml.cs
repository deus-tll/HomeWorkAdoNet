using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork2_VegetablesFruits
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly VegetablesFruitsDB DB = new();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Btn_GetProviders_Click(object sender, RoutedEventArgs e)
		{
			Cmb_Providers.Items.Clear();
			Cmb_Providers.ItemsSource = DB.GetProvidersList();
		}

		private void Cmb_Providers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			TxtBox_ConnectionString.Text =  DB.ChangingProvider(Cmb_Providers.SelectedItem.ToString());
		}

		private void Btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DB.DisconnectBase();
		}

		private void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			DB.ConnectBase();
		}
	}
}
