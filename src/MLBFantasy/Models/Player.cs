using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MLBFantasy.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }


        public virtual ICollection<PlayerStats> PlaterStats { get; set; }
    }
}
