using MailingList_Application.DatabaseContext;
using MailingList_Application.Models;
using Microsoft.IdentityModel.Tokens;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MailingList_Application
{
	public partial class MainForm : Form
	{
		readonly MailingListDB DB = new MailingListDB();


		public MainForm()
		{
			InitializeComponent();

			TabControl_Main.Enabled = false;
		}


		private void ShrinkDataGridColumns(DataGridView dgv)
		{
			int columnCount = dgv.ColumnCount;

			for (int i = columnCount / 2; i < columnCount;)
			{
				dgv.Columns.RemoveAt(i);

				if (dgv.Columns.Count == i)
					return;
			}
		}


		private void Btn_Connect_Click(object sender, EventArgs e)
		{
			DB.ConnectBase();

			TabControl_Main.Enabled = true;
		}


		private void Btn_Disconnect_Click(object sender, EventArgs e)
		{
			DB.DisconnectBase();

			TabControl_Main.Enabled = false;
		}


		#region Queries Part 1
		private async void Btn_GetAllCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCustomers();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllCustomersEmails_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCustomersEmails();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllSections_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllSections();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllSharesProducts_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllSharesProducts();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllCities_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCities();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllCountries_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCountries();

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllCustomersByCity_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllCustomersByCity.Text)) return;

			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCustomersByCity(TextBox_GetAllCustomersByCity.Text);

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllCustomersByCountry_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllCustomersByCountry.Text)) return;

			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllCustomersByCountry(TextBox_GetAllCustomersByCountry.Text);

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}


		private async void Btn_GetAllSharesByCountry_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllSharesByCountry.Text)) return;

			Dgv_QueriesPart1.DataSource = null;
			Dgv_QueriesPart1.DataSource = await DB.GetAllSharesByCountry(TextBox_GetAllSharesByCountry.Text);

			ShrinkDataGridColumns(Dgv_QueriesPart1);
		}
		#endregion


		#region Queries Part 2
		private async void Btn_GetCountCustomersInEachCity_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetCountCustomersInEachCity();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetCountCustomersInEachCountry_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetCountCustomersInEachCountry();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetCountCitiesInEachCountry_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetCountCitiesInEachCountry();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetAverageCountOfCitiesByAllCountry_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetAverageCountOfCitiesByAllCountry();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetSectionsCertCustomersFromCertCountryInterested_Click(object sender, EventArgs e)
		{
			string country = TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country.Text;
			string email = TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email.Text;

			if (string.IsNullOrEmpty(country) ||
				string.IsNullOrEmpty(email)) return;

			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetSectionsCertCustomersFromCertCountryInterested(country, email);

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetSharesProductsCertSectionInRangeDate_Click(object sender, EventArgs e)
		{
			string section = TextBox_GetSharesProductsCertSectionInRangeDate.Text;
			DateTime start = DTP_GetSharesProductsCertSectionInRangeDate_Start.Value;
			DateTime end = DTP_GetSharesProductsCertSectionInRangeDate_End.Value;

			if (string.IsNullOrEmpty(section)) return;

			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetSharesProductsCertSectionInRangeDate(section, start, end);

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetSharesProductsCertCustomer_Click(object sender, EventArgs e)
		{
			string email = TextBox_GetSharesProductsCertCustomer.Text;

			if (string.IsNullOrEmpty(email)) return;

			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetSharesProductsCertCustomer(email);

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetTop3CountryByCountOfCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetTop3CountryByCountOfCustomers();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetTop1CountryByCountOfCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetTop1CountryByCountOfCustomers();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetTop3CityByCountOfCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetTop3CityByCountOfCustomers();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}


		private async void Btn_GetTop1CityByCountOfCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart2.DataSource = null;
			Dgv_QueriesPart2.DataSource = await DB.GetTop1CityByCountOfCustomers();

			ShrinkDataGridColumns(Dgv_QueriesPart2);
		}
		#endregion
	}
}