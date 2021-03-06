﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MLBFantasy.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public virtual ICollection<Player> Player { get; set; }

        public Team(string name, string logo, int id=0)
        {
            Name = name;
            Logo = logo;
            TeamId = id;
        }
        public Team() { }
    }
}
