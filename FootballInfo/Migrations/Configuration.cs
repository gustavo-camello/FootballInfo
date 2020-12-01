namespace FootballInfo.Migrations
{
    using FootballInfo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FootballInfo.Models.InfoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FootballInfo.Models.InfoContext";
        }

        protected override void Seed(FootballInfo.Models.InfoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var clubs = new List<Club>
            {
                new Club(){ClubId = 10, Name = "Club 1", Address = "Address 1"},
                new Club(){ClubId = 11, Name = "Club 2", Address = "Address 2"},
                new Club(){ClubId = 12, Name = "Club 3", Address = "Address 3"},
                new Club(){ClubId = 13, Name = "Club 4", Address = "Address 4"},
            };

            clubs.ForEach(c => context.Clubs.AddOrUpdate(c));

            context.SaveChanges();

            var players = new List<Player>
            {
                new Player()
                {
                    PlayerId = 1,
                    Name = "Gustavo Camello",
                    Age = 25,
                    Clubs = context.Clubs.Where(c => c.Name.Contains("Club")).ToList()
                }
            };

            players.ForEach(p => context.Players.AddOrUpdate(p));

            context.SaveChanges();
        }
    }
}
