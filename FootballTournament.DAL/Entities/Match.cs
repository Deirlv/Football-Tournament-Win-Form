using System.ComponentModel.DataAnnotations;

namespace FootballTournament.DAL.Entities
{
    public class Match
    {
        public int Id { get; set; }

        public int Team1Id { get; set; }

        public virtual Team Team1 { get; set; }

        public int Team2Id { get; set; }

        public virtual Team Team2 { get; set; }

        public int Team1Goals { get; set; }

        public int Team2Goals { get; set; }

        [Required]
        public DateTime Date { get; set; }

    }
}
