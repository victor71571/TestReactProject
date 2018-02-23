namespace prjTask.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using prjTask.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<prjTask.Models.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(prjTask.Models.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Persons.AddOrUpdate(x => x.Id,
               new Person { Id = 1, Name = "name1", Age = 22, Gender = "Male" },
               new Person { Id = 2, Name = "name2", Age = 23, Gender = "Male" },
               new Person { Id = 3, Name = "name13", Age = 24, Gender = "Male" },
               new Person { Id = 4, Name = "name32", Age = 12, Gender = "Male" }


               );
        }
    }
}
