namespace Chess_Application
{
	partial class ChessChampionship
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
			TabPage_Editing = new TabPage();
			TabControl_Editing = new TabControl();
			TabPage_Participants = new TabPage();
			label7 = new Label();
			TextBox_ParticipantSurname = new TextBox();
			Btn_SaveChangesParticipant = new Button();
			Btn_RemoveParticipant = new Button();
			Btn_AddParticipant = new Button();
			TextBox_ParticipantRating = new TextBox();
			label6 = new Label();
			DTPicker_ParticipantBirthdate = new DateTimePicker();
			label5 = new Label();
			label4 = new Label();
			TextBox_ParticipantName = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			Dgv_ParticipantCompetitions = new DataGridView();
			Col_ParticipantCompetitionsTournament = new DataGridViewTextBoxColumn();
			Col_ParticipantCompetitionsPlayer1 = new DataGridViewTextBoxColumn();
			Col_ParticipantCompetitionsPlayer2 = new DataGridViewTextBoxColumn();
			Col_ParticipantCompetitionsTimeStart = new DataGridViewTextBoxColumn();
			Col_ParticipantCompetitionsTimeEnd = new DataGridViewTextBoxColumn();
			Dgv_ParticipantTournaments = new DataGridView();
			Col_ParticipantTournamentsName = new DataGridViewTextBoxColumn();
			Col_ParticipantTournamentsVenue = new DataGridViewTextBoxColumn();
			Col_ParticipantTournamentsDateStart = new DataGridViewTextBoxColumn();
			Col_ParticipantTournamentsDateEnd = new DataGridViewTextBoxColumn();
			Dgv_ParticipantsEditing = new DataGridView();
			Col_ParticipantName = new DataGridViewTextBoxColumn();
			Col_ParticipantSurname = new DataGridViewTextBoxColumn();
			Col_ParticipantBirthdate = new DataGridViewTextBoxColumn();
			Col_ParticipantRating = new DataGridViewTextBoxColumn();
			TabPage_Venues = new TabPage();
			label12 = new Label();
			label21 = new Label();
			Dgv_VenueTournaments = new DataGridView();
			Col_VenueTournamentsName = new DataGridViewTextBoxColumn();
			Col_VenueTournamentsDateStart = new DataGridViewTextBoxColumn();
			Col_VenueTournamentsDateEnd = new DataGridViewTextBoxColumn();
			Col_VenueTournamentsChampion = new DataGridViewTextBoxColumn();
			Dgv_VenuesEditing = new DataGridView();
			Col_VenuesName = new DataGridViewTextBoxColumn();
			Col_VenuesCountry = new DataGridViewTextBoxColumn();
			Col_VenuesCity = new DataGridViewTextBoxColumn();
			label8 = new Label();
			TextBox_VenueCountry = new TextBox();
			Btn_SaveChangesVenue = new Button();
			Btn_RemoveVenue = new Button();
			Btn_AddVenue = new Button();
			TextBox_VenueCity = new TextBox();
			label9 = new Label();
			label11 = new Label();
			TextBox_VenueName = new TextBox();
			TabPage_Tournaments = new TabPage();
			CheckBox_TournamentDateStart = new CheckBox();
			CheckBox_TournamentDateEnd = new CheckBox();
			label20 = new Label();
			DTPicker_TournamentEndDate = new DateTimePicker();
			CheckBox_TournamentChampion = new CheckBox();
			ComboBox_TournamentChampion = new ComboBox();
			label19 = new Label();
			ComboBox_TournamentVenue = new ComboBox();
			Btn_SaveChangesTournament = new Button();
			Btn_RemoveTournament = new Button();
			Btn_AddTournament = new Button();
			label13 = new Label();
			DTPicker_TournamentStartDate = new DateTimePicker();
			label14 = new Label();
			label15 = new Label();
			TextBox_TournamentName = new TextBox();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			Dgv_TournamentsCompetitions = new DataGridView();
			Col_TournamentCompetitionsId = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsPlayer1 = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsPlayer2 = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsTimeStart = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsTimeEnd = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsChampionName = new DataGridViewTextBoxColumn();
			Col_TournamentCompetitionsChampionSurname = new DataGridViewTextBoxColumn();
			Dgv_TournamentsParticipants = new DataGridView();
			Col_TournamentParticipantsName = new DataGridViewTextBoxColumn();
			Col_TournamentParticipantsSurname = new DataGridViewTextBoxColumn();
			Col_TournamentParticipantsDateBirth = new DataGridViewTextBoxColumn();
			Col_TournamentParticipantsRating = new DataGridViewTextBoxColumn();
			Dgv_TournamentsEditing = new DataGridView();
			Col_TournamentsName = new DataGridViewTextBoxColumn();
			Col_TournamentsVenue = new DataGridViewTextBoxColumn();
			Col_TournamentsDateStart = new DataGridViewTextBoxColumn();
			Col_TournamentsDateEnd = new DataGridViewTextBoxColumn();
			Col_TournamentsChampion = new DataGridViewTextBoxColumn();
			Col_TournamentsChampionSurname = new DataGridViewTextBoxColumn();
			TabPage_Competitions = new TabPage();
			CheckBox_CompetitionEnd = new CheckBox();
			label30 = new Label();
			Nud_EndMinute = new NumericUpDown();
			label31 = new Label();
			Nud_EndHour = new NumericUpDown();
			label32 = new Label();
			CheckBox_CompetitionStart = new CheckBox();
			label29 = new Label();
			Nud_StartMinute = new NumericUpDown();
			label28 = new Label();
			Nud_StartHour = new NumericUpDown();
			label26 = new Label();
			Btn_SaveChangesCompetition = new Button();
			Btn_RemoveCompetition = new Button();
			Btn_AddCompetition = new Button();
			DTPicker_CompetitionDateMatch = new DateTimePicker();
			label27 = new Label();
			CheckBox_CompetitionWinner = new CheckBox();
			ComboBox_CompetitionWinner = new ComboBox();
			label25 = new Label();
			ComboBox_CompetitionPlayer2 = new ComboBox();
			label24 = new Label();
			ComboBox_CompetitionPlayer1 = new ComboBox();
			label23 = new Label();
			ComboBox_CompetitionTournament = new ComboBox();
			label22 = new Label();
			label10 = new Label();
			Dgv_CompetitionsEditing = new DataGridView();
			Col_CompetitionsTournament = new DataGridViewTextBoxColumn();
			Col_CompetitionsPlayer1Name = new DataGridViewTextBoxColumn();
			Col_CompetitionsPlayer1Surname = new DataGridViewTextBoxColumn();
			Col_CompetitionsPlayer2Name = new DataGridViewTextBoxColumn();
			Col_CompetitionsPlayer2Surname = new DataGridViewTextBoxColumn();
			Col_CompetitionsTimeStart = new DataGridViewTextBoxColumn();
			Col_CompetitionsTimeEnd = new DataGridViewTextBoxColumn();
			Col_CompetitionsWinnerName = new DataGridViewTextBoxColumn();
			Col_CompetitionsWinnerSurname = new DataGridViewTextBoxColumn();
			TabPage_Queries = new TabPage();
			dataGridView1 = new DataGridView();
			TabControl_Main.SuspendLayout();
			TabPage_Editing.SuspendLayout();
			TabControl_Editing.SuspendLayout();
			TabPage_Participants.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantCompetitions).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantTournaments).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantsEditing).BeginInit();
			TabPage_Venues.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_VenueTournaments).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_VenuesEditing).BeginInit();
			TabPage_Tournaments.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsCompetitions).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsParticipants).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsEditing).BeginInit();
			TabPage_Competitions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)Nud_EndMinute).BeginInit();
			((System.ComponentModel.ISupportInitialize)Nud_EndHour).BeginInit();
			((System.ComponentModel.ISupportInitialize)Nud_StartMinute).BeginInit();
			((System.ComponentModel.ISupportInitialize)Nud_StartHour).BeginInit();
			((System.ComponentModel.ISupportInitialize)Dgv_CompetitionsEditing).BeginInit();
			TabPage_Queries.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// TabControl_Main
			// 
			TabControl_Main.Controls.Add(TabPage_Editing);
			TabControl_Main.Controls.Add(TabPage_Queries);
			TabControl_Main.Location = new Point(12, 12);
			TabControl_Main.Name = "TabControl_Main";
			TabControl_Main.SelectedIndex = 0;
			TabControl_Main.Size = new Size(1191, 700);
			TabControl_Main.TabIndex = 0;
			// 
			// TabPage_Editing
			// 
			TabPage_Editing.Controls.Add(TabControl_Editing);
			TabPage_Editing.Location = new Point(4, 24);
			TabPage_Editing.Name = "TabPage_Editing";
			TabPage_Editing.Padding = new Padding(3);
			TabPage_Editing.Size = new Size(1183, 672);
			TabPage_Editing.TabIndex = 0;
			TabPage_Editing.Text = "Editing";
			TabPage_Editing.UseVisualStyleBackColor = true;
			// 
			// TabControl_Editing
			// 
			TabControl_Editing.Controls.Add(TabPage_Participants);
			TabControl_Editing.Controls.Add(TabPage_Venues);
			TabControl_Editing.Controls.Add(TabPage_Tournaments);
			TabControl_Editing.Controls.Add(TabPage_Competitions);
			TabControl_Editing.Location = new Point(6, 6);
			TabControl_Editing.Name = "TabControl_Editing";
			TabControl_Editing.SelectedIndex = 0;
			TabControl_Editing.Size = new Size(1171, 660);
			TabControl_Editing.TabIndex = 0;
			TabControl_Editing.Selected += TabControl_Editing_Selected;
			// 
			// TabPage_Participants
			// 
			TabPage_Participants.Controls.Add(label7);
			TabPage_Participants.Controls.Add(TextBox_ParticipantSurname);
			TabPage_Participants.Controls.Add(Btn_SaveChangesParticipant);
			TabPage_Participants.Controls.Add(Btn_RemoveParticipant);
			TabPage_Participants.Controls.Add(Btn_AddParticipant);
			TabPage_Participants.Controls.Add(TextBox_ParticipantRating);
			TabPage_Participants.Controls.Add(label6);
			TabPage_Participants.Controls.Add(DTPicker_ParticipantBirthdate);
			TabPage_Participants.Controls.Add(label5);
			TabPage_Participants.Controls.Add(label4);
			TabPage_Participants.Controls.Add(TextBox_ParticipantName);
			TabPage_Participants.Controls.Add(label3);
			TabPage_Participants.Controls.Add(label2);
			TabPage_Participants.Controls.Add(label1);
			TabPage_Participants.Controls.Add(Dgv_ParticipantCompetitions);
			TabPage_Participants.Controls.Add(Dgv_ParticipantTournaments);
			TabPage_Participants.Controls.Add(Dgv_ParticipantsEditing);
			TabPage_Participants.Location = new Point(4, 24);
			TabPage_Participants.Name = "TabPage_Participants";
			TabPage_Participants.Padding = new Padding(3);
			TabPage_Participants.Size = new Size(1163, 632);
			TabPage_Participants.TabIndex = 0;
			TabPage_Participants.Text = "Participants";
			TabPage_Participants.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(3, 536);
			label7.Name = "label7";
			label7.Size = new Size(54, 15);
			label7.TabIndex = 16;
			label7.Text = "Surname";
			// 
			// TextBox_ParticipantSurname
			// 
			TextBox_ParticipantSurname.Location = new Point(3, 554);
			TextBox_ParticipantSurname.Name = "TextBox_ParticipantSurname";
			TextBox_ParticipantSurname.Size = new Size(200, 23);
			TextBox_ParticipantSurname.TabIndex = 15;
			// 
			// Btn_SaveChangesParticipant
			// 
			Btn_SaveChangesParticipant.Location = new Point(107, 598);
			Btn_SaveChangesParticipant.Name = "Btn_SaveChangesParticipant";
			Btn_SaveChangesParticipant.Size = new Size(95, 23);
			Btn_SaveChangesParticipant.TabIndex = 14;
			Btn_SaveChangesParticipant.Text = "Save Changes";
			Btn_SaveChangesParticipant.UseVisualStyleBackColor = true;
			Btn_SaveChangesParticipant.Click += Btn_SaveChangesParticipant_Click;
			// 
			// Btn_RemoveParticipant
			// 
			Btn_RemoveParticipant.Location = new Point(208, 598);
			Btn_RemoveParticipant.Name = "Btn_RemoveParticipant";
			Btn_RemoveParticipant.Size = new Size(95, 23);
			Btn_RemoveParticipant.TabIndex = 13;
			Btn_RemoveParticipant.Text = "Remove";
			Btn_RemoveParticipant.UseVisualStyleBackColor = true;
			Btn_RemoveParticipant.Click += Btn_RemoveParticipant_Click;
			// 
			// Btn_AddParticipant
			// 
			Btn_AddParticipant.Location = new Point(6, 598);
			Btn_AddParticipant.Name = "Btn_AddParticipant";
			Btn_AddParticipant.Size = new Size(95, 23);
			Btn_AddParticipant.TabIndex = 12;
			Btn_AddParticipant.Text = "Add";
			Btn_AddParticipant.UseVisualStyleBackColor = true;
			Btn_AddParticipant.Click += Btn_AddParticipant_Click;
			// 
			// TextBox_ParticipantRating
			// 
			TextBox_ParticipantRating.Location = new Point(220, 554);
			TextBox_ParticipantRating.Name = "TextBox_ParticipantRating";
			TextBox_ParticipantRating.Size = new Size(200, 23);
			TextBox_ParticipantRating.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(220, 536);
			label6.Name = "label6";
			label6.Size = new Size(41, 15);
			label6.TabIndex = 10;
			label6.Text = "Rating";
			// 
			// DTPicker_ParticipantBirthdate
			// 
			DTPicker_ParticipantBirthdate.Location = new Point(220, 502);
			DTPicker_ParticipantBirthdate.Name = "DTPicker_ParticipantBirthdate";
			DTPicker_ParticipantBirthdate.Size = new Size(200, 23);
			DTPicker_ParticipantBirthdate.TabIndex = 9;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(220, 484);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 8;
			label5.Text = "Birthdate";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 484);
			label4.Name = "label4";
			label4.Size = new Size(39, 15);
			label4.TabIndex = 7;
			label4.Text = "Name";
			// 
			// TextBox_ParticipantName
			// 
			TextBox_ParticipantName.Location = new Point(3, 502);
			TextBox_ParticipantName.Name = "TextBox_ParticipantName";
			TextBox_ParticipantName.Size = new Size(200, 23);
			TextBox_ParticipantName.TabIndex = 6;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(426, 16);
			label3.Name = "label3";
			label3.Size = new Size(147, 15);
			label3.TabIndex = 5;
			label3.Text = "Participant's Competitions";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(426, 311);
			label2.Name = "label2";
			label2.Size = new Size(143, 15);
			label2.TabIndex = 4;
			label2.Text = "Participant's tournaments";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 16);
			label1.Name = "label1";
			label1.Size = new Size(69, 15);
			label1.TabIndex = 3;
			label1.Text = "Participants";
			// 
			// Dgv_ParticipantCompetitions
			// 
			Dgv_ParticipantCompetitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_ParticipantCompetitions.Columns.AddRange(new DataGridViewColumn[] { Col_ParticipantCompetitionsTournament, Col_ParticipantCompetitionsPlayer1, Col_ParticipantCompetitionsPlayer2, Col_ParticipantCompetitionsTimeStart, Col_ParticipantCompetitionsTimeEnd });
			Dgv_ParticipantCompetitions.Location = new Point(426, 34);
			Dgv_ParticipantCompetitions.MultiSelect = false;
			Dgv_ParticipantCompetitions.Name = "Dgv_ParticipantCompetitions";
			Dgv_ParticipantCompetitions.ReadOnly = true;
			Dgv_ParticipantCompetitions.RowTemplate.Height = 25;
			Dgv_ParticipantCompetitions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Dgv_ParticipantCompetitions.Size = new Size(731, 272);
			Dgv_ParticipantCompetitions.TabIndex = 2;
			// 
			// Col_ParticipantCompetitionsTournament
			// 
			Col_ParticipantCompetitionsTournament.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantCompetitionsTournament.DataPropertyName = "Tournament.Name";
			Col_ParticipantCompetitionsTournament.HeaderText = "Tournament";
			Col_ParticipantCompetitionsTournament.Name = "Col_ParticipantCompetitionsTournament";
			Col_ParticipantCompetitionsTournament.ReadOnly = true;
			// 
			// Col_ParticipantCompetitionsPlayer1
			// 
			Col_ParticipantCompetitionsPlayer1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantCompetitionsPlayer1.DataPropertyName = "Player1.Name";
			Col_ParticipantCompetitionsPlayer1.HeaderText = "Player 1";
			Col_ParticipantCompetitionsPlayer1.Name = "Col_ParticipantCompetitionsPlayer1";
			Col_ParticipantCompetitionsPlayer1.ReadOnly = true;
			// 
			// Col_ParticipantCompetitionsPlayer2
			// 
			Col_ParticipantCompetitionsPlayer2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantCompetitionsPlayer2.DataPropertyName = "Player2.Name";
			Col_ParticipantCompetitionsPlayer2.HeaderText = "Player 2";
			Col_ParticipantCompetitionsPlayer2.Name = "Col_ParticipantCompetitionsPlayer2";
			Col_ParticipantCompetitionsPlayer2.ReadOnly = true;
			// 
			// Col_ParticipantCompetitionsTimeStart
			// 
			Col_ParticipantCompetitionsTimeStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantCompetitionsTimeStart.DataPropertyName = "TimeOfStart";
			Col_ParticipantCompetitionsTimeStart.HeaderText = "Time start";
			Col_ParticipantCompetitionsTimeStart.Name = "Col_ParticipantCompetitionsTimeStart";
			Col_ParticipantCompetitionsTimeStart.ReadOnly = true;
			// 
			// Col_ParticipantCompetitionsTimeEnd
			// 
			Col_ParticipantCompetitionsTimeEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantCompetitionsTimeEnd.DataPropertyName = "TimeOfEnd";
			Col_ParticipantCompetitionsTimeEnd.HeaderText = "Time end";
			Col_ParticipantCompetitionsTimeEnd.Name = "Col_ParticipantCompetitionsTimeEnd";
			Col_ParticipantCompetitionsTimeEnd.ReadOnly = true;
			// 
			// Dgv_ParticipantTournaments
			// 
			Dgv_ParticipantTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_ParticipantTournaments.Columns.AddRange(new DataGridViewColumn[] { Col_ParticipantTournamentsName, Col_ParticipantTournamentsVenue, Col_ParticipantTournamentsDateStart, Col_ParticipantTournamentsDateEnd });
			Dgv_ParticipantTournaments.Location = new Point(426, 329);
			Dgv_ParticipantTournaments.MultiSelect = false;
			Dgv_ParticipantTournaments.Name = "Dgv_ParticipantTournaments";
			Dgv_ParticipantTournaments.ReadOnly = true;
			Dgv_ParticipantTournaments.RowTemplate.Height = 25;
			Dgv_ParticipantTournaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Dgv_ParticipantTournaments.Size = new Size(731, 297);
			Dgv_ParticipantTournaments.TabIndex = 1;
			// 
			// Col_ParticipantTournamentsName
			// 
			Col_ParticipantTournamentsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantTournamentsName.DataPropertyName = "Name";
			Col_ParticipantTournamentsName.HeaderText = "Name";
			Col_ParticipantTournamentsName.Name = "Col_ParticipantTournamentsName";
			Col_ParticipantTournamentsName.ReadOnly = true;
			// 
			// Col_ParticipantTournamentsVenue
			// 
			Col_ParticipantTournamentsVenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantTournamentsVenue.DataPropertyName = "Venue.Name";
			Col_ParticipantTournamentsVenue.HeaderText = "Venue";
			Col_ParticipantTournamentsVenue.Name = "Col_ParticipantTournamentsVenue";
			Col_ParticipantTournamentsVenue.ReadOnly = true;
			// 
			// Col_ParticipantTournamentsDateStart
			// 
			Col_ParticipantTournamentsDateStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantTournamentsDateStart.DataPropertyName = "DateOfStart";
			Col_ParticipantTournamentsDateStart.HeaderText = "Date start";
			Col_ParticipantTournamentsDateStart.Name = "Col_ParticipantTournamentsDateStart";
			Col_ParticipantTournamentsDateStart.ReadOnly = true;
			// 
			// Col_ParticipantTournamentsDateEnd
			// 
			Col_ParticipantTournamentsDateEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantTournamentsDateEnd.DataPropertyName = "DateOfEnd";
			Col_ParticipantTournamentsDateEnd.HeaderText = "Date end";
			Col_ParticipantTournamentsDateEnd.Name = "Col_ParticipantTournamentsDateEnd";
			Col_ParticipantTournamentsDateEnd.ReadOnly = true;
			// 
			// Dgv_ParticipantsEditing
			// 
			Dgv_ParticipantsEditing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_ParticipantsEditing.Columns.AddRange(new DataGridViewColumn[] { Col_ParticipantName, Col_ParticipantSurname, Col_ParticipantBirthdate, Col_ParticipantRating });
			Dgv_ParticipantsEditing.Location = new Point(3, 34);
			Dgv_ParticipantsEditing.MultiSelect = false;
			Dgv_ParticipantsEditing.Name = "Dgv_ParticipantsEditing";
			Dgv_ParticipantsEditing.ReadOnly = true;
			Dgv_ParticipantsEditing.RightToLeft = RightToLeft.No;
			Dgv_ParticipantsEditing.RowTemplate.Height = 25;
			Dgv_ParticipantsEditing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			Dgv_ParticipantsEditing.Size = new Size(417, 447);
			Dgv_ParticipantsEditing.TabIndex = 0;
			Dgv_ParticipantsEditing.SelectionChanged += Dgv_ParticipantsEditing_SelectionChanged;
			// 
			// Col_ParticipantName
			// 
			Col_ParticipantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantName.DataPropertyName = "Name";
			Col_ParticipantName.HeaderText = "Name";
			Col_ParticipantName.Name = "Col_ParticipantName";
			Col_ParticipantName.ReadOnly = true;
			// 
			// Col_ParticipantSurname
			// 
			Col_ParticipantSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantSurname.DataPropertyName = "Surname";
			Col_ParticipantSurname.HeaderText = "Surname";
			Col_ParticipantSurname.Name = "Col_ParticipantSurname";
			Col_ParticipantSurname.ReadOnly = true;
			// 
			// Col_ParticipantBirthdate
			// 
			Col_ParticipantBirthdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantBirthdate.DataPropertyName = "Birth";
			Col_ParticipantBirthdate.HeaderText = "Birthdate";
			Col_ParticipantBirthdate.Name = "Col_ParticipantBirthdate";
			Col_ParticipantBirthdate.ReadOnly = true;
			// 
			// Col_ParticipantRating
			// 
			Col_ParticipantRating.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_ParticipantRating.DataPropertyName = "Rating";
			Col_ParticipantRating.HeaderText = "Rating";
			Col_ParticipantRating.Name = "Col_ParticipantRating";
			Col_ParticipantRating.ReadOnly = true;
			// 
			// TabPage_Venues
			// 
			TabPage_Venues.Controls.Add(label12);
			TabPage_Venues.Controls.Add(label21);
			TabPage_Venues.Controls.Add(Dgv_VenueTournaments);
			TabPage_Venues.Controls.Add(Dgv_VenuesEditing);
			TabPage_Venues.Controls.Add(label8);
			TabPage_Venues.Controls.Add(TextBox_VenueCountry);
			TabPage_Venues.Controls.Add(Btn_SaveChangesVenue);
			TabPage_Venues.Controls.Add(Btn_RemoveVenue);
			TabPage_Venues.Controls.Add(Btn_AddVenue);
			TabPage_Venues.Controls.Add(TextBox_VenueCity);
			TabPage_Venues.Controls.Add(label9);
			TabPage_Venues.Controls.Add(label11);
			TabPage_Venues.Controls.Add(TextBox_VenueName);
			TabPage_Venues.Location = new Point(4, 24);
			TabPage_Venues.Name = "TabPage_Venues";
			TabPage_Venues.Padding = new Padding(3);
			TabPage_Venues.Size = new Size(1163, 632);
			TabPage_Venues.TabIndex = 1;
			TabPage_Venues.Text = "Venues";
			TabPage_Venues.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(513, 14);
			label12.Name = "label12";
			label12.Size = new Size(118, 15);
			label12.TabIndex = 31;
			label12.Text = "Venue`s tournaments";
			// 
			// label21
			// 
			label21.AutoSize = true;
			label21.Location = new Point(6, 14);
			label21.Name = "label21";
			label21.Size = new Size(44, 15);
			label21.TabIndex = 30;
			label21.Text = "Venues";
			// 
			// Dgv_VenueTournaments
			// 
			Dgv_VenueTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_VenueTournaments.Columns.AddRange(new DataGridViewColumn[] { Col_VenueTournamentsName, Col_VenueTournamentsDateStart, Col_VenueTournamentsDateEnd, Col_VenueTournamentsChampion });
			Dgv_VenueTournaments.Location = new Point(513, 32);
			Dgv_VenueTournaments.Name = "Dgv_VenueTournaments";
			Dgv_VenueTournaments.RowTemplate.Height = 25;
			Dgv_VenueTournaments.Size = new Size(644, 452);
			Dgv_VenueTournaments.TabIndex = 29;
			// 
			// Col_VenueTournamentsName
			// 
			Col_VenueTournamentsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenueTournamentsName.DataPropertyName = "Name";
			Col_VenueTournamentsName.HeaderText = "Name";
			Col_VenueTournamentsName.Name = "Col_VenueTournamentsName";
			// 
			// Col_VenueTournamentsDateStart
			// 
			Col_VenueTournamentsDateStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenueTournamentsDateStart.DataPropertyName = "DateOfStart";
			Col_VenueTournamentsDateStart.HeaderText = "Date start";
			Col_VenueTournamentsDateStart.Name = "Col_VenueTournamentsDateStart";
			// 
			// Col_VenueTournamentsDateEnd
			// 
			Col_VenueTournamentsDateEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenueTournamentsDateEnd.DataPropertyName = "DateOfEnd";
			Col_VenueTournamentsDateEnd.HeaderText = "Date end";
			Col_VenueTournamentsDateEnd.Name = "Col_VenueTournamentsDateEnd";
			// 
			// Col_VenueTournamentsChampion
			// 
			Col_VenueTournamentsChampion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenueTournamentsChampion.DataPropertyName = "Champion.Name";
			Col_VenueTournamentsChampion.HeaderText = "Champion";
			Col_VenueTournamentsChampion.Name = "Col_VenueTournamentsChampion";
			// 
			// Dgv_VenuesEditing
			// 
			Dgv_VenuesEditing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_VenuesEditing.Columns.AddRange(new DataGridViewColumn[] { Col_VenuesName, Col_VenuesCountry, Col_VenuesCity });
			Dgv_VenuesEditing.Location = new Point(3, 32);
			Dgv_VenuesEditing.Name = "Dgv_VenuesEditing";
			Dgv_VenuesEditing.RowTemplate.Height = 25;
			Dgv_VenuesEditing.Size = new Size(504, 452);
			Dgv_VenuesEditing.TabIndex = 28;
			Dgv_VenuesEditing.SelectionChanged += Dgv_VenuesEditing_SelectionChanged;
			// 
			// Col_VenuesName
			// 
			Col_VenuesName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenuesName.DataPropertyName = "Name";
			Col_VenuesName.HeaderText = "Name";
			Col_VenuesName.Name = "Col_VenuesName";
			// 
			// Col_VenuesCountry
			// 
			Col_VenuesCountry.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenuesCountry.DataPropertyName = "Country";
			Col_VenuesCountry.HeaderText = "Country";
			Col_VenuesCountry.Name = "Col_VenuesCountry";
			// 
			// Col_VenuesCity
			// 
			Col_VenuesCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_VenuesCity.DataPropertyName = "City";
			Col_VenuesCity.HeaderText = "City";
			Col_VenuesCity.Name = "Col_VenuesCity";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(3, 539);
			label8.Name = "label8";
			label8.Size = new Size(50, 15);
			label8.TabIndex = 27;
			label8.Text = "Country";
			// 
			// TextBox_VenueCountry
			// 
			TextBox_VenueCountry.Location = new Point(3, 557);
			TextBox_VenueCountry.Name = "TextBox_VenueCountry";
			TextBox_VenueCountry.Size = new Size(200, 23);
			TextBox_VenueCountry.TabIndex = 26;
			// 
			// Btn_SaveChangesVenue
			// 
			Btn_SaveChangesVenue.Location = new Point(107, 598);
			Btn_SaveChangesVenue.Name = "Btn_SaveChangesVenue";
			Btn_SaveChangesVenue.Size = new Size(95, 23);
			Btn_SaveChangesVenue.TabIndex = 25;
			Btn_SaveChangesVenue.Text = "Save Changes";
			Btn_SaveChangesVenue.UseVisualStyleBackColor = true;
			Btn_SaveChangesVenue.Click += Btn_SaveChangesVenue_Click;
			// 
			// Btn_RemoveVenue
			// 
			Btn_RemoveVenue.Location = new Point(208, 598);
			Btn_RemoveVenue.Name = "Btn_RemoveVenue";
			Btn_RemoveVenue.Size = new Size(95, 23);
			Btn_RemoveVenue.TabIndex = 24;
			Btn_RemoveVenue.Text = "Remove";
			Btn_RemoveVenue.UseVisualStyleBackColor = true;
			Btn_RemoveVenue.Click += Btn_RemoveVenue_Click;
			// 
			// Btn_AddVenue
			// 
			Btn_AddVenue.Location = new Point(6, 598);
			Btn_AddVenue.Name = "Btn_AddVenue";
			Btn_AddVenue.Size = new Size(95, 23);
			Btn_AddVenue.TabIndex = 23;
			Btn_AddVenue.Text = "Add";
			Btn_AddVenue.UseVisualStyleBackColor = true;
			Btn_AddVenue.Click += Btn_AddVenue_Click;
			// 
			// TextBox_VenueCity
			// 
			TextBox_VenueCity.Location = new Point(209, 505);
			TextBox_VenueCity.Name = "TextBox_VenueCity";
			TextBox_VenueCity.Size = new Size(200, 23);
			TextBox_VenueCity.TabIndex = 22;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(209, 487);
			label9.Name = "label9";
			label9.Size = new Size(28, 15);
			label9.TabIndex = 21;
			label9.Text = "City";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(3, 487);
			label11.Name = "label11";
			label11.Size = new Size(39, 15);
			label11.TabIndex = 18;
			label11.Text = "Name";
			// 
			// TextBox_VenueName
			// 
			TextBox_VenueName.Location = new Point(3, 505);
			TextBox_VenueName.Name = "TextBox_VenueName";
			TextBox_VenueName.Size = new Size(200, 23);
			TextBox_VenueName.TabIndex = 17;
			// 
			// TabPage_Tournaments
			// 
			TabPage_Tournaments.Controls.Add(CheckBox_TournamentDateStart);
			TabPage_Tournaments.Controls.Add(CheckBox_TournamentDateEnd);
			TabPage_Tournaments.Controls.Add(label20);
			TabPage_Tournaments.Controls.Add(DTPicker_TournamentEndDate);
			TabPage_Tournaments.Controls.Add(CheckBox_TournamentChampion);
			TabPage_Tournaments.Controls.Add(ComboBox_TournamentChampion);
			TabPage_Tournaments.Controls.Add(label19);
			TabPage_Tournaments.Controls.Add(ComboBox_TournamentVenue);
			TabPage_Tournaments.Controls.Add(Btn_SaveChangesTournament);
			TabPage_Tournaments.Controls.Add(Btn_RemoveTournament);
			TabPage_Tournaments.Controls.Add(Btn_AddTournament);
			TabPage_Tournaments.Controls.Add(label13);
			TabPage_Tournaments.Controls.Add(DTPicker_TournamentStartDate);
			TabPage_Tournaments.Controls.Add(label14);
			TabPage_Tournaments.Controls.Add(label15);
			TabPage_Tournaments.Controls.Add(TextBox_TournamentName);
			TabPage_Tournaments.Controls.Add(label16);
			TabPage_Tournaments.Controls.Add(label17);
			TabPage_Tournaments.Controls.Add(label18);
			TabPage_Tournaments.Controls.Add(Dgv_TournamentsCompetitions);
			TabPage_Tournaments.Controls.Add(Dgv_TournamentsParticipants);
			TabPage_Tournaments.Controls.Add(Dgv_TournamentsEditing);
			TabPage_Tournaments.Location = new Point(4, 24);
			TabPage_Tournaments.Name = "TabPage_Tournaments";
			TabPage_Tournaments.Size = new Size(1163, 632);
			TabPage_Tournaments.TabIndex = 2;
			TabPage_Tournaments.Text = "Tournaments";
			TabPage_Tournaments.UseVisualStyleBackColor = true;
			// 
			// CheckBox_TournamentDateStart
			// 
			CheckBox_TournamentDateStart.AutoSize = true;
			CheckBox_TournamentDateStart.Checked = true;
			CheckBox_TournamentDateStart.CheckState = CheckState.Checked;
			CheckBox_TournamentDateStart.Location = new Point(100, 529);
			CheckBox_TournamentDateStart.Name = "CheckBox_TournamentDateStart";
			CheckBox_TournamentDateStart.Size = new Size(15, 14);
			CheckBox_TournamentDateStart.TabIndex = 66;
			CheckBox_TournamentDateStart.UseVisualStyleBackColor = true;
			CheckBox_TournamentDateStart.CheckedChanged += CheckBox_TournamentDateStart_CheckedChanged;
			// 
			// CheckBox_TournamentDateEnd
			// 
			CheckBox_TournamentDateEnd.AutoSize = true;
			CheckBox_TournamentDateEnd.Checked = true;
			CheckBox_TournamentDateEnd.CheckState = CheckState.Checked;
			CheckBox_TournamentDateEnd.Location = new Point(306, 529);
			CheckBox_TournamentDateEnd.Name = "CheckBox_TournamentDateEnd";
			CheckBox_TournamentDateEnd.Size = new Size(15, 14);
			CheckBox_TournamentDateEnd.TabIndex = 65;
			CheckBox_TournamentDateEnd.UseVisualStyleBackColor = true;
			CheckBox_TournamentDateEnd.CheckedChanged += CheckBox_TournamentDateEnd_CheckedChanged;
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new Point(212, 528);
			label20.Name = "label20";
			label20.Size = new Size(88, 15);
			label20.TabIndex = 47;
			label20.Text = "Date of the end";
			// 
			// DTPicker_TournamentEndDate
			// 
			DTPicker_TournamentEndDate.Location = new Point(212, 546);
			DTPicker_TournamentEndDate.Name = "DTPicker_TournamentEndDate";
			DTPicker_TournamentEndDate.Size = new Size(198, 23);
			DTPicker_TournamentEndDate.TabIndex = 46;
			// 
			// CheckBox_TournamentChampion
			// 
			CheckBox_TournamentChampion.AutoSize = true;
			CheckBox_TournamentChampion.Checked = true;
			CheckBox_TournamentChampion.CheckState = CheckState.Checked;
			CheckBox_TournamentChampion.Location = new Point(473, 484);
			CheckBox_TournamentChampion.Name = "CheckBox_TournamentChampion";
			CheckBox_TournamentChampion.Size = new Size(15, 14);
			CheckBox_TournamentChampion.TabIndex = 45;
			CheckBox_TournamentChampion.UseVisualStyleBackColor = true;
			CheckBox_TournamentChampion.CheckedChanged += CheckBox_TournamentChampion_CheckedChanged;
			// 
			// ComboBox_TournamentChampion
			// 
			ComboBox_TournamentChampion.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_TournamentChampion.FormattingEnabled = true;
			ComboBox_TournamentChampion.Location = new Point(404, 501);
			ComboBox_TournamentChampion.Name = "ComboBox_TournamentChampion";
			ComboBox_TournamentChampion.Size = new Size(189, 23);
			ComboBox_TournamentChampion.TabIndex = 44;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new Point(404, 483);
			label19.Name = "label19";
			label19.Size = new Size(63, 15);
			label19.TabIndex = 43;
			label19.Text = "Champion";
			// 
			// ComboBox_TournamentVenue
			// 
			ComboBox_TournamentVenue.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_TournamentVenue.FormattingEnabled = true;
			ComboBox_TournamentVenue.Location = new Point(209, 501);
			ComboBox_TournamentVenue.Name = "ComboBox_TournamentVenue";
			ComboBox_TournamentVenue.Size = new Size(189, 23);
			ComboBox_TournamentVenue.TabIndex = 42;
			// 
			// Btn_SaveChangesTournament
			// 
			Btn_SaveChangesTournament.Location = new Point(111, 601);
			Btn_SaveChangesTournament.Name = "Btn_SaveChangesTournament";
			Btn_SaveChangesTournament.Size = new Size(95, 23);
			Btn_SaveChangesTournament.TabIndex = 35;
			Btn_SaveChangesTournament.Text = "Save Changes";
			Btn_SaveChangesTournament.UseVisualStyleBackColor = true;
			Btn_SaveChangesTournament.Click += Btn_SaveChangesTournament_Click;
			// 
			// Btn_RemoveTournament
			// 
			Btn_RemoveTournament.Location = new Point(212, 601);
			Btn_RemoveTournament.Name = "Btn_RemoveTournament";
			Btn_RemoveTournament.Size = new Size(95, 23);
			Btn_RemoveTournament.TabIndex = 34;
			Btn_RemoveTournament.Text = "Remove";
			Btn_RemoveTournament.UseVisualStyleBackColor = true;
			Btn_RemoveTournament.Click += Btn_RemoveTournament_Click;
			// 
			// Btn_AddTournament
			// 
			Btn_AddTournament.Location = new Point(8, 601);
			Btn_AddTournament.Name = "Btn_AddTournament";
			Btn_AddTournament.Size = new Size(95, 23);
			Btn_AddTournament.TabIndex = 33;
			Btn_AddTournament.Text = "Add";
			Btn_AddTournament.UseVisualStyleBackColor = true;
			Btn_AddTournament.Click += Btn_AddTournament_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(209, 483);
			label13.Name = "label13";
			label13.Size = new Size(39, 15);
			label13.TabIndex = 31;
			label13.Text = "Venue";
			// 
			// DTPicker_TournamentStartDate
			// 
			DTPicker_TournamentStartDate.Location = new Point(5, 546);
			DTPicker_TournamentStartDate.Name = "DTPicker_TournamentStartDate";
			DTPicker_TournamentStartDate.Size = new Size(198, 23);
			DTPicker_TournamentStartDate.TabIndex = 30;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(3, 528);
			label14.Name = "label14";
			label14.Size = new Size(91, 15);
			label14.TabIndex = 29;
			label14.Text = "Date of the start";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(3, 483);
			label15.Name = "label15";
			label15.Size = new Size(39, 15);
			label15.TabIndex = 28;
			label15.Text = "Name";
			// 
			// TextBox_TournamentName
			// 
			TextBox_TournamentName.Location = new Point(3, 501);
			TextBox_TournamentName.Name = "TextBox_TournamentName";
			TextBox_TournamentName.Size = new Size(200, 23);
			TextBox_TournamentName.TabIndex = 27;
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new Point(599, 262);
			label16.Name = "label16";
			label16.Size = new Size(154, 15);
			label16.TabIndex = 26;
			label16.Text = "Tournament's Competitions";
			// 
			// label17
			// 
			label17.AutoSize = true;
			label17.Location = new Point(599, 15);
			label17.Name = "label17";
			label17.Size = new Size(144, 15);
			label17.TabIndex = 25;
			label17.Text = "Tournament's Participants";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new Point(6, 15);
			label18.Name = "label18";
			label18.Size = new Size(76, 15);
			label18.TabIndex = 24;
			label18.Text = "Tournaments";
			// 
			// Dgv_TournamentsCompetitions
			// 
			Dgv_TournamentsCompetitions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_TournamentsCompetitions.Columns.AddRange(new DataGridViewColumn[] { Col_TournamentCompetitionsId, Col_TournamentCompetitionsPlayer1, Col_TournamentCompetitionsPlayer2, Col_TournamentCompetitionsTimeStart, Col_TournamentCompetitionsTimeEnd, Col_TournamentCompetitionsChampionName, Col_TournamentCompetitionsChampionSurname });
			Dgv_TournamentsCompetitions.Location = new Point(599, 280);
			Dgv_TournamentsCompetitions.Name = "Dgv_TournamentsCompetitions";
			Dgv_TournamentsCompetitions.RowTemplate.Height = 25;
			Dgv_TournamentsCompetitions.Size = new Size(561, 344);
			Dgv_TournamentsCompetitions.TabIndex = 23;
			// 
			// Col_TournamentCompetitionsId
			// 
			Col_TournamentCompetitionsId.HeaderText = "Competition ID";
			Col_TournamentCompetitionsId.Name = "Col_TournamentCompetitionsId";
			Col_TournamentCompetitionsId.Width = 80;
			// 
			// Col_TournamentCompetitionsPlayer1
			// 
			Col_TournamentCompetitionsPlayer1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsPlayer1.HeaderText = "Player 1";
			Col_TournamentCompetitionsPlayer1.Name = "Col_TournamentCompetitionsPlayer1";
			// 
			// Col_TournamentCompetitionsPlayer2
			// 
			Col_TournamentCompetitionsPlayer2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsPlayer2.HeaderText = "Player 2";
			Col_TournamentCompetitionsPlayer2.Name = "Col_TournamentCompetitionsPlayer2";
			// 
			// Col_TournamentCompetitionsTimeStart
			// 
			Col_TournamentCompetitionsTimeStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsTimeStart.HeaderText = "Time start";
			Col_TournamentCompetitionsTimeStart.Name = "Col_TournamentCompetitionsTimeStart";
			// 
			// Col_TournamentCompetitionsTimeEnd
			// 
			Col_TournamentCompetitionsTimeEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsTimeEnd.HeaderText = "Time end";
			Col_TournamentCompetitionsTimeEnd.Name = "Col_TournamentCompetitionsTimeEnd";
			// 
			// Col_TournamentCompetitionsChampionName
			// 
			Col_TournamentCompetitionsChampionName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsChampionName.HeaderText = "Champion name";
			Col_TournamentCompetitionsChampionName.Name = "Col_TournamentCompetitionsChampionName";
			// 
			// Col_TournamentCompetitionsChampionSurname
			// 
			Col_TournamentCompetitionsChampionSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentCompetitionsChampionSurname.HeaderText = "Champion surname";
			Col_TournamentCompetitionsChampionSurname.Name = "Col_TournamentCompetitionsChampionSurname";
			// 
			// Dgv_TournamentsParticipants
			// 
			Dgv_TournamentsParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_TournamentsParticipants.Columns.AddRange(new DataGridViewColumn[] { Col_TournamentParticipantsName, Col_TournamentParticipantsSurname, Col_TournamentParticipantsDateBirth, Col_TournamentParticipantsRating });
			Dgv_TournamentsParticipants.Location = new Point(599, 33);
			Dgv_TournamentsParticipants.Name = "Dgv_TournamentsParticipants";
			Dgv_TournamentsParticipants.RowTemplate.Height = 25;
			Dgv_TournamentsParticipants.Size = new Size(561, 226);
			Dgv_TournamentsParticipants.TabIndex = 22;
			// 
			// Col_TournamentParticipantsName
			// 
			Col_TournamentParticipantsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentParticipantsName.DataPropertyName = "Name";
			Col_TournamentParticipantsName.HeaderText = "Name";
			Col_TournamentParticipantsName.Name = "Col_TournamentParticipantsName";
			// 
			// Col_TournamentParticipantsSurname
			// 
			Col_TournamentParticipantsSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentParticipantsSurname.DataPropertyName = "Surname";
			Col_TournamentParticipantsSurname.HeaderText = "Surname";
			Col_TournamentParticipantsSurname.Name = "Col_TournamentParticipantsSurname";
			// 
			// Col_TournamentParticipantsDateBirth
			// 
			Col_TournamentParticipantsDateBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentParticipantsDateBirth.DataPropertyName = "DateOfBirth";
			Col_TournamentParticipantsDateBirth.HeaderText = "Birthdate";
			Col_TournamentParticipantsDateBirth.Name = "Col_TournamentParticipantsDateBirth";
			// 
			// Col_TournamentParticipantsRating
			// 
			Col_TournamentParticipantsRating.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentParticipantsRating.DataPropertyName = "Rating";
			Col_TournamentParticipantsRating.HeaderText = "Rating";
			Col_TournamentParticipantsRating.Name = "Col_TournamentParticipantsRating";
			// 
			// Dgv_TournamentsEditing
			// 
			Dgv_TournamentsEditing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_TournamentsEditing.Columns.AddRange(new DataGridViewColumn[] { Col_TournamentsName, Col_TournamentsVenue, Col_TournamentsDateStart, Col_TournamentsDateEnd, Col_TournamentsChampion, Col_TournamentsChampionSurname });
			Dgv_TournamentsEditing.Location = new Point(3, 33);
			Dgv_TournamentsEditing.Name = "Dgv_TournamentsEditing";
			Dgv_TournamentsEditing.RowTemplate.Height = 25;
			Dgv_TournamentsEditing.Size = new Size(590, 447);
			Dgv_TournamentsEditing.TabIndex = 21;
			Dgv_TournamentsEditing.SelectionChanged += Dgv_TournamentsEditing_SelectionChanged;
			// 
			// Col_TournamentsName
			// 
			Col_TournamentsName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsName.DataPropertyName = "Name";
			Col_TournamentsName.HeaderText = "Name";
			Col_TournamentsName.Name = "Col_TournamentsName";
			// 
			// Col_TournamentsVenue
			// 
			Col_TournamentsVenue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsVenue.DataPropertyName = "Venue.Name";
			Col_TournamentsVenue.HeaderText = "Venue";
			Col_TournamentsVenue.Name = "Col_TournamentsVenue";
			// 
			// Col_TournamentsDateStart
			// 
			Col_TournamentsDateStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsDateStart.DataPropertyName = "DateOfStart";
			Col_TournamentsDateStart.HeaderText = "Date start";
			Col_TournamentsDateStart.Name = "Col_TournamentsDateStart";
			// 
			// Col_TournamentsDateEnd
			// 
			Col_TournamentsDateEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsDateEnd.DataPropertyName = "DateOfEnd";
			Col_TournamentsDateEnd.HeaderText = "Date end";
			Col_TournamentsDateEnd.Name = "Col_TournamentsDateEnd";
			// 
			// Col_TournamentsChampion
			// 
			Col_TournamentsChampion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsChampion.DataPropertyName = "Champion.Name";
			Col_TournamentsChampion.HeaderText = "Champion name";
			Col_TournamentsChampion.Name = "Col_TournamentsChampion";
			// 
			// Col_TournamentsChampionSurname
			// 
			Col_TournamentsChampionSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_TournamentsChampionSurname.DataPropertyName = "Champion.Surname";
			Col_TournamentsChampionSurname.HeaderText = "Champion surname";
			Col_TournamentsChampionSurname.Name = "Col_TournamentsChampionSurname";
			// 
			// TabPage_Competitions
			// 
			TabPage_Competitions.Controls.Add(CheckBox_CompetitionEnd);
			TabPage_Competitions.Controls.Add(label30);
			TabPage_Competitions.Controls.Add(Nud_EndMinute);
			TabPage_Competitions.Controls.Add(label31);
			TabPage_Competitions.Controls.Add(Nud_EndHour);
			TabPage_Competitions.Controls.Add(label32);
			TabPage_Competitions.Controls.Add(CheckBox_CompetitionStart);
			TabPage_Competitions.Controls.Add(label29);
			TabPage_Competitions.Controls.Add(Nud_StartMinute);
			TabPage_Competitions.Controls.Add(label28);
			TabPage_Competitions.Controls.Add(Nud_StartHour);
			TabPage_Competitions.Controls.Add(label26);
			TabPage_Competitions.Controls.Add(Btn_SaveChangesCompetition);
			TabPage_Competitions.Controls.Add(Btn_RemoveCompetition);
			TabPage_Competitions.Controls.Add(Btn_AddCompetition);
			TabPage_Competitions.Controls.Add(DTPicker_CompetitionDateMatch);
			TabPage_Competitions.Controls.Add(label27);
			TabPage_Competitions.Controls.Add(CheckBox_CompetitionWinner);
			TabPage_Competitions.Controls.Add(ComboBox_CompetitionWinner);
			TabPage_Competitions.Controls.Add(label25);
			TabPage_Competitions.Controls.Add(ComboBox_CompetitionPlayer2);
			TabPage_Competitions.Controls.Add(label24);
			TabPage_Competitions.Controls.Add(ComboBox_CompetitionPlayer1);
			TabPage_Competitions.Controls.Add(label23);
			TabPage_Competitions.Controls.Add(ComboBox_CompetitionTournament);
			TabPage_Competitions.Controls.Add(label22);
			TabPage_Competitions.Controls.Add(label10);
			TabPage_Competitions.Controls.Add(Dgv_CompetitionsEditing);
			TabPage_Competitions.Location = new Point(4, 24);
			TabPage_Competitions.Name = "TabPage_Competitions";
			TabPage_Competitions.Size = new Size(1163, 632);
			TabPage_Competitions.TabIndex = 3;
			TabPage_Competitions.Text = "Competitions";
			TabPage_Competitions.UseVisualStyleBackColor = true;
			// 
			// CheckBox_CompetitionEnd
			// 
			CheckBox_CompetitionEnd.AutoSize = true;
			CheckBox_CompetitionEnd.Checked = true;
			CheckBox_CompetitionEnd.CheckState = CheckState.Checked;
			CheckBox_CompetitionEnd.Location = new Point(416, 531);
			CheckBox_CompetitionEnd.Name = "CheckBox_CompetitionEnd";
			CheckBox_CompetitionEnd.Size = new Size(15, 14);
			CheckBox_CompetitionEnd.TabIndex = 70;
			CheckBox_CompetitionEnd.UseVisualStyleBackColor = true;
			CheckBox_CompetitionEnd.CheckedChanged += CheckBox_CompetitionEnd_CheckedChanged;
			// 
			// label30
			// 
			label30.AutoSize = true;
			label30.Location = new Point(379, 530);
			label30.Name = "label30";
			label30.Size = new Size(27, 15);
			label30.TabIndex = 69;
			label30.Text = "End";
			// 
			// Nud_EndMinute
			// 
			Nud_EndMinute.Location = new Point(401, 566);
			Nud_EndMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
			Nud_EndMinute.Name = "Nud_EndMinute";
			Nud_EndMinute.Size = new Size(48, 23);
			Nud_EndMinute.TabIndex = 68;
			// 
			// label31
			// 
			label31.AutoSize = true;
			label31.Location = new Point(401, 548);
			label31.Name = "label31";
			label31.Size = new Size(45, 15);
			label31.TabIndex = 67;
			label31.Text = "Minute";
			// 
			// Nud_EndHour
			// 
			Nud_EndHour.Location = new Point(347, 566);
			Nud_EndHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
			Nud_EndHour.Name = "Nud_EndHour";
			Nud_EndHour.Size = new Size(48, 23);
			Nud_EndHour.TabIndex = 66;
			// 
			// label32
			// 
			label32.AutoSize = true;
			label32.Location = new Point(347, 548);
			label32.Name = "label32";
			label32.Size = new Size(34, 15);
			label32.TabIndex = 65;
			label32.Text = "Hour";
			// 
			// CheckBox_CompetitionStart
			// 
			CheckBox_CompetitionStart.AutoSize = true;
			CheckBox_CompetitionStart.Checked = true;
			CheckBox_CompetitionStart.CheckState = CheckState.Checked;
			CheckBox_CompetitionStart.Location = new Point(298, 531);
			CheckBox_CompetitionStart.Name = "CheckBox_CompetitionStart";
			CheckBox_CompetitionStart.Size = new Size(15, 14);
			CheckBox_CompetitionStart.TabIndex = 64;
			CheckBox_CompetitionStart.UseVisualStyleBackColor = true;
			CheckBox_CompetitionStart.CheckedChanged += CheckBox_CompetitionStart_CheckedChanged;
			// 
			// label29
			// 
			label29.AutoSize = true;
			label29.Location = new Point(261, 530);
			label29.Name = "label29";
			label29.Size = new Size(31, 15);
			label29.TabIndex = 63;
			label29.Text = "Start";
			// 
			// Nud_StartMinute
			// 
			Nud_StartMinute.Location = new Point(283, 566);
			Nud_StartMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
			Nud_StartMinute.Name = "Nud_StartMinute";
			Nud_StartMinute.Size = new Size(48, 23);
			Nud_StartMinute.TabIndex = 62;
			// 
			// label28
			// 
			label28.AutoSize = true;
			label28.Location = new Point(283, 548);
			label28.Name = "label28";
			label28.Size = new Size(45, 15);
			label28.TabIndex = 61;
			label28.Text = "Minute";
			// 
			// Nud_StartHour
			// 
			Nud_StartHour.Location = new Point(229, 566);
			Nud_StartHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
			Nud_StartHour.Name = "Nud_StartHour";
			Nud_StartHour.Size = new Size(48, 23);
			Nud_StartHour.TabIndex = 60;
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Location = new Point(229, 548);
			label26.Name = "label26";
			label26.Size = new Size(34, 15);
			label26.TabIndex = 59;
			label26.Text = "Hour";
			// 
			// Btn_SaveChangesCompetition
			// 
			Btn_SaveChangesCompetition.Location = new Point(106, 606);
			Btn_SaveChangesCompetition.Name = "Btn_SaveChangesCompetition";
			Btn_SaveChangesCompetition.Size = new Size(95, 23);
			Btn_SaveChangesCompetition.TabIndex = 58;
			Btn_SaveChangesCompetition.Text = "Save Changes";
			Btn_SaveChangesCompetition.UseVisualStyleBackColor = true;
			// 
			// Btn_RemoveCompetition
			// 
			Btn_RemoveCompetition.Location = new Point(207, 606);
			Btn_RemoveCompetition.Name = "Btn_RemoveCompetition";
			Btn_RemoveCompetition.Size = new Size(95, 23);
			Btn_RemoveCompetition.TabIndex = 57;
			Btn_RemoveCompetition.Text = "Remove";
			Btn_RemoveCompetition.UseVisualStyleBackColor = true;
			// 
			// Btn_AddCompetition
			// 
			Btn_AddCompetition.Location = new Point(3, 606);
			Btn_AddCompetition.Name = "Btn_AddCompetition";
			Btn_AddCompetition.Size = new Size(95, 23);
			Btn_AddCompetition.TabIndex = 56;
			Btn_AddCompetition.Text = "Add";
			Btn_AddCompetition.UseVisualStyleBackColor = true;
			// 
			// DTPicker_CompetitionDateMatch
			// 
			DTPicker_CompetitionDateMatch.Location = new Point(3, 565);
			DTPicker_CompetitionDateMatch.Name = "DTPicker_CompetitionDateMatch";
			DTPicker_CompetitionDateMatch.Size = new Size(198, 23);
			DTPicker_CompetitionDateMatch.TabIndex = 54;
			// 
			// label27
			// 
			label27.AutoSize = true;
			label27.Location = new Point(7, 547);
			label27.Name = "label27";
			label27.Size = new Size(102, 15);
			label27.TabIndex = 52;
			label27.Text = "Date of the match";
			// 
			// CheckBox_CompetitionWinner
			// 
			CheckBox_CompetitionWinner.AutoSize = true;
			CheckBox_CompetitionWinner.Checked = true;
			CheckBox_CompetitionWinner.CheckState = CheckState.Checked;
			CheckBox_CompetitionWinner.Location = new Point(686, 486);
			CheckBox_CompetitionWinner.Name = "CheckBox_CompetitionWinner";
			CheckBox_CompetitionWinner.Size = new Size(15, 14);
			CheckBox_CompetitionWinner.TabIndex = 51;
			CheckBox_CompetitionWinner.UseVisualStyleBackColor = true;
			CheckBox_CompetitionWinner.CheckedChanged += CheckBox_CompetitionWinner_CheckedChanged;
			// 
			// ComboBox_CompetitionWinner
			// 
			ComboBox_CompetitionWinner.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CompetitionWinner.FormattingEnabled = true;
			ComboBox_CompetitionWinner.Location = new Point(617, 503);
			ComboBox_CompetitionWinner.Name = "ComboBox_CompetitionWinner";
			ComboBox_CompetitionWinner.Size = new Size(189, 23);
			ComboBox_CompetitionWinner.TabIndex = 50;
			// 
			// label25
			// 
			label25.AutoSize = true;
			label25.Location = new Point(617, 485);
			label25.Name = "label25";
			label25.Size = new Size(45, 15);
			label25.TabIndex = 49;
			label25.Text = "Winner";
			// 
			// ComboBox_CompetitionPlayer2
			// 
			ComboBox_CompetitionPlayer2.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CompetitionPlayer2.FormattingEnabled = true;
			ComboBox_CompetitionPlayer2.Location = new Point(411, 503);
			ComboBox_CompetitionPlayer2.Name = "ComboBox_CompetitionPlayer2";
			ComboBox_CompetitionPlayer2.Size = new Size(189, 23);
			ComboBox_CompetitionPlayer2.TabIndex = 48;
			// 
			// label24
			// 
			label24.AutoSize = true;
			label24.Location = new Point(411, 485);
			label24.Name = "label24";
			label24.Size = new Size(48, 15);
			label24.TabIndex = 47;
			label24.Text = "Player 2";
			// 
			// ComboBox_CompetitionPlayer1
			// 
			ComboBox_CompetitionPlayer1.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CompetitionPlayer1.FormattingEnabled = true;
			ComboBox_CompetitionPlayer1.Location = new Point(207, 503);
			ComboBox_CompetitionPlayer1.Name = "ComboBox_CompetitionPlayer1";
			ComboBox_CompetitionPlayer1.Size = new Size(189, 23);
			ComboBox_CompetitionPlayer1.TabIndex = 46;
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new Point(207, 485);
			label23.Name = "label23";
			label23.Size = new Size(48, 15);
			label23.TabIndex = 45;
			label23.Text = "Player 1";
			// 
			// ComboBox_CompetitionTournament
			// 
			ComboBox_CompetitionTournament.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_CompetitionTournament.FormattingEnabled = true;
			ComboBox_CompetitionTournament.Location = new Point(3, 503);
			ComboBox_CompetitionTournament.Name = "ComboBox_CompetitionTournament";
			ComboBox_CompetitionTournament.Size = new Size(189, 23);
			ComboBox_CompetitionTournament.TabIndex = 44;
			ComboBox_CompetitionTournament.SelectionChangeCommitted += ComboBox_CompetitionTournament_SelectionChangeCommitted;
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new Point(3, 485);
			label22.Name = "label22";
			label22.Size = new Size(71, 15);
			label22.TabIndex = 43;
			label22.Text = "Tournament";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(3, 18);
			label10.Name = "label10";
			label10.Size = new Size(79, 15);
			label10.TabIndex = 25;
			label10.Text = "Competitions";
			// 
			// Dgv_CompetitionsEditing
			// 
			Dgv_CompetitionsEditing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			Dgv_CompetitionsEditing.Columns.AddRange(new DataGridViewColumn[] { Col_CompetitionsTournament, Col_CompetitionsPlayer1Name, Col_CompetitionsPlayer1Surname, Col_CompetitionsPlayer2Name, Col_CompetitionsPlayer2Surname, Col_CompetitionsTimeStart, Col_CompetitionsTimeEnd, Col_CompetitionsWinnerName, Col_CompetitionsWinnerSurname });
			Dgv_CompetitionsEditing.Location = new Point(3, 36);
			Dgv_CompetitionsEditing.Name = "Dgv_CompetitionsEditing";
			Dgv_CompetitionsEditing.RowTemplate.Height = 25;
			Dgv_CompetitionsEditing.Size = new Size(1157, 444);
			Dgv_CompetitionsEditing.TabIndex = 0;
			// 
			// Col_CompetitionsTournament
			// 
			Col_CompetitionsTournament.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsTournament.HeaderText = "Tournament";
			Col_CompetitionsTournament.Name = "Col_CompetitionsTournament";
			// 
			// Col_CompetitionsPlayer1Name
			// 
			Col_CompetitionsPlayer1Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsPlayer1Name.HeaderText = "Player 1 name";
			Col_CompetitionsPlayer1Name.Name = "Col_CompetitionsPlayer1Name";
			// 
			// Col_CompetitionsPlayer1Surname
			// 
			Col_CompetitionsPlayer1Surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsPlayer1Surname.HeaderText = "Player 1 surname";
			Col_CompetitionsPlayer1Surname.Name = "Col_CompetitionsPlayer1Surname";
			// 
			// Col_CompetitionsPlayer2Name
			// 
			Col_CompetitionsPlayer2Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsPlayer2Name.HeaderText = "Player 2 name";
			Col_CompetitionsPlayer2Name.Name = "Col_CompetitionsPlayer2Name";
			// 
			// Col_CompetitionsPlayer2Surname
			// 
			Col_CompetitionsPlayer2Surname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsPlayer2Surname.HeaderText = "Player 2 surname";
			Col_CompetitionsPlayer2Surname.Name = "Col_CompetitionsPlayer2Surname";
			// 
			// Col_CompetitionsTimeStart
			// 
			Col_CompetitionsTimeStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsTimeStart.HeaderText = "Time start";
			Col_CompetitionsTimeStart.Name = "Col_CompetitionsTimeStart";
			// 
			// Col_CompetitionsTimeEnd
			// 
			Col_CompetitionsTimeEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsTimeEnd.HeaderText = "Time end";
			Col_CompetitionsTimeEnd.Name = "Col_CompetitionsTimeEnd";
			// 
			// Col_CompetitionsWinnerName
			// 
			Col_CompetitionsWinnerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsWinnerName.HeaderText = "Winner name";
			Col_CompetitionsWinnerName.Name = "Col_CompetitionsWinnerName";
			// 
			// Col_CompetitionsWinnerSurname
			// 
			Col_CompetitionsWinnerSurname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			Col_CompetitionsWinnerSurname.HeaderText = "Winner surname";
			Col_CompetitionsWinnerSurname.Name = "Col_CompetitionsWinnerSurname";
			// 
			// TabPage_Queries
			// 
			TabPage_Queries.Controls.Add(dataGridView1);
			TabPage_Queries.Location = new Point(4, 24);
			TabPage_Queries.Name = "TabPage_Queries";
			TabPage_Queries.Padding = new Padding(3);
			TabPage_Queries.Size = new Size(1183, 672);
			TabPage_Queries.TabIndex = 1;
			TabPage_Queries.Text = "Queries";
			TabPage_Queries.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 6);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(561, 655);
			dataGridView1.TabIndex = 0;
			// 
			// ChessChampionship
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1215, 724);
			Controls.Add(TabControl_Main);
			Name = "ChessChampionship";
			Text = "Chess Championship";
			TabControl_Main.ResumeLayout(false);
			TabPage_Editing.ResumeLayout(false);
			TabControl_Editing.ResumeLayout(false);
			TabPage_Participants.ResumeLayout(false);
			TabPage_Participants.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantCompetitions).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantTournaments).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_ParticipantsEditing).EndInit();
			TabPage_Venues.ResumeLayout(false);
			TabPage_Venues.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_VenueTournaments).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_VenuesEditing).EndInit();
			TabPage_Tournaments.ResumeLayout(false);
			TabPage_Tournaments.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsCompetitions).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsParticipants).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_TournamentsEditing).EndInit();
			TabPage_Competitions.ResumeLayout(false);
			TabPage_Competitions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)Nud_EndMinute).EndInit();
			((System.ComponentModel.ISupportInitialize)Nud_EndHour).EndInit();
			((System.ComponentModel.ISupportInitialize)Nud_StartMinute).EndInit();
			((System.ComponentModel.ISupportInitialize)Nud_StartHour).EndInit();
			((System.ComponentModel.ISupportInitialize)Dgv_CompetitionsEditing).EndInit();
			TabPage_Queries.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabControl_Main;
		private TabPage TabPage_Editing;
		private TabControl TabControl_Editing;
		private TabPage TabPage_Participants;
		private TabPage TabPage_Venues;
		private TabPage TabPage_Tournaments;
		private TabPage TabPage_Competitions;
		private TabPage TabPage_Queries;
		private DataGridView dataGridView1;
		private Label label3;
		private Label label2;
		private Label label1;
		private DataGridView Dgv_ParticipantCompetitions;
		private DataGridView Dgv_ParticipantTournaments;
		private DataGridView Dgv_ParticipantsEditing;
		private TextBox TextBox_ParticipantRating;
		private Label label6;
		private DateTimePicker DTPicker_ParticipantBirthdate;
		private Label label5;
		private Label label4;
		private TextBox TextBox_ParticipantName;
		private Button Btn_SaveChangesParticipant;
		private Button Btn_RemoveParticipant;
		private Button Btn_AddParticipant;
		private Button Btn_SaveChangesTournament;
		private Button Btn_RemoveTournament;
		private Button Btn_AddTournament;
		private Label label13;
		private DateTimePicker DTPicker_TournamentStartDate;
		private Label label14;
		private Label label15;
		private TextBox TextBox_TournamentName;
		private Label label16;
		private Label label17;
		private Label label18;
		private DataGridView Dgv_TournamentsCompetitions;
		private DataGridView Dgv_TournamentsParticipants;
		private DataGridView Dgv_TournamentsEditing;
		private ComboBox ComboBox_TournamentChampion;
		private Label label19;
		private ComboBox ComboBox_TournamentVenue;
		private CheckBox CheckBox_TournamentChampion;
		private Label label20;
		private DateTimePicker DTPicker_TournamentEndDate;
		private Label label7;
		private TextBox TextBox_ParticipantSurname;
		private Label label12;
		private Label label21;
		private DataGridView Dgv_VenueTournaments;
		private DataGridView Dgv_VenuesEditing;
		private Label label8;
		private TextBox TextBox_VenueCountry;
		private Button Btn_SaveChangesVenue;
		private Button Btn_RemoveVenue;
		private Button Btn_AddVenue;
		private TextBox TextBox_VenueCity;
		private Label label9;
		private Label label11;
		private TextBox TextBox_VenueName;
		private Label label10;
		private DataGridView Dgv_CompetitionsEditing;
		private Button Btn_SaveChangesCompetition;
		private Button Btn_RemoveCompetition;
		private Button Btn_AddCompetition;
		private DateTimePicker DTPicker_CompetitionDateMatch;
		private Label label27;
		private CheckBox CheckBox_CompetitionWinner;
		private ComboBox ComboBox_CompetitionWinner;
		private Label label25;
		private ComboBox ComboBox_CompetitionPlayer2;
		private Label label24;
		private ComboBox ComboBox_CompetitionPlayer1;
		private Label label23;
		private ComboBox ComboBox_CompetitionTournament;
		private Label label22;
		private NumericUpDown Nud_StartMinute;
		private Label label28;
		private NumericUpDown Nud_StartHour;
		private Label label26;
		private CheckBox CheckBox_CompetitionEnd;
		private Label label30;
		private NumericUpDown Nud_EndMinute;
		private Label label31;
		private NumericUpDown Nud_EndHour;
		private Label label32;
		private CheckBox CheckBox_CompetitionStart;
		private Label label29;
		private CheckBox CheckBox_TournamentDateStart;
		private CheckBox CheckBox_TournamentDateEnd;
		private DataGridViewTextBoxColumn Col_ParticipantName;
		private DataGridViewTextBoxColumn Col_ParticipantSurname;
		private DataGridViewTextBoxColumn Col_ParticipantBirthdate;
		private DataGridViewTextBoxColumn Col_ParticipantRating;
		private DataGridViewTextBoxColumn Col_ParticipantCompetitionsTournament;
		private DataGridViewTextBoxColumn Col_ParticipantCompetitionsPlayer1;
		private DataGridViewTextBoxColumn Col_ParticipantCompetitionsPlayer2;
		private DataGridViewTextBoxColumn Col_ParticipantCompetitionsTimeStart;
		private DataGridViewTextBoxColumn Col_ParticipantCompetitionsTimeEnd;
		private DataGridViewTextBoxColumn Col_ParticipantTournamentsName;
		private DataGridViewTextBoxColumn Col_ParticipantTournamentsVenue;
		private DataGridViewTextBoxColumn Col_ParticipantTournamentsDateStart;
		private DataGridViewTextBoxColumn Col_ParticipantTournamentsDateEnd;
		private DataGridViewTextBoxColumn Col_VenuesName;
		private DataGridViewTextBoxColumn Col_VenuesCountry;
		private DataGridViewTextBoxColumn Col_VenuesCity;
		private DataGridViewTextBoxColumn Col_VenueTournamentsName;
		private DataGridViewTextBoxColumn Col_VenueTournamentsDateStart;
		private DataGridViewTextBoxColumn Col_VenueTournamentsDateEnd;
		private DataGridViewTextBoxColumn Col_VenueTournamentsChampion;
		private DataGridViewTextBoxColumn Col_TournamentsName;
		private DataGridViewTextBoxColumn Col_TournamentsVenue;
		private DataGridViewTextBoxColumn Col_TournamentsDateStart;
		private DataGridViewTextBoxColumn Col_TournamentsDateEnd;
		private DataGridViewTextBoxColumn Col_TournamentsChampion;
		private DataGridViewTextBoxColumn Col_TournamentsChampionSurname;
		private DataGridViewTextBoxColumn Col_TournamentParticipantsName;
		private DataGridViewTextBoxColumn Col_TournamentParticipantsSurname;
		private DataGridViewTextBoxColumn Col_TournamentParticipantsDateBirth;
		private DataGridViewTextBoxColumn Col_TournamentParticipantsRating;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsId;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsPlayer1;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsPlayer2;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsTimeStart;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsTimeEnd;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsChampionName;
		private DataGridViewTextBoxColumn Col_TournamentCompetitionsChampionSurname;
		private DataGridViewTextBoxColumn Col_CompetitionsTournament;
		private DataGridViewTextBoxColumn Col_CompetitionsPlayer1Name;
		private DataGridViewTextBoxColumn Col_CompetitionsPlayer1Surname;
		private DataGridViewTextBoxColumn Col_CompetitionsPlayer2Name;
		private DataGridViewTextBoxColumn Col_CompetitionsPlayer2Surname;
		private DataGridViewTextBoxColumn Col_CompetitionsTimeStart;
		private DataGridViewTextBoxColumn Col_CompetitionsTimeEnd;
		private DataGridViewTextBoxColumn Col_CompetitionsWinnerName;
		private DataGridViewTextBoxColumn Col_CompetitionsWinnerSurname;
	}
}