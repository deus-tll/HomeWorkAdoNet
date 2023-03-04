using MailingList_Application.DatabaseContext;
using Microsoft.IdentityModel.Tokens;

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


		private void ShrinkDataGridColumns()
		{
			int columnCount = Dgv_QueriesPart1.ColumnCount;

			for (int i = columnCount / 2; i < columnCount; i++)
			{
				Dgv_QueriesPart1.Columns.RemoveAt(i);
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
		private void Btn_GetAllCustomers_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllCustomers();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllCustomersEmails_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllCustomersEmails();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllSections_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllSections();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllSharesProducts_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllSharesProducts();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllCities_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllCities();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllCountries_Click(object sender, EventArgs e)
		{
			Dgv_QueriesPart1.DataSource = DB.GetAllCountries();

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllCustomersByCity_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllCustomersByCity.Text)) return;

			Dgv_QueriesPart1.DataSource = DB.GetAllCustomersByCity(TextBox_GetAllCustomersByCity.Text);

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllCustomersByCountry_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllCustomersByCountry.Text)) return;

			Dgv_QueriesPart1.DataSource = DB.GetAllCustomersByCountry(TextBox_GetAllCustomersByCountry.Text);

			ShrinkDataGridColumns();
		}


		private void Btn_GetAllSharesByCountry_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBox_GetAllSharesByCountry.Text)) return;

			Dgv_QueriesPart1.DataSource = DB.GetAllSharesByCountry(TextBox_GetAllSharesByCountry.Text);

			ShrinkDataGridColumns();
		}
		#endregion



	}
}