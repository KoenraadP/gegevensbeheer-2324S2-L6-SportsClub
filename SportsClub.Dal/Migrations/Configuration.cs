namespace SportsClub.Dal.Migrations
{
    using SportsClub.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsClub.Dal.SportsClubDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsClub.Dal.SportsClubDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // test members toevoegen aan db
            context.Members.AddOrUpdate(x => new {x.FirstName, x.LastName},
                new Member("Vince","Iserniet"),
                new Member("Moestie","Iserookniet"));

            // test activiteiten toevoegen aan db
            context.Activities.AddOrUpdate(x => x.Name,
                new Activity("Voetbal", 30),
                new Activity("Volleybal", 20));
        }
    }
}
