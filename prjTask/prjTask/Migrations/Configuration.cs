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
               new Person { Id = 5, Name = "Victor", Age = 22, Gender = "Male" },
               new Person { Id = 6, Name = "Olha", Age = 23, Gender = "Female" },
               new Person { Id = 7, Name = "Andrew", Age = 24, Gender = "Male" },
               new Person { Id = 8, Name = "Max", Age = 12, Gender = "Male" }


               );
        }
    }
}
