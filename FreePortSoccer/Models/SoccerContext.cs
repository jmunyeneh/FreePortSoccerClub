using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Models
{
    public class SoccerContext: DbContext
    {
        public SoccerContext(DbContextOptions<SoccerContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<News> News { get; set; }
    }
}
