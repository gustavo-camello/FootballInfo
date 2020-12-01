using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootballInfo.Models
{
    public class InfoContext:DbContext
    {
        public InfoContext() : base("InfoContext")
        {

        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}