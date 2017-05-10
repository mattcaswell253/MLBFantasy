using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MLBFantasy.Models
{
    public class MLBContext : IdentityDbContext<User>
    {
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Stats> Stats { get; set; }
        public virtual DbSet<Team> Teams { get; set;}
        public virtual DbSet<PlayerStats> PlayerStats { get; set; }
        public MLBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MLBFantasy;integrated security = True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<PlayerStats>().HasKey(x => new { x.PlayerId, x.StatsId });
        }
    }
}
