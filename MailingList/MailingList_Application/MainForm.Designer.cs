namespace MailingList_Application
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			TabControl_Main = new TabControl();
			TabPage_Queries = new TabPage();
			TabControl_Queries = new TabControl();
			TabPage_QuriesPart1 = new TabPage();
			groupBox9 = new GroupBox();
			TextBox_GetAllSharesByCountry = new TextBox();
			Btn_GetAllSharesByCountry = new Button();
			groupBox8 = new GroupBox();
			TextBox_GetAllCustomersByCountry = new TextBox();
			Btn_GetAllCustomersByCountry = new Button();
			groupBox7 = new GroupBox();
			TextBox_GetAllCustomersByCity = new TextBox();
			Btn_GetAllCustomersByCity = new Button();
			groupBox6 = new GroupBox();
			Btn_GetAllCountries = new Button();
			groupBox5 = new GroupBox();
			Btn_GetAllCities = new Button();
			groupBox4 = new GroupBox();
			Btn_GetAllSharesProducts = new Button();
			groupBox3 = new GroupBox();
			Btn_GetAllSections = new Button();
			groupBox2 = new GroupBox();
			Btn_GetAllCustomersEmails = new Button();
			groupBox1 = new GroupBox();
			Btn_GetAllCustomers = new Button();
			Dgv_QueriesPart1 = new DataGridView();
			TabPage_QuriesPart2 = new TabPage();
			groupBox20 = new GroupBox();
			Btn_GetTop3CityByCountOfCustomers = new Button();
			groupBox19 = new GroupBox();
			Btn_GetTop1CityByCountOfCustomers = new Button();
			groupBox10 = new GroupBox();
			Btn_GetTop1CountryByCountOfCustomers = new Button();
			groupBox11 = new GroupBox();
			Btn_GetTop3CountryByCountOfCustomers = new Button();
			groupBox12 = new GroupBox();
			Btn_GetSharesProductsCertCustomer = new Button();
			groupBox13 = new GroupBox();
			DTP_GetSharesProductsCertSectionInRangeDate_End = new DateTimePicker();
			DTP_GetSharesProductsCertSectionInRangeDate_Start = new DateTimePicker();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			TextBox_GetSharesProductsCertSectionInRangeDate = new TextBox();
			Btn_GetSharesProductsCertSectionInRangeDate = new Button();
			groupBox14 = new GroupBox();
			label5 = new Label();
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email = new TextBox();
			label4 = new Label();
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country = new TextBox();
			Btn_GetSectionsCertCustomersFromCertCountryInterested = new Button();
			groupBox15 = new GroupBox();
			Btn_GetAverageCountOfCitiesByAllCountry = new Button();
			groupBox16 = new GroupBox();
			Btn_GetCountCitiesInEachCountry = new Button();
			groupBox17 = new GroupBox();
			Btn_GetCountCustomersInEachCountry = new Button();
			groupBox18 = new GroupBox();
			Btn_GetCountCustomersInEachCity = new Button();
			Dgv_QueriesPart2 = new DataGridView();
			TabPage_Editing = new TabPage();
			TabControl_Editing = new TabControl();
			TabPage_CountriesEditing = new TabPage();
			TabPage_CitiesEditing = new TabPage();
			TabPage_SectionsEditing = new TabPage();
			TabPage_ProductsEditing = new TabPage();
			TabPage_SharesEditing = new TabPage();
			TabPage_CustomersEditing = new TabPage();
			Btn_Connect = new Button();
			Btn_Disconnect = new Button();
			label6 = new Label();
			TextBox_GetSharesProductsCertCustomer = new TextBox();
			TabControl_Main.SuspendLayout();
			TabPage_Queries.SuspendLayout();
			TabControl_Queries.SuspendLayout();
			TabPage_QuriesPart1.SuspendLayout();
			groupBox9.SuspendLayout();
			groupBox8.SuspendLayout();
			groupBox7.SuspendLayout();
			groupBox6.SuspendLayout();
			groupBox5.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_QueriesPart1).BeginInit();
			TabPage_QuriesPart2.SuspendLayout();
			groupBox20.SuspendLayout();
			groupBox19.SuspendLayout();
			groupBox10.SuspendLayout();
			groupBox11.SuspendLayout();
			groupBox12.SuspendLayout();
			groupBox13.SuspendLayout();
			groupBox14.SuspendLayout();
			groupBox15.SuspendLayout();
			groupBox16.SuspendLayout();
			groupBox17.SuspendLayout();
			groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_QueriesPart2).BeginInit();
			TabPage_Editing.SuspendLayout();
			TabControl_Editing.SuspendLayout();
			SuspendLayout();
			// 
			// TabControl_Main
			// 
			TabControl_Main.Controls.Add(TabPage_Queries);
			TabControl_Main.Controls.Add(TabPage_Editing);
			TabControl_Main.Location = new Point(12, 12);
			TabControl_Main.Name = "TabControl_Main";
			TabControl_Main.SelectedIndex = 0;
			TabControl_Main.Size = new Size(1147, 724);
			TabControl_Main.TabIndex = 0;
			// 
			// TabPage_Queries
			// 
			TabPage_Queries.Controls.Add(TabControl_Queries);
			TabPage_Queries.Location = new Point(4, 24);
			TabPage_Queries.Name = "TabPage_Queries";
			TabPage_Queries.Padding = new Padding(3);
			TabPage_Queries.Size = new Size(1139, 696);
			TabPage_Queries.TabIndex = 0;
			TabPage_Queries.Text = "Queries";
			TabPage_Queries.UseVisualStyleBackColor = true;
			// 
			// TabControl_Queries
			// 
			TabControl_Queries.Controls.Add(TabPage_QuriesPart1);
			TabControl_Queries.Controls.Add(TabPage_QuriesPart2);
			TabControl_Queries.Location = new Point(6, 6);
			TabControl_Queries.Name = "TabControl_Queries";
			TabControl_Queries.SelectedIndex = 0;
			TabControl_Queries.Size = new Size(1127, 684);
			TabControl_Queries.TabIndex = 0;
			// 
			// TabPage_QuriesPart1
			// 
			TabPage_QuriesPart1.Controls.Add(groupBox9);
			TabPage_QuriesPart1.Controls.Add(groupBox8);
			TabPage_QuriesPart1.Controls.Add(groupBox7);
			TabPage_QuriesPart1.Controls.Add(groupBox6);
			TabPage_QuriesPart1.Controls.Add(groupBox5);
			TabPage_QuriesPart1.Controls.Add(groupBox4);
			TabPage_QuriesPart1.Controls.Add(groupBox3);
			TabPage_QuriesPart1.Controls.Add(groupBox2);
			TabPage_QuriesPart1.Controls.Add(groupBox1);
			TabPage_QuriesPart1.Controls.Add(Dgv_QueriesPart1);
			TabPage_QuriesPart1.Location = new Point(4, 24);
			TabPage_QuriesPart1.Name = "TabPage_QuriesPart1";
			TabPage_QuriesPart1.Padding = new Padding(3);
			TabPage_QuriesPart1.Size = new Size(1119, 656);
			TabPage_QuriesPart1.TabIndex = 0;
			TabPage_QuriesPart1.Text = "Queries Part 1";
			TabPage_QuriesPart1.UseVisualStyleBackColor = true;
			// 
			// groupBox9
			// 
			groupBox9.Controls.Add(TextBox_GetAllSharesByCountry);
			groupBox9.Controls.Add(Btn_GetAllSharesByCountry);
			groupBox9.Location = new Point(681, 573);
			groupBox9.Name = "groupBox9";
			groupBox9.Size = new Size(432, 53);
			groupBox9.TabIndex = 5;
			groupBox9.TabStop = false;
			groupBox9.Text = "Відображення усіх акцій для певної країни";
			// 
			// TextBox_GetAllSharesByCountry
			// 
			TextBox_GetAllSharesByCountry.Location = new Point(87, 22);
			TextBox_GetAllSharesByCountry.Name = "TextBox_GetAllSharesByCountry";
			TextBox_GetAllSharesByCountry.Size = new Size(176, 23);
			TextBox_GetAllSharesByCountry.TabIndex = 2;
			// 
			// Btn_GetAllSharesByCountry
			// 
			Btn_GetAllSharesByCountry.Location = new Point(6, 22);
			Btn_GetAllSharesByCountry.Name = "Btn_GetAllSharesByCountry";
			Btn_GetAllSharesByCountry.Size = new Size(75, 23);
			Btn_GetAllSharesByCountry.TabIndex = 0;
			Btn_GetAllSharesByCountry.Text = "Виконати";
			Btn_GetAllSharesByCountry.UseVisualStyleBackColor = true;
			Btn_GetAllSharesByCountry.Click += Btn_GetAllSharesByCountry_Click;
			// 
			// groupBox8
			// 
			groupBox8.Controls.Add(TextBox_GetAllCustomersByCountry);
			groupBox8.Controls.Add(Btn_GetAllCustomersByCountry);
			groupBox8.Location = new Point(681, 504);
			groupBox8.Name = "groupBox8";
			groupBox8.Size = new Size(432, 53);
			groupBox8.TabIndex = 4;
			groupBox8.TabStop = false;
			groupBox8.Text = "Відображення усіх покупців з певної країни";
			// 
			// TextBox_GetAllCustomersByCountry
			// 
			TextBox_GetAllCustomersByCountry.Location = new Point(87, 22);
			TextBox_GetAllCustomersByCountry.Name = "TextBox_GetAllCustomersByCountry";
			TextBox_GetAllCustomersByCountry.Size = new Size(176, 23);
			TextBox_GetAllCustomersByCountry.TabIndex = 2;
			// 
			// Btn_GetAllCustomersByCountry
			// 
			Btn_GetAllCustomersByCountry.Location = new Point(6, 22);
			Btn_GetAllCustomersByCountry.Name = "Btn_GetAllCustomersByCountry";
			Btn_GetAllCustomersByCountry.Size = new Size(75, 23);
			Btn_GetAllCustomersByCountry.TabIndex = 0;
			Btn_GetAllCustomersByCountry.Text = "Виконати";
			Btn_GetAllCustomersByCountry.UseVisualStyleBackColor = true;
			Btn_GetAllCustomersByCountry.Click += Btn_GetAllCustomersByCountry_Click;
			// 
			// groupBox7
			// 
			groupBox7.Controls.Add(TextBox_GetAllCustomersByCity);
			groupBox7.Controls.Add(Btn_GetAllCustomersByCity);
			groupBox7.Location = new Point(681, 434);
			groupBox7.Name = "groupBox7";
			groupBox7.Size = new Size(432, 53);
			groupBox7.TabIndex = 2;
			groupBox7.TabStop = false;
			groupBox7.Text = "Відображення усіх покупців з певного міста";
			// 
			// TextBox_GetAllCustomersByCity
			// 
			TextBox_GetAllCustomersByCity.Location = new Point(87, 22);
			TextBox_GetAllCustomersByCity.Name = "TextBox_GetAllCustomersByCity";
			TextBox_GetAllCustomersByCity.Size = new Size(176, 23);
			TextBox_GetAllCustomersByCity.TabIndex = 1;
			// 
			// Btn_GetAllCustomersByCity
			// 
			Btn_GetAllCustomersByCity.Location = new Point(6, 22);
			Btn_GetAllCustomersByCity.Name = "Btn_GetAllCustomersByCity";
			Btn_GetAllCustomersByCity.Size = new Size(75, 23);
			Btn_GetAllCustomersByCity.TabIndex = 0;
			Btn_GetAllCustomersByCity.Text = "Виконати";
			Btn_GetAllCustomersByCity.UseVisualStyleBackColor = true;
			Btn_GetAllCustomersByCity.Click += Btn_GetAllCustomersByCity_Click;
			// 
			// groupBox6
			// 
			groupBox6.Controls.Add(Btn_GetAllCountries);
			groupBox6.Location = new Point(681, 365);
			groupBox6.Name = "groupBox6";
			groupBox6.Size = new Size(432, 53);
			groupBox6.TabIndex = 2;
			groupBox6.TabStop = false;
			groupBox6.Text = "Відображення усіх країн";
			// 
			// Btn_GetAllCountries
			// 
			Btn_GetAllCountries.Location = new Point(6, 22);
			Btn_GetAllCountries.Name = "Btn_GetAllCountries";
			Btn_GetAllCountries.Size = new Size(75, 23);
			Btn_GetAllCountries.TabIndex = 0;
			Btn_GetAllCountries.Text = "Виконати";
			Btn_GetAllCountries.UseVisualStyleBackColor = true;
			Btn_GetAllCountries.Click += Btn_GetAllCountries_Click;
			// 
			// groupBox5
			// 
			groupBox5.Controls.Add(Btn_GetAllCities);
			groupBox5.Location = new Point(681, 292);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new Size(432, 53);
			groupBox5.TabIndex = 2;
			groupBox5.TabStop = false;
			groupBox5.Text = "Відображення усіх міст";
			// 
			// Btn_GetAllCities
			// 
			Btn_GetAllCities.Location = new Point(6, 22);
			Btn_GetAllCities.Name = "Btn_GetAllCities";
			Btn_GetAllCities.Size = new Size(75, 23);
			Btn_GetAllCities.TabIndex = 0;
			Btn_GetAllCities.Text = "Виконати";
			Btn_GetAllCities.UseVisualStyleBackColor = true;
			Btn_GetAllCities.Click += Btn_GetAllCities_Click;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(Btn_GetAllSharesProducts);
			groupBox4.Location = new Point(681, 222);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new Size(432, 53);
			groupBox4.TabIndex = 3;
			groupBox4.TabStop = false;
			groupBox4.Text = "Відображення списку акційних товарів";
			// 
			// Btn_GetAllSharesProducts
			// 
			Btn_GetAllSharesProducts.Location = new Point(6, 22);
			Btn_GetAllSharesProducts.Name = "Btn_GetAllSharesProducts";
			Btn_GetAllSharesProducts.Size = new Size(75, 23);
			Btn_GetAllSharesProducts.TabIndex = 0;
			Btn_GetAllSharesProducts.Text = "Виконати";
			Btn_GetAllSharesProducts.UseVisualStyleBackColor = true;
			Btn_GetAllSharesProducts.Click += Btn_GetAllSharesProducts_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(Btn_GetAllSections);
			groupBox3.Location = new Point(681, 153);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(432, 53);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Відображення списку розділів";
			// 
			// Btn_GetAllSections
			// 
			Btn_GetAllSections.Location = new Point(6, 22);
			Btn_GetAllSections.Name = "Btn_GetAllSections";
			Btn_GetAllSections.Size = new Size(75, 23);
			Btn_GetAllSections.TabIndex = 0;
			Btn_GetAllSections.Text = "Виконати";
			Btn_GetAllSections.UseVisualStyleBackColor = true;
			Btn_GetAllSections.Click += Btn_GetAllSections_Click;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(Btn_GetAllCustomersEmails);
			groupBox2.Location = new Point(681, 78);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(432, 53);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Відображення email усіх покупців";
			// 
			// Btn_GetAllCustomersEmails
			// 
			Btn_GetAllCustomersEmails.Location = new Point(6, 22);
			Btn_GetAllCustomersEmails.Name = "Btn_GetAllCustomersEmails";
			Btn_GetAllCustomersEmails.Size = new Size(75, 23);
			Btn_GetAllCustomersEmails.TabIndex = 0;
			Btn_GetAllCustomersEmails.Text = "Виконати";
			Btn_GetAllCustomersEmails.UseVisualStyleBackColor = true;
			Btn_GetAllCustomersEmails.Click += Btn_GetAllCustomersEmails_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Btn_GetAllCustomers);
			groupBox1.Location = new Point(681, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(432, 53);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Відображення усіх покупців";
			// 
			// Btn_GetAllCustomers
			// 
			Btn_GetAllCustomers.Location = new Point(6, 22);
			Btn_GetAllCustomers.Name = "Btn_GetAllCustomers";
			Btn_GetAllCustomers.Size = new Size(75, 23);
			Btn_GetAllCustomers.TabIndex = 0;
			Btn_GetAllCustomers.Text = "Виконати";
			Btn_GetAllCustomers.UseVisualStyleBackColor = true;
			Btn_GetAllCustomers.Click += Btn_GetAllCustomers_Click;
			// 
			// Dgv_QueriesPart1
			// 
			Dgv_QueriesPart1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_QueriesPart1.Location = new Point(6, 6);
			Dgv_QueriesPart1.Name = "Dgv_QueriesPart1";
			Dgv_QueriesPart1.ReadOnly = true;
			Dgv_QueriesPart1.RowTemplate.Height = 25;
			Dgv_QueriesPart1.Size = new Size(669, 644);
			Dgv_QueriesPart1.TabIndex = 0;
			// 
			// TabPage_QuriesPart2
			// 
			TabPage_QuriesPart2.Controls.Add(groupBox20);
			TabPage_QuriesPart2.Controls.Add(groupBox19);
			TabPage_QuriesPart2.Controls.Add(groupBox10);
			TabPage_QuriesPart2.Controls.Add(groupBox11);
			TabPage_QuriesPart2.Controls.Add(groupBox12);
			TabPage_QuriesPart2.Controls.Add(groupBox13);
			TabPage_QuriesPart2.Controls.Add(groupBox14);
			TabPage_QuriesPart2.Controls.Add(groupBox15);
			TabPage_QuriesPart2.Controls.Add(groupBox16);
			TabPage_QuriesPart2.Controls.Add(groupBox17);
			TabPage_QuriesPart2.Controls.Add(groupBox18);
			TabPage_QuriesPart2.Controls.Add(Dgv_QueriesPart2);
			TabPage_QuriesPart2.Location = new Point(4, 24);
			TabPage_QuriesPart2.Name = "TabPage_QuriesPart2";
			TabPage_QuriesPart2.Size = new Size(1119, 656);
			TabPage_QuriesPart2.TabIndex = 1;
			TabPage_QuriesPart2.Text = "Queries Part 2";
			TabPage_QuriesPart2.UseVisualStyleBackColor = true;
			// 
			// groupBox20
			// 
			groupBox20.Controls.Add(Btn_GetTop3CityByCountOfCustomers);
			groupBox20.Location = new Point(340, 600);
			groupBox20.Name = "groupBox20";
			groupBox20.Size = new Size(361, 53);
			groupBox20.TabIndex = 17;
			groupBox20.TabStop = false;
			groupBox20.Text = "Показати Топ-3 міст за кількістю покупців";
			// 
			// Btn_GetTop3CityByCountOfCustomers
			// 
			Btn_GetTop3CityByCountOfCustomers.Location = new Point(6, 22);
			Btn_GetTop3CityByCountOfCustomers.Name = "Btn_GetTop3CityByCountOfCustomers";
			Btn_GetTop3CityByCountOfCustomers.Size = new Size(75, 23);
			Btn_GetTop3CityByCountOfCustomers.TabIndex = 0;
			Btn_GetTop3CityByCountOfCustomers.Text = "Виконати";
			Btn_GetTop3CityByCountOfCustomers.UseVisualStyleBackColor = true;
			Btn_GetTop3CityByCountOfCustomers.Click += Btn_GetTop3CityByCountOfCustomers_Click;
			// 
			// groupBox19
			// 
			groupBox19.Controls.Add(Btn_GetTop1CityByCountOfCustomers);
			groupBox19.Location = new Point(6, 600);
			groupBox19.Name = "groupBox19";
			groupBox19.Size = new Size(328, 53);
			groupBox19.TabIndex = 16;
			groupBox19.TabStop = false;
			groupBox19.Text = "Показати найкраще місто за кількістю покупців";
			// 
			// Btn_GetTop1CityByCountOfCustomers
			// 
			Btn_GetTop1CityByCountOfCustomers.Location = new Point(6, 22);
			Btn_GetTop1CityByCountOfCustomers.Name = "Btn_GetTop1CityByCountOfCustomers";
			Btn_GetTop1CityByCountOfCustomers.Size = new Size(75, 23);
			Btn_GetTop1CityByCountOfCustomers.TabIndex = 0;
			Btn_GetTop1CityByCountOfCustomers.Text = "Виконати";
			Btn_GetTop1CityByCountOfCustomers.UseVisualStyleBackColor = true;
			Btn_GetTop1CityByCountOfCustomers.Click += Btn_GetTop1CityByCountOfCustomers_Click;
			// 
			// groupBox10
			// 
			groupBox10.Controls.Add(Btn_GetTop1CountryByCountOfCustomers);
			groupBox10.Location = new Point(707, 600);
			groupBox10.Name = "groupBox10";
			groupBox10.Size = new Size(406, 53);
			groupBox10.TabIndex = 15;
			groupBox10.TabStop = false;
			groupBox10.Text = "Показати найкращу країну за кількістю покупців";
			// 
			// Btn_GetTop1CountryByCountOfCustomers
			// 
			Btn_GetTop1CountryByCountOfCustomers.Location = new Point(6, 22);
			Btn_GetTop1CountryByCountOfCustomers.Name = "Btn_GetTop1CountryByCountOfCustomers";
			Btn_GetTop1CountryByCountOfCustomers.Size = new Size(75, 23);
			Btn_GetTop1CountryByCountOfCustomers.TabIndex = 0;
			Btn_GetTop1CountryByCountOfCustomers.Text = "Виконати";
			Btn_GetTop1CountryByCountOfCustomers.UseVisualStyleBackColor = true;
			Btn_GetTop1CountryByCountOfCustomers.Click += Btn_GetTop1CountryByCountOfCustomers_Click;
			// 
			// groupBox11
			// 
			groupBox11.Controls.Add(Btn_GetTop3CountryByCountOfCustomers);
			groupBox11.Location = new Point(707, 531);
			groupBox11.Name = "groupBox11";
			groupBox11.Size = new Size(406, 53);
			groupBox11.TabIndex = 14;
			groupBox11.TabStop = false;
			groupBox11.Text = "Відобразити Топ-3 країни за кількістю покупців";
			// 
			// Btn_GetTop3CountryByCountOfCustomers
			// 
			Btn_GetTop3CountryByCountOfCustomers.Location = new Point(6, 22);
			Btn_GetTop3CountryByCountOfCustomers.Name = "Btn_GetTop3CountryByCountOfCustomers";
			Btn_GetTop3CountryByCountOfCustomers.Size = new Size(75, 23);
			Btn_GetTop3CountryByCountOfCustomers.TabIndex = 0;
			Btn_GetTop3CountryByCountOfCustomers.Text = "Виконати";
			Btn_GetTop3CountryByCountOfCustomers.UseVisualStyleBackColor = true;
			Btn_GetTop3CountryByCountOfCustomers.Click += Btn_GetTop3CountryByCountOfCustomers_Click;
			// 
			// groupBox12
			// 
			groupBox12.Controls.Add(label6);
			groupBox12.Controls.Add(TextBox_GetSharesProductsCertCustomer);
			groupBox12.Controls.Add(Btn_GetSharesProductsCertCustomer);
			groupBox12.Location = new Point(707, 451);
			groupBox12.Name = "groupBox12";
			groupBox12.Size = new Size(406, 63);
			groupBox12.TabIndex = 8;
			groupBox12.TabStop = false;
			groupBox12.Text = "Відобразити усі акційні товари певного покупця";
			// 
			// Btn_GetSharesProductsCertCustomer
			// 
			Btn_GetSharesProductsCertCustomer.Location = new Point(6, 22);
			Btn_GetSharesProductsCertCustomer.Name = "Btn_GetSharesProductsCertCustomer";
			Btn_GetSharesProductsCertCustomer.Size = new Size(75, 23);
			Btn_GetSharesProductsCertCustomer.TabIndex = 0;
			Btn_GetSharesProductsCertCustomer.Text = "Виконати";
			Btn_GetSharesProductsCertCustomer.UseVisualStyleBackColor = true;
			Btn_GetSharesProductsCertCustomer.Click += Btn_GetSharesProductsCertCustomer_Click;
			// 
			// groupBox13
			// 
			groupBox13.Controls.Add(DTP_GetSharesProductsCertSectionInRangeDate_End);
			groupBox13.Controls.Add(DTP_GetSharesProductsCertSectionInRangeDate_Start);
			groupBox13.Controls.Add(label3);
			groupBox13.Controls.Add(label2);
			groupBox13.Controls.Add(label1);
			groupBox13.Controls.Add(TextBox_GetSharesProductsCertSectionInRangeDate);
			groupBox13.Controls.Add(Btn_GetSharesProductsCertSectionInRangeDate);
			groupBox13.Location = new Point(707, 326);
			groupBox13.Name = "groupBox13";
			groupBox13.Size = new Size(406, 119);
			groupBox13.TabIndex = 9;
			groupBox13.TabStop = false;
			groupBox13.Text = "Відобразити усі акційні товари певного розділу за вказаний проміжок часу";
			// 
			// DTP_GetSharesProductsCertSectionInRangeDate_End
			// 
			DTP_GetSharesProductsCertSectionInRangeDate_End.Location = new Point(200, 81);
			DTP_GetSharesProductsCertSectionInRangeDate_End.Name = "DTP_GetSharesProductsCertSectionInRangeDate_End";
			DTP_GetSharesProductsCertSectionInRangeDate_End.Size = new Size(200, 23);
			DTP_GetSharesProductsCertSectionInRangeDate_End.TabIndex = 12;
			// 
			// DTP_GetSharesProductsCertSectionInRangeDate_Start
			// 
			DTP_GetSharesProductsCertSectionInRangeDate_Start.Location = new Point(200, 53);
			DTP_GetSharesProductsCertSectionInRangeDate_Start.Name = "DTP_GetSharesProductsCertSectionInRangeDate_Start";
			DTP_GetSharesProductsCertSectionInRangeDate_Start.Size = new Size(200, 23);
			DTP_GetSharesProductsCertSectionInRangeDate_Start.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(125, 87);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 10;
			label3.Text = "End range";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(125, 59);
			label2.Name = "label2";
			label2.Size = new Size(64, 15);
			label2.TabIndex = 9;
			label2.Text = "Start range";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(125, 25);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 8;
			label1.Text = "Розділ:";
			// 
			// TextBox_GetSharesProductsCertSectionInRangeDate
			// 
			TextBox_GetSharesProductsCertSectionInRangeDate.Location = new Point(224, 22);
			TextBox_GetSharesProductsCertSectionInRangeDate.Name = "TextBox_GetSharesProductsCertSectionInRangeDate";
			TextBox_GetSharesProductsCertSectionInRangeDate.Size = new Size(176, 23);
			TextBox_GetSharesProductsCertSectionInRangeDate.TabIndex = 7;
			// 
			// Btn_GetSharesProductsCertSectionInRangeDate
			// 
			Btn_GetSharesProductsCertSectionInRangeDate.Location = new Point(6, 35);
			Btn_GetSharesProductsCertSectionInRangeDate.Name = "Btn_GetSharesProductsCertSectionInRangeDate";
			Btn_GetSharesProductsCertSectionInRangeDate.Size = new Size(75, 67);
			Btn_GetSharesProductsCertSectionInRangeDate.TabIndex = 0;
			Btn_GetSharesProductsCertSectionInRangeDate.Text = "Виконати";
			Btn_GetSharesProductsCertSectionInRangeDate.UseVisualStyleBackColor = true;
			Btn_GetSharesProductsCertSectionInRangeDate.Click += Btn_GetSharesProductsCertSectionInRangeDate_Click;
			// 
			// groupBox14
			// 
			groupBox14.Controls.Add(label5);
			groupBox14.Controls.Add(TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email);
			groupBox14.Controls.Add(label4);
			groupBox14.Controls.Add(TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country);
			groupBox14.Controls.Add(Btn_GetSectionsCertCustomersFromCertCountryInterested);
			groupBox14.Location = new Point(707, 242);
			groupBox14.Name = "groupBox14";
			groupBox14.Size = new Size(406, 78);
			groupBox14.TabIndex = 10;
			groupBox14.TabStop = false;
			groupBox14.Text = "Відобразити усі розділи, в яких зацікавлені певні покупці певної країни";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(125, 54);
			label5.Name = "label5";
			label5.Size = new Size(88, 15);
			label5.TabIndex = 12;
			label5.Text = "Email покупця:";
			// 
			// TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email
			// 
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email.Location = new Point(224, 51);
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email.Name = "TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email";
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email.Size = new Size(176, 23);
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(125, 25);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 10;
			label4.Text = "Країна:";
			// 
			// TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country
			// 
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country.Location = new Point(224, 22);
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country.Name = "TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country";
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country.Size = new Size(176, 23);
			TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country.TabIndex = 9;
			// 
			// Btn_GetSectionsCertCustomersFromCertCountryInterested
			// 
			Btn_GetSectionsCertCustomersFromCertCountryInterested.Location = new Point(6, 34);
			Btn_GetSectionsCertCustomersFromCertCountryInterested.Name = "Btn_GetSectionsCertCustomersFromCertCountryInterested";
			Btn_GetSectionsCertCustomersFromCertCountryInterested.Size = new Size(75, 36);
			Btn_GetSectionsCertCustomersFromCertCountryInterested.TabIndex = 0;
			Btn_GetSectionsCertCustomersFromCertCountryInterested.Text = "Виконати";
			Btn_GetSectionsCertCustomersFromCertCountryInterested.UseVisualStyleBackColor = true;
			Btn_GetSectionsCertCustomersFromCertCountryInterested.Click += Btn_GetSectionsCertCustomersFromCertCountryInterested_Click;
			// 
			// groupBox15
			// 
			groupBox15.Controls.Add(Btn_GetAverageCountOfCitiesByAllCountry);
			groupBox15.Location = new Point(707, 183);
			groupBox15.Name = "groupBox15";
			groupBox15.Size = new Size(406, 53);
			groupBox15.TabIndex = 13;
			groupBox15.TabStop = false;
			groupBox15.Text = "Відобразити середню кількість міст по всіх країнах";
			// 
			// Btn_GetAverageCountOfCitiesByAllCountry
			// 
			Btn_GetAverageCountOfCitiesByAllCountry.Location = new Point(6, 22);
			Btn_GetAverageCountOfCitiesByAllCountry.Name = "Btn_GetAverageCountOfCitiesByAllCountry";
			Btn_GetAverageCountOfCitiesByAllCountry.Size = new Size(75, 23);
			Btn_GetAverageCountOfCitiesByAllCountry.TabIndex = 0;
			Btn_GetAverageCountOfCitiesByAllCountry.Text = "Виконати";
			Btn_GetAverageCountOfCitiesByAllCountry.UseVisualStyleBackColor = true;
			Btn_GetAverageCountOfCitiesByAllCountry.Click += Btn_GetAverageCountOfCitiesByAllCountry_Click;
			// 
			// groupBox16
			// 
			groupBox16.Controls.Add(Btn_GetCountCitiesInEachCountry);
			groupBox16.Location = new Point(707, 124);
			groupBox16.Name = "groupBox16";
			groupBox16.Size = new Size(406, 53);
			groupBox16.TabIndex = 11;
			groupBox16.TabStop = false;
			groupBox16.Text = "Відобразити кількість міст у кожній країні";
			// 
			// Btn_GetCountCitiesInEachCountry
			// 
			Btn_GetCountCitiesInEachCountry.Location = new Point(6, 22);
			Btn_GetCountCitiesInEachCountry.Name = "Btn_GetCountCitiesInEachCountry";
			Btn_GetCountCitiesInEachCountry.Size = new Size(75, 23);
			Btn_GetCountCitiesInEachCountry.TabIndex = 0;
			Btn_GetCountCitiesInEachCountry.Text = "Виконати";
			Btn_GetCountCitiesInEachCountry.UseVisualStyleBackColor = true;
			Btn_GetCountCitiesInEachCountry.Click += Btn_GetCountCitiesInEachCountry_Click;
			// 
			// groupBox17
			// 
			groupBox17.Controls.Add(Btn_GetCountCustomersInEachCountry);
			groupBox17.Location = new Point(707, 65);
			groupBox17.Name = "groupBox17";
			groupBox17.Size = new Size(406, 53);
			groupBox17.TabIndex = 12;
			groupBox17.TabStop = false;
			groupBox17.Text = "Відобразити кількість покупців у кожній країні";
			// 
			// Btn_GetCountCustomersInEachCountry
			// 
			Btn_GetCountCustomersInEachCountry.Location = new Point(6, 22);
			Btn_GetCountCustomersInEachCountry.Name = "Btn_GetCountCustomersInEachCountry";
			Btn_GetCountCustomersInEachCountry.Size = new Size(75, 23);
			Btn_GetCountCustomersInEachCountry.TabIndex = 0;
			Btn_GetCountCustomersInEachCountry.Text = "Виконати";
			Btn_GetCountCustomersInEachCountry.UseVisualStyleBackColor = true;
			Btn_GetCountCustomersInEachCountry.Click += Btn_GetCountCustomersInEachCountry_Click;
			// 
			// groupBox18
			// 
			groupBox18.Controls.Add(Btn_GetCountCustomersInEachCity);
			groupBox18.Location = new Point(707, 6);
			groupBox18.Name = "groupBox18";
			groupBox18.Size = new Size(406, 53);
			groupBox18.TabIndex = 7;
			groupBox18.TabStop = false;
			groupBox18.Text = "Відобразити кількість покупців у кожному місті";
			// 
			// Btn_GetCountCustomersInEachCity
			// 
			Btn_GetCountCustomersInEachCity.Location = new Point(6, 22);
			Btn_GetCountCustomersInEachCity.Name = "Btn_GetCountCustomersInEachCity";
			Btn_GetCountCustomersInEachCity.Size = new Size(75, 23);
			Btn_GetCountCustomersInEachCity.TabIndex = 0;
			Btn_GetCountCustomersInEachCity.Text = "Виконати";
			Btn_GetCountCustomersInEachCity.UseVisualStyleBackColor = true;
			Btn_GetCountCustomersInEachCity.Click += Btn_GetCountCustomersInEachCity_Click;
			// 
			// Dgv_QueriesPart2
			// 
			Dgv_QueriesPart2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_QueriesPart2.Location = new Point(6, 6);
			Dgv_QueriesPart2.Name = "Dgv_QueriesPart2";
			Dgv_QueriesPart2.ReadOnly = true;
			Dgv_QueriesPart2.RowTemplate.Height = 25;
			Dgv_QueriesPart2.Size = new Size(695, 588);
			Dgv_QueriesPart2.TabIndex = 6;
			// 
			// TabPage_Editing
			// 
			TabPage_Editing.Controls.Add(TabControl_Editing);
			TabPage_Editing.Location = new Point(4, 24);
			TabPage_Editing.Name = "TabPage_Editing";
			TabPage_Editing.Padding = new Padding(3);
			TabPage_Editing.Size = new Size(1139, 696);
			TabPage_Editing.TabIndex = 1;
			TabPage_Editing.Text = "Editing";
			TabPage_Editing.UseVisualStyleBackColor = true;
			// 
			// TabControl_Editing
			// 
			TabControl_Editing.Controls.Add(TabPage_CountriesEditing);
			TabControl_Editing.Controls.Add(TabPage_CitiesEditing);
			TabControl_Editing.Controls.Add(TabPage_SectionsEditing);
			TabControl_Editing.Controls.Add(TabPage_ProductsEditing);
			TabControl_Editing.Controls.Add(TabPage_SharesEditing);
			TabControl_Editing.Controls.Add(TabPage_CustomersEditing);
			TabControl_Editing.Location = new Point(6, 6);
			TabControl_Editing.Name = "TabControl_Editing";
			TabControl_Editing.SelectedIndex = 0;
			TabControl_Editing.Size = new Size(1127, 684);
			TabControl_Editing.TabIndex = 0;
			// 
			// TabPage_CountriesEditing
			// 
			TabPage_CountriesEditing.Location = new Point(4, 24);
			TabPage_CountriesEditing.Name = "TabPage_CountriesEditing";
			TabPage_CountriesEditing.Padding = new Padding(3);
			TabPage_CountriesEditing.Size = new Size(1119, 656);
			TabPage_CountriesEditing.TabIndex = 0;
			TabPage_CountriesEditing.Text = "Countries";
			TabPage_CountriesEditing.UseVisualStyleBackColor = true;
			// 
			// TabPage_CitiesEditing
			// 
			TabPage_CitiesEditing.Location = new Point(4, 24);
			TabPage_CitiesEditing.Name = "TabPage_CitiesEditing";
			TabPage_CitiesEditing.Padding = new Padding(3);
			TabPage_CitiesEditing.Size = new Size(1119, 656);
			TabPage_CitiesEditing.TabIndex = 1;
			TabPage_CitiesEditing.Text = "Cities";
			TabPage_CitiesEditing.UseVisualStyleBackColor = true;
			// 
			// TabPage_SectionsEditing
			// 
			TabPage_SectionsEditing.Location = new Point(4, 24);
			TabPage_SectionsEditing.Name = "TabPage_SectionsEditing";
			TabPage_SectionsEditing.Size = new Size(1119, 656);
			TabPage_SectionsEditing.TabIndex = 2;
			TabPage_SectionsEditing.Text = "Sections";
			TabPage_SectionsEditing.UseVisualStyleBackColor = true;
			// 
			// TabPage_ProductsEditing
			// 
			TabPage_ProductsEditing.Location = new Point(4, 24);
			TabPage_ProductsEditing.Name = "TabPage_ProductsEditing";
			TabPage_ProductsEditing.Size = new Size(1119, 656);
			TabPage_ProductsEditing.TabIndex = 3;
			TabPage_ProductsEditing.Text = "Products";
			TabPage_ProductsEditing.UseVisualStyleBackColor = true;
			// 
			// TabPage_SharesEditing
			// 
			TabPage_SharesEditing.Location = new Point(4, 24);
			TabPage_SharesEditing.Name = "TabPage_SharesEditing";
			TabPage_SharesEditing.Size = new Size(1119, 656);
			TabPage_SharesEditing.TabIndex = 4;
			TabPage_SharesEditing.Text = "Shares";
			TabPage_SharesEditing.UseVisualStyleBackColor = true;
			// 
			// TabPage_CustomersEditing
			// 
			TabPage_CustomersEditing.Location = new Point(4, 24);
			TabPage_CustomersEditing.Name = "TabPage_CustomersEditing";
			TabPage_CustomersEditing.Size = new Size(1119, 656);
			TabPage_CustomersEditing.TabIndex = 5;
			TabPage_CustomersEditing.Text = "Customers";
			TabPage_CustomersEditing.UseVisualStyleBackColor = true;
			// 
			// Btn_Connect
			// 
			Btn_Connect.Location = new Point(1056, 738);
			Btn_Connect.Name = "Btn_Connect";
			Btn_Connect.Size = new Size(99, 23);
			Btn_Connect.TabIndex = 1;
			Btn_Connect.Text = "Підключитися";
			Btn_Connect.UseVisualStyleBackColor = true;
			Btn_Connect.Click += Btn_Connect_Click;
			// 
			// Btn_Disconnect
			// 
			Btn_Disconnect.Location = new Point(939, 738);
			Btn_Disconnect.Name = "Btn_Disconnect";
			Btn_Disconnect.Size = new Size(111, 23);
			Btn_Disconnect.TabIndex = 2;
			Btn_Disconnect.Text = "Відключитися";
			Btn_Disconnect.UseVisualStyleBackColor = true;
			Btn_Disconnect.Click += Btn_Disconnect_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(125, 26);
			label6.Name = "label6";
			label6.Size = new Size(88, 15);
			label6.TabIndex = 14;
			label6.Text = "Email покупця:";
			// 
			// TextBox_GetSharesProductsCertCustomer
			// 
			TextBox_GetSharesProductsCertCustomer.Location = new Point(224, 23);
			TextBox_GetSharesProductsCertCustomer.Name = "TextBox_GetSharesProductsCertCustomer";
			TextBox_GetSharesProductsCertCustomer.Size = new Size(176, 23);
			TextBox_GetSharesProductsCertCustomer.TabIndex = 13;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1171, 770);
			Controls.Add(Btn_Disconnect);
			Controls.Add(Btn_Connect);
			Controls.Add(TabControl_Main);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Mailing List";
			TabControl_Main.ResumeLayout(false);
			TabPage_Queries.ResumeLayout(false);
			TabControl_Queries.ResumeLayout(false);
			TabPage_QuriesPart1.ResumeLayout(false);
			groupBox9.ResumeLayout(false);
			groupBox9.PerformLayout();
			groupBox8.ResumeLayout(false);
			groupBox8.PerformLayout();
			groupBox7.ResumeLayout(false);
			groupBox7.PerformLayout();
			groupBox6.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)Dgv_QueriesPart1).EndInit();
			TabPage_QuriesPart2.ResumeLayout(false);
			groupBox20.ResumeLayout(false);
			groupBox19.ResumeLayout(false);
			groupBox10.ResumeLayout(false);
			groupBox11.ResumeLayout(false);
			groupBox12.ResumeLayout(false);
			groupBox12.PerformLayout();
			groupBox13.ResumeLayout(false);
			groupBox13.PerformLayout();
			groupBox14.ResumeLayout(false);
			groupBox14.PerformLayout();
			groupBox15.ResumeLayout(false);
			groupBox16.ResumeLayout(false);
			groupBox17.ResumeLayout(false);
			groupBox18.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)Dgv_QueriesPart2).EndInit();
			TabPage_Editing.ResumeLayout(false);
			TabControl_Editing.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabControl_Main;
		private TabPage TabPage_Queries;
		private TabControl TabControl_Queries;
		private TabPage TabPage_QuriesPart1;
		private TabPage TabPage_Editing;
		private TabControl TabControl_Editing;
		private TabPage TabPage_CountriesEditing;
		private TabPage TabPage_CitiesEditing;
		private DataGridView Dgv_QueriesPart1;
		private Button Btn_Connect;
		private Button Btn_Disconnect;
		private GroupBox groupBox9;
		private TextBox TextBox_GetAllSharesByCountry;
		private Button Btn_GetAllSharesByCountry;
		private GroupBox groupBox8;
		private TextBox TextBox_GetAllCustomersByCountry;
		private Button Btn_GetAllCustomersByCountry;
		private GroupBox groupBox7;
		private TextBox TextBox_GetAllCustomersByCity;
		private Button Btn_GetAllCustomersByCity;
		private GroupBox groupBox6;
		private Button Btn_GetAllCountries;
		private GroupBox groupBox5;
		private Button Btn_GetAllCities;
		private GroupBox groupBox4;
		private Button Btn_GetAllSharesProducts;
		private GroupBox groupBox3;
		private Button Btn_GetAllSections;
		private GroupBox groupBox2;
		private Button Btn_GetAllCustomersEmails;
		private GroupBox groupBox1;
		private Button Btn_GetAllCustomers;
		private TabPage TabPage_SectionsEditing;
		private TabPage TabPage_ProductsEditing;
		private TabPage TabPage_SharesEditing;
		private TabPage TabPage_CustomersEditing;
		private TabPage TabPage_QuriesPart2;
		private GroupBox groupBox20;
		private Button Btn_GetTop3CityByCountOfCustomers;
		private GroupBox groupBox19;
		private Button Btn_GetTop1CityByCountOfCustomers;
		private GroupBox groupBox10;
		private Button Btn_GetTop1CountryByCountOfCustomers;
		private GroupBox groupBox11;
		private Button Btn_GetTop3CountryByCountOfCustomers;
		private GroupBox groupBox12;
		private Button Btn_GetSharesProductsCertCustomer;
		private GroupBox groupBox13;
		private Button Btn_GetSharesProductsCertSectionInRangeDate;
		private GroupBox groupBox14;
		private Button Btn_GetSectionsCertCustomersFromCertCountryInterested;
		private GroupBox groupBox15;
		private Button Btn_GetAverageCountOfCitiesByAllCountry;
		private GroupBox groupBox16;
		private Button Btn_GetCountCitiesInEachCountry;
		private GroupBox groupBox17;
		private Button Btn_GetCountCustomersInEachCountry;
		private GroupBox groupBox18;
		private Button Btn_GetCountCustomersInEachCity;
		private DataGridView Dgv_QueriesPart2;
		private DateTimePicker DTP_GetSharesProductsCertSectionInRangeDate_End;
		private DateTimePicker DTP_GetSharesProductsCertSectionInRangeDate_Start;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox TextBox_GetSharesProductsCertSectionInRangeDate;
		private Label label5;
		private TextBox TextBox_GetSectionsCertCustomersFromCertCountryInterested_Email;
		private Label label4;
		private TextBox TextBox_GetSectionsCertCustomersFromCertCountryInterested_Country;
		private Label label6;
		private TextBox TextBox_GetSharesProductsCertCustomer;
	}
}