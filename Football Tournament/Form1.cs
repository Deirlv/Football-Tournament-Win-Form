using FootballTournament.DAL;
using FootballTournament.DAL.Architecture;
using FootballTournament.DAL.Entities;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Football_Tournament
{
    public partial class TournamentForm : Form
    {
        public Service _service;
        private object oldCellValue;
        public TournamentForm(TournamentContext context)
        {
            InitializeComponent();
            _service = new Service(context);
        }
        public TournamentForm()
        {
            InitializeComponent();
        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            dataGridViewTeams.AllowUserToAddRows = false;
            dataGridViewPlayers.AllowUserToAddRows = false;
            dataGridViewMatches.AllowUserToAddRows = false;
        }

        private void comboBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewTeams.Rows.Clear();
            dataGridViewTeams.Columns[0].ReadOnly = true;

            List<Team>? teams = new List<Team>();

            if (comboBoxTeams.SelectedIndex == 0)
            {
                teams = _service.GetAllTeams();
            }
            else if (comboBoxTeams.SelectedIndex == 1)
            {
                teams.Add(_service.GetTeamMostVictories());
            }
            else if (comboBoxTeams.SelectedIndex == 2)
            {
                teams.Add(_service.GetTeamMostLoses());
            }
            else if (comboBoxTeams.SelectedIndex == 3)
            {
                teams.Add(_service.GetTeamMostDrawGames());
            }
            else if (comboBoxTeams.SelectedIndex == 4)
            {
                teams.Add(_service.GetTeamMostGoalsScored());
            }
            else if (comboBoxTeams.SelectedIndex == 5)
            {
                teams.Add(_service.GetTeamMostGoalsMissed());
            }
            else if (comboBoxTeams.SelectedIndex == 6)
            {
                teams = _service.GetTeamsTop3MostPoints();
            }
            else if (comboBoxTeams.SelectedIndex == 7)
            {
                teams.Add(_service.GetTeamMostPoints());
            }
            else if (comboBoxTeams.SelectedIndex == 8)
            {
                teams = _service.GetTeamsTop3LeastPoints();
            }
            else if (comboBoxTeams.SelectedIndex == 9)
            {
                teams.Add(_service.GetTeamLeastPoints());
            }
            else if (comboBoxTeams.SelectedIndex == 10)
            {
                teams.Add(_service.GetTeamMostVictories());
            }

            if (teams != null)
            {
                foreach (var t in teams)
                {
                    dataGridViewTeams.Rows.Add(
                        t.Id,
                        t.Name,
                        t.City,
                        t.Victories,
                        t.Loses,
                        t.Draws,
                        t.Goals,
                        t.GoalsMissed
                    );
                }
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewTeams.Rows[e.RowIndex];
            int teamId = Convert.ToInt32(row.Cells["columnId"].Value);
            string columnName = dataGridViewTeams.Columns[e.ColumnIndex].Name;

            string updatedValue = Convert.ToString(row.Cells[e.ColumnIndex].Value);
            Team team = _service.GetTeamById(teamId);
            if (team != null)
            {
                switch (columnName)
                {
                    case "columnName":
                        foreach (var t in _service.GetAllTeams())
                        {
                            if (t.Name == updatedValue)
                            {
                                MessageBox.Show("This name for team already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                row.Cells[e.ColumnIndex].Value = Convert.ToString(oldCellValue);
                                return;
                            }
                        }
                        team.Name = updatedValue;
                        break;
                    case "columnCity":
                        team.City = updatedValue;
                        break;
                    case "columnVictories":
                        team.Victories = int.Parse(updatedValue);
                        break;
                    case "columnLoses":
                        team.Loses = int.Parse(updatedValue);
                        break;
                    case "columnDraws":
                        team.Draws = int.Parse(updatedValue);
                        break;
                    case "columnGoals":
                        team.Goals = int.Parse(updatedValue);
                        break;
                    case "columnGoalsMissed":
                        team.GoalsMissed = int.Parse(updatedValue);
                        break;
                    default:
                        break;
                }

                _service.Update(team);
            }
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this team? All associated matches and players will also be deleted", "Deleting Team", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewTeams.Rows[e.Row.Index];
                int teamId = Convert.ToInt32(row.Cells["columnId"].Value);
                Team? team = _service.GetTeamById(teamId);
                if (team != null)
                {
                    List<Match>? matches = _service.GetMatchesByTeam(teamId);
                    List<Player>? players = _service.GetPlayersByTeam(teamId);
                    if (matches != null)
                    {
                        foreach (Match match in matches)
                        {
                            _service.Remove(match);
                        }
                    }
                    if (players != null)
                    {
                        foreach (Player player in players)
                        {
                            _service.Remove(player);
                        }
                    }
                    _service.Remove(team);
                    dataGridViewTeams.Rows.RemoveAt(e.Row.Index);
                }
                else
                {
                    MessageBox.Show("Error while deleting team", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            e.Cancel = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreationForm creationForm = new CreationForm(_service);
            creationForm.ShowDialog();

        }

        private void dataGridViewTeams_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldCellValue = dataGridViewTeams.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void comboBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewPlayers.Rows.Clear();
            dataGridViewPlayers.Columns[0].ReadOnly = true;

            List<Player>? players = new List<Player>();

            if (comboBoxPlayers.SelectedIndex == 0)
            {
                players = _service.GetAllPlayers();
            }

            if (players != null)
            {
                foreach (var p in players)
                {
                    Team? team = _service.GetTeamById(p.TeamId);
                    dataGridViewPlayers.Rows.Add(
                        p.Id,
                        p.FirstName,
                        p.LastName,
                        p.Country,
                        p.JerseyNumber,
                        p.Position,
                        team.Name
                    );
                }
            }
        }

        private void comboBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewMatches.Rows.Clear();
            dataGridViewMatches.Columns[0].ReadOnly = true;

            List<Match>? matches = new List<Match>();

            if (comboBoxMatches.SelectedIndex == 0)
            {
                matches = _service.GetAllMatches();
            }

            if (matches != null)
            {
                foreach (var m in matches)
                {
                    Team? team1 = _service.GetTeamById(m.Team1Id);
                    Team? team2 = _service.GetTeamById(m.Team2Id);
                    dataGridViewMatches.Rows.Add(
                        m.Id,
                        team1.Name,
                        team2.Name,
                        m.Team1Goals,
                        m.Team2Goals,
                        m.Date
                    );
                }
            }
        }

        private void dataGridViewPlayers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewPlayers.Rows[e.RowIndex];
            int playerId = Convert.ToInt32(row.Cells["columnPlayerId"].Value);
            string columnName = dataGridViewPlayers.Columns[e.ColumnIndex].Name;

            string updatedValue = Convert.ToString(row.Cells[e.ColumnIndex].Value);
            Player? player = _service.GetPlayerById(playerId);
            if (player != null)
            {
                switch (columnName)
                {
                    case "columnFirstName":
                        player.FirstName = updatedValue;
                        break;
                    case "columnLastName":
                        player.LastName = updatedValue;
                        break;
                    case "columnCountry":
                        player.Country = updatedValue;
                        break;
                    case "columnJerseyNumber":
                        player.JerseyNumber = int.Parse(updatedValue);
                        break;
                    case "columnPosition":
                        player.Position = updatedValue;
                        break;
                    default:
                        break;
                }

                _service.Update(player);
            }
        }

        private void dataGridViewMatches_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewMatches.Rows[e.RowIndex];
            int matchId = Convert.ToInt32(row.Cells["columnMatchId"].Value);
            string columnName = dataGridViewMatches.Columns[e.ColumnIndex].Name;

            string updatedValue = Convert.ToString(row.Cells[e.ColumnIndex].Value);
            Match? match = _service.GetMatchById(matchId);
            if (match != null)
            {
                switch (columnName)
                {
                    case "columnFirstTeamGoals":
                        match.Team1Goals = int.Parse(updatedValue);
                        break;
                    case "columnSecondTeamGoals":
                        match.Team2Goals = int.Parse(updatedValue);
                        break;
                    case "columnMatchDate":
                        match.Date = Convert.ToDateTime(updatedValue);
                        break;
                    default:
                        break;
                }
                _service.Update(match);
            }
        }

        private void findToolStripMenuFind_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm(_service);
            findForm.ShowDialog();
            if (findForm.Choose == 1)
            {
                if (findForm.Team == null)
                {
                    MessageBox.Show("Nothing was found", "Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tabControlMain.SelectedIndex = 0;
                dataGridViewTeams.Rows.Clear();
                dataGridViewTeams.Columns[0].ReadOnly = true;

                dataGridViewTeams.Rows.Add(
                        findForm.Team.Id,
                        findForm.Team.Name,
                        findForm.Team.City,
                        findForm.Team.Victories,
                        findForm.Team.Loses,
                        findForm.Team.Draws,
                        findForm.Team.Goals,
                        findForm.Team.GoalsMissed
                    );
                MessageBox.Show($"Team was found", "Team", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (findForm.Choose == 2)
            {
                if (findForm.Matches == null)
                {
                    MessageBox.Show("Nothing was found", "Matches", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                tabControlMain.SelectedIndex = 2;
                dataGridViewMatches.Rows.Clear();
                dataGridViewMatches.Columns[0].ReadOnly = true;

                int count = 0;
                foreach (var m in findForm.Matches)
                {
                    Team? team1 = _service.GetTeamById(m.Team1Id);
                    Team? team2 = _service.GetTeamById(m.Team2Id);
                    dataGridViewMatches.Rows.Add(
                        m.Id,
                        team1.Name,
                        team2.Name,
                        m.Team1Goals,
                        m.Team2Goals,
                        m.Date
                    );
                    count++;
                }
                MessageBox.Show($"{count} matches was found", "Matches", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewPlayers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this player?", "Deleting Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewPlayers.Rows[e.Row.Index];
                int playerId = Convert.ToInt32(row.Cells["columnPlayerId"].Value);
                Player? player = _service.GetPlayerById(playerId);
                if (player != null)
                {
                    _service.Remove(player);
                    dataGridViewPlayers.Rows.RemoveAt(e.Row.Index);
                }
                else
                {
                    MessageBox.Show("Error while deleting player", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            e.Cancel = true;
        }

        private void dataGridViewMatches_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this match?", "Deleting Match", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridViewMatches.Rows[e.Row.Index];
                int matchId = Convert.ToInt32(row.Cells["columnMatchId"].Value);
                Match? match = _service.GetMatchById(matchId);
                if (match != null)
                {
                    _service.Remove(match);
                    dataGridViewMatches.Rows.RemoveAt(e.Row.Index);
                }
                else
                {
                    MessageBox.Show("Error while deleting match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            e.Cancel = true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if(tabControlMain.SelectedIndex == 0)
            {
                comboBoxTeams_SelectedIndexChanged(null, null);
            }
            else if(tabControlMain.SelectedIndex == 1)
            {
                comboBoxPlayers_SelectedIndexChanged(null, null);
            }
            else if (tabControlMain.SelectedIndex == 2)
            {
                comboBoxMatches_SelectedIndexChanged(null, null);
            }
        }
    }
}
