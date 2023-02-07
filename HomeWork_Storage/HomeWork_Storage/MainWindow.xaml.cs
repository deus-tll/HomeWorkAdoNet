using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace HomeWork_Storage
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly StorageDB DB = new StorageDB();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void UpdateTablesList()
		{
			string query = "select table_name from INFORMATION_SCHEMA.TABLES";
			Cmb_TablesList.ItemsSource = DB.GetTable(query).AsDataView();
			if (Cmb_TablesList.Items.Count == 0)
				return;
			
			Cmb_TablesList.DisplayMemberPath = "table_name";
			Cmb_TablesList.SelectedValuePath = "table_name";
			Cmb_TablesList.SelectedItem = Cmb_TablesList.Items[0];
		}

		private void UpdateDataGrid(string query)
		{
			recordsListQueries.ItemsSource = null;
			recordsListQueries.ItemsSource = DB.GetTable(query).AsDataView();
		}

		private void Btn_Disconnect_Click(object sender, RoutedEventArgs e)
		{
			DB.DisconnectBase();
		}

		private void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			DB.ConnectBase();
			UpdateTablesList();
		}

		private void Btn_ProviderWithMoreProducts_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([ProviderName] nvarchar(max), [Address]nvarchar(max), [MaxInStock] int);\r\n" +
				"declare @MaxInStock int;\r\n\r\n" +
				"insert into @table\r\n" +
				"select\r\n\t" +
				"Pv.[Name] as [ProviderName],\r\n\t" +
				"Pv.[Address],\r\n\t" +
				"Sum(Pd.[InStock]) as [InStock]\r\n" +
				"from\r\n\t" +
				"[Products] as Pd join [Providers] as Pv on\r\n\t" +
				"Pd.[ProviderID] = Pv.[ID]\r\n" +
				"group by\r\n\t" +
				"Pv.[Name],\r\n\t" +
				"Pv.[Address]\r\n\r\n" +
				"select @MaxInStock = Max(t.MaxInStock)\r\n" +
				"from @table as t\r\n\r\n" +
				"select *\r\n" +
				"from @table as t\r\n" +
				"where t.[MaxInStock] = @MaxInStock";

			UpdateDataGrid(query);
		}

		private void Btn_ProviderWithLessProducts_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([ProviderName] nvarchar(max), [Address]nvarchar(max), [MinInStock] int);\r\n" +
				"declare @MinInStock int;\r\n\r\n" +
				"insert into @table\r\n" +
				"select\r\n\t" +
				"Pv.[Name] as [ProviderName],\r\n\t" +
				"Pv.[Address],\r\n\t" +
				"Sum(Pd.[InStock]) as [InStock]\r\n" +
				"from\r\n\t" +
				"[Products] as Pd join [Providers] as Pv on\r\n\t" +
				"Pd.[ProviderID] = Pv.[ID]\r\n" +
				"group by\r\n\t" +
				"Pv.[Name],\r\n\t" +
				"Pv.[Address]\r\n\r\n" +
				"select @MinInStock = Min(t.MinInStock)\r\n" +
				"from @table as t\r\n\r\n" +
				"select *\r\n" +
				"from @table as t\r\n" +
				"where t.[MinInStock] = @MinInStock";

			UpdateDataGrid(query);
		}

		private void Btn_TypeOfProductWithMostUnitsCount_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([TypeName] nvarchar(max), [MaxUnits] int);\r\n" +
				"declare @MaxUnits int;\r\n\r\n" +
				"insert into @table\r\n" +
				"select \r\n\t" +
				"T.[Name] as [Type Name],\r\n\t" +
				"Sum(P.[ID]) as [Units of the product]\r\n" +
				"from\r\n\t" +
				"[Products] as P join [Types] as T on \r\n\t" +
				"P.[TypeID] = T.[ID]\r\n" +
				"group by \r\n\t" +
				"T.[Name];\r\n\r\n" +
				"select @MaxUnits = Max(t.[MaxUnits])\r\n" +
				"from @table as t;\r\n\r\n" +
				"select *\r\n" +
				"from @table as t\r\n" +
				"where t.[MaxUnits] = @MaxUnits;";

			UpdateDataGrid(query);
		}

		private void Btn_TypeOfProductWithLessProductsCount_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([TypeName] nvarchar(max), [MinInStock] int);\r\n" +
				"declare @MinInStock int;\r\n\r\n" +
				"insert into @table\r\n" +
				"select \r\n\t" +
				"T.[Name] as [TypeName],\r\n\t" +
				"Sum(P.[InStock]) as [InStock]\r\n" +
				"from\r\n\t" +
				"[Products] as P join [Types] as T on \r\n\t" +
				"P.[TypeID] = T.[ID]\r\n" +
				"group by \r\n\t" +
				"T.[Name]\r\n\r\n" +
				"select @MinInStock = Min(t.MinInStock)\r\n" +
				"from @table as t\r\n\r\n" +
				"select *\r\n" +
				"from @table as t\r\n" +
				"where t.[MinInStock] = @MinInStock";

			UpdateDataGrid(query);
		}

		private void Btn_ProductsFromDeliveryDatePassSpecCountOfDays_Click(object sender, RoutedEventArgs e)
		{
			string query = "select\r\n\t" +
				"PD.[Name] as [Product`s Name],\r\n\t" +
				"PV.[Name] as [Provider`s Name],\r\n\t" +
				"T.[Name] as [Type Name],\r\n\t" +
				"PD.[InStock] as [In Stock],\r\n\t" +
				"PD.[CostPrice] as [Cost Price],\r\n\t" +
				"PD.[DeliveryDate] as [Delivery Date]\r\n" +
				"from\r\n\t" +
				"[Products] as PD join [Providers] as PV on \r\n\t" +
				"PD.[ProviderID] = PV.[ID]\r\n\r\n\t" +
				"join [Types] as T on\r\n\t" +
				"PD.[TypeID] = T.[ID]\r\n" +
				"where\r\n\t" +
				$"DateDiff(day, PD.[DeliveryDate], getdate()) > {TextBox_CountDays.Text}";

			UpdateDataGrid(query);
		}

		private void TextBox_CountDays_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !int.TryParse(e.Text, out int result);
		}

		private void Btn_UpdateTablesList_Click(object sender, RoutedEventArgs e)
		{
			UpdateTablesList();
		}

		private void Btn_ReadData_Click(object sender, RoutedEventArgs e)
		{
			recordsListEditing.ItemsSource = null;
			if (Cmb_TablesList.Items.Count == 0)
				return;
			
			recordsListEditing.ItemsSource = DB.GetData(Cmb_TablesList.SelectedValue.ToString()).AsDataView();
		}

		private void Btn_SaveChanges_Click(object sender, RoutedEventArgs e)
		{
			DB.SaveChanges();
			Btn_ReadData_Click(null, null);
		}
	}
}
