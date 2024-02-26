namespace Football_Tournament
{
    partial class CreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlCreation = new TabControl();
            tabPageAddTeam = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numericUpDownGoals = new NumericUpDown();
            numericUpDownDraws = new NumericUpDown();
            numericUpDownGoalsMissed = new NumericUpDown();
            numericUpDownLoses = new NumericUpDown();
            numericUpDownVictories = new NumericUpDown();
            label1 = new Label();
            textBoxTeamCity = new TextBox();
            textBoxTeamName = new TextBox();
            tabPageAddPlayer = new TabPage();
            textBoxLastName = new TextBox();
            comboBoxTeam = new ComboBox();
            textBoxPosition = new TextBox();
            textBoxCountry = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            numericUpDown4 = new NumericUpDown();
            label14 = new Label();
            textBoxFirstName = new TextBox();
            tabPageAddMatch = new TabPage();
            comboBoxSecondTeam = new ComboBox();
            comboBoxFirstTeam = new ComboBox();
            dateTimePickerMatch = new DateTimePicker();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            numericUpDown2Goals = new NumericUpDown();
            numericUpDown1Goals = new NumericUpDown();
            label21 = new Label();
            buttonAdd = new Button();
            tabControlCreation.SuspendLayout();
            tabPageAddTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDraws).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoalsMissed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLoses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVictories).BeginInit();
            tabPageAddPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            tabPageAddMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Goals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Goals).BeginInit();
            SuspendLayout();
            // 
            // tabControlCreation
            // 
            tabControlCreation.Controls.Add(tabPageAddTeam);
            tabControlCreation.Controls.Add(tabPageAddPlayer);
            tabControlCreation.Controls.Add(tabPageAddMatch);
            tabControlCreation.Location = new Point(12, 11);
            tabControlCreation.Name = "tabControlCreation";
            tabControlCreation.SelectedIndex = 0;
            tabControlCreation.Size = new Size(879, 452);
            tabControlCreation.TabIndex = 0;
            // 
            // tabPageAddTeam
            // 
            tabPageAddTeam.Controls.Add(label7);
            tabPageAddTeam.Controls.Add(label6);
            tabPageAddTeam.Controls.Add(label5);
            tabPageAddTeam.Controls.Add(label4);
            tabPageAddTeam.Controls.Add(label3);
            tabPageAddTeam.Controls.Add(label2);
            tabPageAddTeam.Controls.Add(numericUpDownGoals);
            tabPageAddTeam.Controls.Add(numericUpDownDraws);
            tabPageAddTeam.Controls.Add(numericUpDownGoalsMissed);
            tabPageAddTeam.Controls.Add(numericUpDownLoses);
            tabPageAddTeam.Controls.Add(numericUpDownVictories);
            tabPageAddTeam.Controls.Add(label1);
            tabPageAddTeam.Controls.Add(textBoxTeamCity);
            tabPageAddTeam.Controls.Add(textBoxTeamName);
            tabPageAddTeam.Location = new Point(4, 24);
            tabPageAddTeam.Name = "tabPageAddTeam";
            tabPageAddTeam.Padding = new Padding(3);
            tabPageAddTeam.Size = new Size(871, 424);
            tabPageAddTeam.TabIndex = 0;
            tabPageAddTeam.Text = "Team";
            tabPageAddTeam.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 346);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 17;
            label7.Text = "Goals Missed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 292);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "Goals";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 238);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Draws";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 182);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Loses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 131);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 13;
            label3.Text = "Victories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 12;
            label2.Text = "Team's city";
            // 
            // numericUpDownGoals
            // 
            numericUpDownGoals.Location = new Point(338, 312);
            numericUpDownGoals.Name = "numericUpDownGoals";
            numericUpDownGoals.Size = new Size(193, 23);
            numericUpDownGoals.TabIndex = 11;
            numericUpDownGoals.KeyPress += numericUpDown_KeyPress;
            // 
            // numericUpDownDraws
            // 
            numericUpDownDraws.Location = new Point(338, 259);
            numericUpDownDraws.Name = "numericUpDownDraws";
            numericUpDownDraws.Size = new Size(193, 23);
            numericUpDownDraws.TabIndex = 10;
            numericUpDownDraws.KeyPress += numericUpDown_KeyPress;
            // 
            // numericUpDownGoalsMissed
            // 
            numericUpDownGoalsMissed.Location = new Point(338, 366);
            numericUpDownGoalsMissed.Name = "numericUpDownGoalsMissed";
            numericUpDownGoalsMissed.Size = new Size(193, 23);
            numericUpDownGoalsMissed.TabIndex = 10;
            numericUpDownGoalsMissed.KeyPress += numericUpDown_KeyPress;
            // 
            // numericUpDownLoses
            // 
            numericUpDownLoses.Location = new Point(338, 203);
            numericUpDownLoses.Name = "numericUpDownLoses";
            numericUpDownLoses.Size = new Size(193, 23);
            numericUpDownLoses.TabIndex = 9;
            numericUpDownLoses.KeyPress += numericUpDown_KeyPress;
            // 
            // numericUpDownVictories
            // 
            numericUpDownVictories.Location = new Point(338, 151);
            numericUpDownVictories.Name = "numericUpDownVictories";
            numericUpDownVictories.Size = new Size(193, 23);
            numericUpDownVictories.TabIndex = 8;
            numericUpDownVictories.KeyPress += numericUpDown_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Team's name";
            // 
            // textBoxTeamCity
            // 
            textBoxTeamCity.Location = new Point(338, 99);
            textBoxTeamCity.Name = "textBoxTeamCity";
            textBoxTeamCity.Size = new Size(193, 23);
            textBoxTeamCity.TabIndex = 1;
            // 
            // textBoxTeamName
            // 
            textBoxTeamName.Location = new Point(338, 40);
            textBoxTeamName.Name = "textBoxTeamName";
            textBoxTeamName.Size = new Size(193, 23);
            textBoxTeamName.TabIndex = 0;
            // 
            // tabPageAddPlayer
            // 
            tabPageAddPlayer.Controls.Add(textBoxLastName);
            tabPageAddPlayer.Controls.Add(comboBoxTeam);
            tabPageAddPlayer.Controls.Add(textBoxPosition);
            tabPageAddPlayer.Controls.Add(textBoxCountry);
            tabPageAddPlayer.Controls.Add(label9);
            tabPageAddPlayer.Controls.Add(label10);
            tabPageAddPlayer.Controls.Add(label11);
            tabPageAddPlayer.Controls.Add(label12);
            tabPageAddPlayer.Controls.Add(label13);
            tabPageAddPlayer.Controls.Add(numericUpDown4);
            tabPageAddPlayer.Controls.Add(label14);
            tabPageAddPlayer.Controls.Add(textBoxFirstName);
            tabPageAddPlayer.Location = new Point(4, 24);
            tabPageAddPlayer.Name = "tabPageAddPlayer";
            tabPageAddPlayer.Padding = new Padding(3);
            tabPageAddPlayer.Size = new Size(871, 424);
            tabPageAddPlayer.TabIndex = 1;
            tabPageAddPlayer.Text = "Player";
            tabPageAddPlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(339, 122);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(193, 23);
            textBoxLastName.TabIndex = 37;
            // 
            // comboBoxTeam
            // 
            comboBoxTeam.FormattingEnabled = true;
            comboBoxTeam.Location = new Point(339, 338);
            comboBoxTeam.Name = "comboBoxTeam";
            comboBoxTeam.Size = new Size(193, 23);
            comboBoxTeam.TabIndex = 36;
            // 
            // textBoxPosition
            // 
            textBoxPosition.Location = new Point(339, 279);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(193, 23);
            textBoxPosition.TabIndex = 35;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(339, 176);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(193, 23);
            textBoxCountry.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(415, 317);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 31;
            label9.Text = "Team";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(411, 260);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 30;
            label10.Text = "Position";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(395, 205);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 29;
            label11.Text = "Jersey number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 154);
            label12.Name = "label12";
            label12.Size = new Size(50, 15);
            label12.TabIndex = 28;
            label12.Text = "Country";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(404, 100);
            label13.Name = "label13";
            label13.Size = new Size(61, 15);
            label13.TabIndex = 27;
            label13.Text = "Last name";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(339, 225);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(193, 23);
            numericUpDown4.TabIndex = 23;
            numericUpDown4.KeyPress += numericUpDown_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(404, 41);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 21;
            label14.Text = "First name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(339, 62);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(193, 23);
            textBoxFirstName.TabIndex = 19;
            // 
            // tabPageAddMatch
            // 
            tabPageAddMatch.Controls.Add(comboBoxSecondTeam);
            tabPageAddMatch.Controls.Add(comboBoxFirstTeam);
            tabPageAddMatch.Controls.Add(dateTimePickerMatch);
            tabPageAddMatch.Controls.Add(label17);
            tabPageAddMatch.Controls.Add(label18);
            tabPageAddMatch.Controls.Add(label19);
            tabPageAddMatch.Controls.Add(label20);
            tabPageAddMatch.Controls.Add(numericUpDown2Goals);
            tabPageAddMatch.Controls.Add(numericUpDown1Goals);
            tabPageAddMatch.Controls.Add(label21);
            tabPageAddMatch.Location = new Point(4, 24);
            tabPageAddMatch.Name = "tabPageAddMatch";
            tabPageAddMatch.Padding = new Padding(3);
            tabPageAddMatch.Size = new Size(871, 424);
            tabPageAddMatch.TabIndex = 2;
            tabPageAddMatch.Text = "Match";
            tabPageAddMatch.UseVisualStyleBackColor = true;
            // 
            // comboBoxSecondTeam
            // 
            comboBoxSecondTeam.FormattingEnabled = true;
            comboBoxSecondTeam.Location = new Point(341, 147);
            comboBoxSecondTeam.Name = "comboBoxSecondTeam";
            comboBoxSecondTeam.Size = new Size(193, 23);
            comboBoxSecondTeam.TabIndex = 38;
            // 
            // comboBoxFirstTeam
            // 
            comboBoxFirstTeam.FormattingEnabled = true;
            comboBoxFirstTeam.Location = new Point(341, 87);
            comboBoxFirstTeam.Name = "comboBoxFirstTeam";
            comboBoxFirstTeam.Size = new Size(193, 23);
            comboBoxFirstTeam.TabIndex = 37;
            // 
            // dateTimePickerMatch
            // 
            dateTimePickerMatch.Location = new Point(341, 302);
            dateTimePickerMatch.Name = "dateTimePickerMatch";
            dateTimePickerMatch.Size = new Size(193, 23);
            dateTimePickerMatch.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(419, 280);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 29;
            label17.Text = "Date";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(380, 229);
            label18.Name = "label18";
            label18.Size = new Size(115, 15);
            label18.TabIndex = 28;
            label18.Text = "Second team's goals";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(388, 178);
            label19.Name = "label19";
            label19.Size = new Size(98, 15);
            label19.TabIndex = 27;
            label19.Text = "First team's goals";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(399, 124);
            label20.Name = "label20";
            label20.Size = new Size(76, 15);
            label20.TabIndex = 26;
            label20.Text = "Second team";
            // 
            // numericUpDown2Goals
            // 
            numericUpDown2Goals.Location = new Point(341, 251);
            numericUpDown2Goals.Name = "numericUpDown2Goals";
            numericUpDown2Goals.Size = new Size(193, 23);
            numericUpDown2Goals.TabIndex = 22;
            numericUpDown2Goals.KeyPress += numericUpDown_KeyPress;
            // 
            // numericUpDown1Goals
            // 
            numericUpDown1Goals.Location = new Point(341, 199);
            numericUpDown1Goals.Name = "numericUpDown1Goals";
            numericUpDown1Goals.Size = new Size(193, 23);
            numericUpDown1Goals.TabIndex = 21;
            numericUpDown1Goals.KeyPress += numericUpDown_KeyPress;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(405, 65);
            label21.Name = "label21";
            label21.Size = new Size(59, 15);
            label21.TabIndex = 20;
            label21.Text = "First team";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(411, 467);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(83, 23);
            buttonAdd.TabIndex = 19;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // CreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 496);
            Controls.Add(buttonAdd);
            Controls.Add(tabControlCreation);
            Name = "CreationForm";
            Text = "Creation Form";
            Load += CreationForm_Load;
            tabControlCreation.ResumeLayout(false);
            tabPageAddTeam.ResumeLayout(false);
            tabPageAddTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDraws).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGoalsMissed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLoses).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVictories).EndInit();
            tabPageAddPlayer.ResumeLayout(false);
            tabPageAddPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            tabPageAddMatch.ResumeLayout(false);
            tabPageAddMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2Goals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1Goals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlCreation;
        private TabPage tabPageAddTeam;
        private TabPage tabPageAddPlayer;
        private TabPage tabPageAddMatch;
        private TextBox textBoxTeamCity;
        private TextBox textBoxTeamName;
        private Label label2;
        private NumericUpDown numericUpDownGoals;
        private NumericUpDown numericUpDownDraws;
        private NumericUpDown numericUpDownGoalsMissed;
        private NumericUpDown numericUpDownLoses;
        private NumericUpDown numericUpDownVictories;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private Label label14;
        private TextBox textBox1;
        private TextBox textBoxFirstName;
        private ComboBox comboBoxTeam;
        private TextBox textBoxPosition;
        private TextBox textBoxCountry;
        private TextBox textBoxLastName;
        private Button buttonAdd;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private NumericUpDown numericUpDown2Goals;
        private NumericUpDown numericUpDown1Goals;
        private Label label21;
        private DateTimePicker dateTimePickerMatch;
        private ComboBox comboBoxSecondTeam;
        private ComboBox comboBoxFirstTeam;
    }
}