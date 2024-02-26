namespace Football_Tournament
{
    partial class TournamentForm
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
            tabControlMain = new TabControl();
            tabTeams = new TabPage();
            comboBoxTeams = new ComboBox();
            dataGridViewTeams = new DataGridView();
            columnId = new DataGridViewTextBoxColumn();
            columnName = new DataGridViewTextBoxColumn();
            columnCity = new DataGridViewTextBoxColumn();
            columnVictories = new DataGridViewTextBoxColumn();
            columnLoses = new DataGridViewTextBoxColumn();
            columnDraws = new DataGridViewTextBoxColumn();
            columnGoals = new DataGridViewTextBoxColumn();
            columnGoalsMissed = new DataGridViewTextBoxColumn();
            tabPlayers = new TabPage();
            dataGridViewPlayers = new DataGridView();
            columnPlayerId = new DataGridViewTextBoxColumn();
            columnFirstName = new DataGridViewTextBoxColumn();
            columnLastName = new DataGridViewTextBoxColumn();
            columnCountry = new DataGridViewTextBoxColumn();
            columnJerseyNumber = new DataGridViewTextBoxColumn();
            columnPosition = new DataGridViewTextBoxColumn();
            columnTeam = new DataGridViewTextBoxColumn();
            comboBoxPlayers = new ComboBox();
            tabMatches = new TabPage();
            dataGridViewMatches = new DataGridView();
            columnMatchId = new DataGridViewTextBoxColumn();
            columnFirstTeam = new DataGridViewTextBoxColumn();
            columnSecondTeam = new DataGridViewTextBoxColumn();
            columnFirstTeamGoals = new DataGridViewTextBoxColumn();
            columnSecondTeamGoals = new DataGridViewTextBoxColumn();
            columnMatchDate = new DataGridViewTextBoxColumn();
            comboBoxMatches = new ComboBox();
            buttonAdd = new Button();
            menuStrip1 = new MenuStrip();
            commandsToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuFind = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            tabTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).BeginInit();
            tabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
            tabMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatches).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabTeams);
            tabControlMain.Controls.Add(tabPlayers);
            tabControlMain.Controls.Add(tabMatches);
            tabControlMain.Location = new Point(12, 26);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(866, 496);
            tabControlMain.TabIndex = 0;
            // 
            // tabTeams
            // 
            tabTeams.Controls.Add(comboBoxTeams);
            tabTeams.Controls.Add(dataGridViewTeams);
            tabTeams.Location = new Point(4, 24);
            tabTeams.Name = "tabTeams";
            tabTeams.Padding = new Padding(3);
            tabTeams.Size = new Size(858, 468);
            tabTeams.TabIndex = 0;
            tabTeams.Text = "Teams";
            tabTeams.UseVisualStyleBackColor = true;
            // 
            // comboBoxTeams
            // 
            comboBoxTeams.FormattingEnabled = true;
            comboBoxTeams.Items.AddRange(new object[] { "All", "The most victories", "The most loses", "The most draws", "The most goals", "The most goals missed", "Top 3 most points", "Top 1 most points", "Top 3 least points", "Top 1 least points" });
            comboBoxTeams.Location = new Point(6, 439);
            comboBoxTeams.Name = "comboBoxTeams";
            comboBoxTeams.Size = new Size(153, 23);
            comboBoxTeams.TabIndex = 1;
            comboBoxTeams.SelectedIndexChanged += comboBoxTeams_SelectedIndexChanged;
            // 
            // dataGridViewTeams
            // 
            dataGridViewTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeams.Columns.AddRange(new DataGridViewColumn[] { columnId, columnName, columnCity, columnVictories, columnLoses, columnDraws, columnGoals, columnGoalsMissed });
            dataGridViewTeams.Location = new Point(6, 6);
            dataGridViewTeams.MultiSelect = false;
            dataGridViewTeams.Name = "dataGridViewTeams";
            dataGridViewTeams.Size = new Size(847, 428);
            dataGridViewTeams.TabIndex = 0;
            dataGridViewTeams.TabStop = false;
            dataGridViewTeams.CellBeginEdit += dataGridViewTeams_CellBeginEdit;
            dataGridViewTeams.CellEndEdit += dataGridView_CellEndEdit;
            dataGridViewTeams.UserDeletingRow += dataGridView_UserDeletingRow;
            // 
            // columnId
            // 
            columnId.HeaderText = "Id";
            columnId.Name = "columnId";
            columnId.ReadOnly = true;
            // 
            // columnName
            // 
            columnName.HeaderText = "Name";
            columnName.Name = "columnName";
            // 
            // columnCity
            // 
            columnCity.HeaderText = "City";
            columnCity.Name = "columnCity";
            // 
            // columnVictories
            // 
            columnVictories.HeaderText = "Victories";
            columnVictories.Name = "columnVictories";
            // 
            // columnLoses
            // 
            columnLoses.HeaderText = "Loses";
            columnLoses.Name = "columnLoses";
            // 
            // columnDraws
            // 
            columnDraws.HeaderText = "Draws";
            columnDraws.Name = "columnDraws";
            // 
            // columnGoals
            // 
            columnGoals.HeaderText = "Goals";
            columnGoals.Name = "columnGoals";
            // 
            // columnGoalsMissed
            // 
            columnGoalsMissed.HeaderText = "Goals Missed";
            columnGoalsMissed.Name = "columnGoalsMissed";
            // 
            // tabPlayers
            // 
            tabPlayers.Controls.Add(dataGridViewPlayers);
            tabPlayers.Controls.Add(comboBoxPlayers);
            tabPlayers.Location = new Point(4, 24);
            tabPlayers.Name = "tabPlayers";
            tabPlayers.Size = new Size(858, 468);
            tabPlayers.TabIndex = 2;
            tabPlayers.Text = "Players";
            tabPlayers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Columns.AddRange(new DataGridViewColumn[] { columnPlayerId, columnFirstName, columnLastName, columnCountry, columnJerseyNumber, columnPosition, columnTeam });
            dataGridViewPlayers.Location = new Point(6, 6);
            dataGridViewPlayers.MultiSelect = false;
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.Size = new Size(847, 428);
            dataGridViewPlayers.TabIndex = 3;
            dataGridViewPlayers.TabStop = false;
            dataGridViewPlayers.CellEndEdit += dataGridViewPlayers_CellEndEdit;
            dataGridViewPlayers.UserDeletingRow += dataGridViewPlayers_UserDeletingRow;
            // 
            // columnPlayerId
            // 
            columnPlayerId.HeaderText = "Id";
            columnPlayerId.Name = "columnPlayerId";
            columnPlayerId.ReadOnly = true;
            // 
            // columnFirstName
            // 
            columnFirstName.HeaderText = "FirstName";
            columnFirstName.Name = "columnFirstName";
            // 
            // columnLastName
            // 
            columnLastName.HeaderText = "LastName";
            columnLastName.Name = "columnLastName";
            // 
            // columnCountry
            // 
            columnCountry.HeaderText = "Country";
            columnCountry.Name = "columnCountry";
            // 
            // columnJerseyNumber
            // 
            columnJerseyNumber.HeaderText = "Jersey";
            columnJerseyNumber.Name = "columnJerseyNumber";
            // 
            // columnPosition
            // 
            columnPosition.HeaderText = "Position";
            columnPosition.Name = "columnPosition";
            // 
            // columnTeam
            // 
            columnTeam.HeaderText = "Team";
            columnTeam.Name = "columnTeam";
            columnTeam.ReadOnly = true;
            // 
            // comboBoxPlayers
            // 
            comboBoxPlayers.FormattingEnabled = true;
            comboBoxPlayers.Items.AddRange(new object[] { "All" });
            comboBoxPlayers.Location = new Point(6, 439);
            comboBoxPlayers.Name = "comboBoxPlayers";
            comboBoxPlayers.Size = new Size(153, 23);
            comboBoxPlayers.TabIndex = 2;
            comboBoxPlayers.SelectedIndexChanged += comboBoxPlayers_SelectedIndexChanged;
            // 
            // tabMatches
            // 
            tabMatches.Controls.Add(dataGridViewMatches);
            tabMatches.Controls.Add(comboBoxMatches);
            tabMatches.Location = new Point(4, 24);
            tabMatches.Name = "tabMatches";
            tabMatches.Padding = new Padding(3);
            tabMatches.Size = new Size(858, 468);
            tabMatches.TabIndex = 1;
            tabMatches.Text = "Matches";
            tabMatches.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatches
            // 
            dataGridViewMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatches.Columns.AddRange(new DataGridViewColumn[] { columnMatchId, columnFirstTeam, columnSecondTeam, columnFirstTeamGoals, columnSecondTeamGoals, columnMatchDate });
            dataGridViewMatches.Location = new Point(6, 6);
            dataGridViewMatches.MultiSelect = false;
            dataGridViewMatches.Name = "dataGridViewMatches";
            dataGridViewMatches.Size = new Size(847, 428);
            dataGridViewMatches.TabIndex = 4;
            dataGridViewMatches.TabStop = false;
            dataGridViewMatches.CellEndEdit += dataGridViewMatches_CellEndEdit;
            dataGridViewMatches.UserDeletingRow += dataGridViewMatches_UserDeletingRow;
            // 
            // columnMatchId
            // 
            columnMatchId.HeaderText = "Id";
            columnMatchId.Name = "columnMatchId";
            columnMatchId.ReadOnly = true;
            // 
            // columnFirstTeam
            // 
            columnFirstTeam.HeaderText = "1. Team";
            columnFirstTeam.Name = "columnFirstTeam";
            columnFirstTeam.ReadOnly = true;
            // 
            // columnSecondTeam
            // 
            columnSecondTeam.HeaderText = "2. Team";
            columnSecondTeam.Name = "columnSecondTeam";
            columnSecondTeam.ReadOnly = true;
            // 
            // columnFirstTeamGoals
            // 
            columnFirstTeamGoals.HeaderText = "1.Team Goals";
            columnFirstTeamGoals.Name = "columnFirstTeamGoals";
            // 
            // columnSecondTeamGoals
            // 
            columnSecondTeamGoals.HeaderText = "2. Team Goals";
            columnSecondTeamGoals.Name = "columnSecondTeamGoals";
            // 
            // columnMatchDate
            // 
            columnMatchDate.HeaderText = "Date";
            columnMatchDate.Name = "columnMatchDate";
            // 
            // comboBoxMatches
            // 
            comboBoxMatches.FormattingEnabled = true;
            comboBoxMatches.Items.AddRange(new object[] { "All" });
            comboBoxMatches.Location = new Point(6, 439);
            comboBoxMatches.Name = "comboBoxMatches";
            comboBoxMatches.Size = new Size(153, 23);
            comboBoxMatches.TabIndex = 3;
            comboBoxMatches.SelectedIndexChanged += comboBoxMatches_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(20, 528);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(90, 23);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(878, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // commandsToolStripMenuItem
            // 
            commandsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuFind });
            commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            commandsToolStripMenuItem.Size = new Size(81, 20);
            commandsToolStripMenuItem.Text = "Commands";
            // 
            // findToolStripMenuFind
            // 
            findToolStripMenuFind.Name = "findToolStripMenuFind";
            findToolStripMenuFind.ShortcutKeys = Keys.Control | Keys.F;
            findToolStripMenuFind.Size = new Size(137, 22);
            findToolStripMenuFind.Text = "Find";
            findToolStripMenuFind.Click += findToolStripMenuFind_Click;
            // 
            // TournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 559);
            Controls.Add(buttonAdd);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TournamentForm";
            Text = "Football Tournament";
            Load += TournamentForm_Load;
            tabControlMain.ResumeLayout(false);
            tabTeams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeams).EndInit();
            tabPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            tabMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatches).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabTeams;
        private TabPage tabMatches;
        private TabPage tabPlayers;
        private DataGridView dataGridViewTeams;
        private ComboBox comboBoxTeams;
        private ComboBox comboBoxPlayers;
        private ComboBox comboBoxMatches;
        private Button buttonAdd;
        private DataGridViewTextBoxColumn columnId;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn columnCity;
        private DataGridViewTextBoxColumn columnVictories;
        private DataGridViewTextBoxColumn columnLoses;
        private DataGridViewTextBoxColumn columnDraws;
        private DataGridViewTextBoxColumn columnGoals;
        private DataGridViewTextBoxColumn columnGoalsMissed;
        private DataGridView dataGridViewPlayers;
        private DataGridView dataGridViewMatches;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem commandsToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuFind;
        private DataGridViewTextBoxColumn columnPlayerId;
        private DataGridViewTextBoxColumn columnFirstName;
        private DataGridViewTextBoxColumn columnLastName;
        private DataGridViewTextBoxColumn columnCountry;
        private DataGridViewTextBoxColumn columnJerseyNumber;
        private DataGridViewTextBoxColumn columnPosition;
        private DataGridViewTextBoxColumn columnTeam;
        private DataGridViewTextBoxColumn columnMatchId;
        private DataGridViewTextBoxColumn columnFirstTeam;
        private DataGridViewTextBoxColumn columnSecondTeam;
        private DataGridViewTextBoxColumn columnFirstTeamGoals;
        private DataGridViewTextBoxColumn columnSecondTeamGoals;
        private DataGridViewTextBoxColumn columnMatchDate;
    }
}
