namespace HobbyDataLayer.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HobbyDataLayer.Models.HobbyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HobbyDataLayer.Models.HobbyDBContext context)
        {
            Person tom = new Person { Name = "Tom Sawyer", Age = "10", Address = "Timberland" };
            Person jake = new Person { Name = "Jake Saw", Age = "34", Address = "Kimberland" };

            Hobby cooking = new Hobby { Name = "Cooking" };
            Hobby reading = new Hobby { Name = "Reading" };
            Hobby riding = new Hobby { Name = "Horse Riding" };
            tom.Hobbies.Add(cooking);
            tom.Hobbies.Add(reading);
            tom.Hobbies.Add(riding);
            jake.Hobbies.Add(cooking);


            context.Hobbies.AddOrUpdate(cooking);
            context.Hobbies.AddOrUpdate(reading);
            context.Hobbies.AddOrUpdate(riding);
            context.Persons.AddOrUpdate(tom);
            context.Persons.AddOrUpdate(jake);
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
