using System.ComponentModel.DataAnnotations;

namespace FootballTournament.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string City { get; set; }

        public int Victories { get; set; }

        public int Loses { get; set; }

        public int Draws { get; set; }
        public int Goals { get; set; }

        public int GoalsMissed { get; set; }

        public virtual List<Player> Players { get; set; }

        public virtual List<Match>? Matches { get; set; }

    }
}