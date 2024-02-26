using FootballTournament.DAL.Architecture;
using FootballTournament.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Tournament
{
    public partial class FindForm : Form
    {
        private Service _service;
        public Team? Team = null;
        public List<Match>? Matches = null;
        public int Choose = 0;

        public FindForm(Service service)
        {
            InitializeComponent();
            _service = service;
        }

        public FindForm()
        {
            InitializeComponent();
        }

        private void buttonFindTeam_Click(object sender, EventArgs e)
        {
            Team = _service.FindTeamName(textBoxNameFind.Text);
            Choose = 1;
            this.Close();
        }

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            Team? temp_team = _service.FindTeamName(Convert.ToString(comboBoxMatchFind.SelectedItem));
            Matches = _service.GetMatchesByTeam(temp_team.Id);
            Choose = 2;
            this.Close();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            AdditionalHelp.FillTeamComboBox(comboBoxMatchFind, _service);
        }
    }
}
