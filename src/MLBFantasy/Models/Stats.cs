using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MLBFantasy.Models
{
    [Table("Stats")]
    public class Stats
    {
        [Key]
        public int StatsId { get; set; }
        public int Runs { get; set; } 


        public virtual ICollection<PlayerStats> PlayerStats { get; set; } 
    }
}
