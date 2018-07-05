using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDataLayer.Models
{
   public class DatabaseInitializer: CreateDatabaseIfNotExists<HobbyDBContext>
    {
        protected override void Seed(HobbyDBContext context)
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
            base.Seed(context);

        }
    }
}
