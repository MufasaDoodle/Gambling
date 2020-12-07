using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gambling.Models;

namespace Gambling.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<ContestantVotes> ContestantVotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = file:Persistence/Database.db");
        }
    }
}
