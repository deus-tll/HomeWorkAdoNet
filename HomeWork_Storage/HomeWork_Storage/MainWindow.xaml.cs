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
			Cmb_TablesList.ItemsSource = null;
		}

		private void Btn_Connect_Click(object sender, RoutedEventArgs e)
		{
			DB.ConnectBase();
			UpdateTablesList();
		}

		private void Btn_ProviderWithMoreProducts_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([ProviderName] nvarchar(max), [Address]nvarchar(max), [MaxInStock] int); " +
				"declare @MaxInStock int; " +
				"insert into @table " +
				"select " +
				"Pv.[Name] as [ProviderName], " +
				"Pv.[Address], " +
				"Sum(Pd.[InStock]) as [InStock] " +
				"from " +
				"[Products] as Pd join [Providers] as Pv on " +
				"Pd.[ProviderID] = Pv.[ID] " +
				"group by " +
				"Pv.[Name], " +
				"Pv.[Address] " +
				"select @MaxInStock = Max(t.MaxInStock) " +
				"from @table as t " +
				"select * " +
				"from @table as t " +
				"where t.[MaxInStock] = @MaxInStock";

			UpdateDataGrid(query);
		}

		private void Btn_ProviderWithLessProducts_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([ProviderName] nvarchar(max), [Address]nvarchar(max), [MinInStock] int); " +
				"declare @MinInStock int;  " +
				"insert into @table " +
				"select " +
				"Pv.[Name] as [ProviderName], " +
				"Pv.[Address], " +
				"Sum(Pd.[InStock]) as [InStock] " +
				"from " +
				"[Products] as Pd join [Providers] as Pv on " +
				"Pd.[ProviderID] = Pv.[ID] " +
				"group by " +
				"Pv.[Name], " +
				"Pv.[Address]  " +
				"select @MinInStock = Min(t.MinInStock) " +
				"from @table as t  " +
				"select * " +
				"from @table as t " +
				"where t.[MinInStock] = @MinInStock";

			UpdateDataGrid(query);
		}

		private void Btn_TypeOfProductWithMostUnitsCount_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([TypeName] nvarchar(max), [MaxUnits] int); " +
				"declare @MaxUnits int; " +
				"insert into @table " +
				"select  " +
				"T.[Name] as [Type Name], " +
				"Sum(P.[ID]) as [Units of the product] " +
				"from " +
				"[Products] as P join [Types] as T on  " +
				"P.[TypeID] = T.[ID] " +
				"group by " +
				"T.[Name]; " +
				"select @MaxUnits = Max(t.[MaxUnits]) " +
				"from @table as t;  " +
				"select * " +
				"from @table as t " +
				"where t.[MaxUnits] = @MaxUnits;";

			UpdateDataGrid(query);
		}

		private void Btn_TypeOfProductWithLessProductsCount_Click(object sender, RoutedEventArgs e)
		{
			string query = "declare @table table([TypeName] nvarchar(max), [MinInStock] int); " +
				"declare @MinInStock int;  " +
				"insert into @table " +
				"select  " +
				"T.[Name] as [TypeName], " +
				"Sum(P.[InStock]) as [InStock] " +
				"from " +
				"[Products] as P join [Types] as T on " +
				"P.[TypeID] = T.[ID] " +
				"group by  " +
				"T.[Name]  " +
				"select @MinInStock = Min(t.MinInStock) " +
				"from @table as t  " +
				"select * " +
				"from @table as t " +
				"where t.[MinInStock] = @MinInStock";

			UpdateDataGrid(query);
		}

		private void Btn_ProductsFromDeliveryDatePassSpecCountOfDays_Click(object sender, RoutedEventArgs e)
		{
			string query = "select " +
				"PD.[Name] as [Product`s Name], " +
				"PV.[Name] as [Provider`s Name], " +
				"T.[Name] as [Type Name], " +
				"PD.[InStock] as [In Stock], " +
				"PD.[CostPrice] as [Cost Price], " +
				"PD.[DeliveryDate] as [Delivery Date] " +
				"from " +
				"[Products] as PD join [Providers] as PV on  " +
				"PD.[ProviderID] = PV.[ID]  " +
				"join [Types] as T on " +
				"PD.[TypeID] = T.[ID] " +
				"where " +
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
