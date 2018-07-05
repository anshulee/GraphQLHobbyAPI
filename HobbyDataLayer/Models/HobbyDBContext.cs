using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDataLayer.Models
{
   public class HobbyDBContext:DbContext
    {
        public HobbyDBContext():base("HobbyDBEF")
        {
            Database.SetInitializer<HobbyDBContext>(new DatabaseInitializer());
        }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
