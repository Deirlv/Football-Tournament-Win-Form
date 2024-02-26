using FootballTournament.DAL;
using FootballTournament.DAL.Architecture;
using FootballTournament.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Football_Tournament;

namespace Football_Tournament
{
    public partial class CreationForm : Form
    {
        private Service _service;

        public CreationForm(Service service)
        {
            InitializeComponent();
            _service = service;
        }

        public CreationForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tabControlCreation.SelectedIndex == 0)
            {
                if (textBoxTeamName.Text.Length == 0 || textBoxTeamCity.Text.Length == 0)
                {
                    MessageBox.Show("Can not create team with empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure that you've entered all the fields correctly?", "Creating Team", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Team team = new Team()
                    {
                        Name = textBoxTeamName.Text,
                        City = textBoxTeamCity.Text,
                        Victories = Convert.ToInt32(numericUpDownVictories.Value),
                        Loses = Convert.ToInt32(numericUpDownLoses.Value),
                        Draws = Convert.ToInt32(numericUpDownDraws.Value),
                        Goals = Convert.ToInt32(numericUpDownGoals.Value),
                        GoalsMissed = Convert.ToInt32(numericUpDownGoalsMissed.Value)
                    };
                    bool is_unique = _service.AddUniqueTeam(team);
                    if (is_unique)
                    {
                        MessageBox.Show("Team was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdditionalHelp.FillTeamComboBox(comboBoxTeam, _service);
                        AdditionalHelp.FillTeamComboBox(comboBoxFirstTeam, _service);
                        AdditionalHelp.FillTeamComboBox(comboBoxSecondTeam, _service);
                    }
                    else
                    {
                        MessageBox.Show("There is already a team with such a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (tabControlCreation.SelectedIndex == 1)
            {
                if (textBoxFirstName.Text.Length == 0 || textBoxLastName.Text.Length == 0 || textBoxCountry.Text.Length == 0 || textBoxPosition.Text.Length == 0 || comboBoxTeam.Items.Count == 0)
                {
                    MessageBox.Show("Can not create player with empty fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure that you've entered all the fields correctly?", "Creating Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Team? team = _service.FindTeamName(Convert.ToString(comboBoxTeam.SelectedItem));
                    if (team != null)
                    {
                        Player player = new Player()
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            Country = textBoxCountry.Text,
                            JerseyNumber = Convert.ToInt32(numericUpDown4.Value),
                            Position = textBoxPosition.Text,
                            Team = team,
                            TeamId = team.Id
                        };
                        _service.Add(player);
                        MessageBox.Show("Player was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (tabControlCreation.SelectedIndex == 2)
            {
                if (comboBoxFirstTeam.SelectedIndex == comboBoxSecondTeam.SelectedIndex)
                {
                    MessageBox.Show("Can not create match with the same teams", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure that you've entered all the fields correctly?", "Creating Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Team? team1 = _service.FindTeamName(Convert.ToString(comboBoxFirstTeam.SelectedItem));
                    Team? team2 = _service.FindTeamName(Convert.ToString(comboBoxSecondTeam.SelectedItem));
                    if (team1 != null && team2 != null)
                    {
                        Match match = new Match()
                        {
                            Team1Id = team1.Id,
                            Team1 = team1,
                            Team2Id = team2.Id,
                            Team2 = team2,
                            Team1Goals = Convert.ToInt32(numericUpDown1Goals.Value),
                            Team2Goals = Convert.ToInt32(numericUpDown2Goals.Value),
                            Date = dateTimePickerMatch.Value,
                        };
                        _service.Add(match);
                        MessageBox.Show("Match was successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                e.Handled = true;
            }
        }

        private void CreationForm_Load(object sender, EventArgs e)
        {
            AdditionalHelp.FillTeamComboBox(comboBoxTeam, _service);
            AdditionalHelp.FillTeamComboBox(comboBoxFirstTeam, _service);
            AdditionalHelp.FillTeamComboBox(comboBoxSecondTeam, _service);
        }
    }
}
