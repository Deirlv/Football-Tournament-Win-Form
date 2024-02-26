using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTournament.DAL.Entities
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Country { get; set; }

        public int JerseyNumber { get; set; }

        [MaxLength(20)]
        public string Position { get; set; }

        public virtual Team? Team { get; set; }

        public int TeamId { get; set; }
    }
}
