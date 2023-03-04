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
			TabPage_Editing = new TabPage();
			tabControl3 = new TabControl();
			tabPage5 = new TabPage();
			tabPage6 = new TabPage();
			Btn_Connect = new Button();
			Btn_Disconnect = new Button();
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
			TabPage_Editing.SuspendLayout();
			tabControl3.SuspendLayout();
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
			groupBox9.Size = new Size(269, 53);
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
			groupBox8.Size = new Size(269, 53);
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
			groupBox7.Size = new Size(269, 53);
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
			groupBox6.Size = new Size(269, 53);
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
			groupBox5.Size = new Size(269, 53);
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
			groupBox4.Size = new Size(269, 53);
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
			groupBox3.Size = new Size(269, 53);
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
			groupBox2.Size = new Size(269, 53);
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
			groupBox1.Size = new Size(269, 53);
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
			Dgv_QueriesPart1.Size = new Size(550, 644);
			Dgv_QueriesPart1.TabIndex = 0;
			// 
			// TabPage_Editing
			// 
			TabPage_Editing.Controls.Add(tabControl3);
			TabPage_Editing.Location = new Point(4, 24);
			TabPage_Editing.Name = "TabPage_Editing";
			TabPage_Editing.Padding = new Padding(3);
			TabPage_Editing.Size = new Size(1139, 696);
			TabPage_Editing.TabIndex = 1;
			TabPage_Editing.Text = "Editing";
			TabPage_Editing.UseVisualStyleBackColor = true;
			// 
			// tabControl3
			// 
			tabControl3.Controls.Add(tabPage5);
			tabControl3.Controls.Add(tabPage6);
			tabControl3.Location = new Point(6, 6);
			tabControl3.Name = "tabControl3";
			tabControl3.SelectedIndex = 0;
			tabControl3.Size = new Size(1127, 684);
			tabControl3.TabIndex = 0;
			// 
			// tabPage5
			// 
			tabPage5.Location = new Point(4, 24);
			tabPage5.Name = "tabPage5";
			tabPage5.Padding = new Padding(3);
			tabPage5.Size = new Size(1119, 656);
			tabPage5.TabIndex = 0;
			tabPage5.Text = "tabPage5";
			tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			tabPage6.Location = new Point(4, 24);
			tabPage6.Name = "tabPage6";
			tabPage6.Padding = new Padding(3);
			tabPage6.Size = new Size(1119, 656);
			tabPage6.TabIndex = 1;
			tabPage6.Text = "tabPage6";
			tabPage6.UseVisualStyleBackColor = true;
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
			TabPage_Editing.ResumeLayout(false);
			tabControl3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabControl_Main;
		private TabPage TabPage_Queries;
		private TabControl TabControl_Queries;
		private TabPage TabPage_QuriesPart1;
		private TabPage TabPage_Editing;
		private TabControl tabControl3;
		private TabPage tabPage5;
		private TabPage tabPage6;
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
	}
}