namespace Videos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Videos.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Videos.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Videos.Models.VideoDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Videos.AddOrUpdate(
             v => v.Title,
              new Video() {Title="MVC",Length=12},
              new Video() { Title="LINQ", Length=6}
            );

            context.SaveChanges();
            
        }
    }
}
