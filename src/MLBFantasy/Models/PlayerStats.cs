using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MLBFantasy.Models
{
    [Table("PlayerStats")]
    public class PlayerStats
    {
        [Key]
        public int PlayerStatsId { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        public int StatsId { get; set; }
        public virtual Stats Stats { get; set; }
    }
}
