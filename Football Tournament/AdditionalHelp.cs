using FootballTournament.DAL.Architecture;
using FootballTournament.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Tournament
{
    public static class AdditionalHelp
    {
        static public void FillTeamComboBox(ComboBox comboBox, Service _service)
        {
            List<Team> teams = _service.GetAllTeams();

            comboBox.Items.Clear();

            foreach (Team team in teams)
            {
                comboBox.Items.Add(team.Name);
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
    }
}
