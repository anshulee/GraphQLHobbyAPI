using HobbyDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyDataLayer
{
    public class DBManager
    {
        public List<Hobby> GetHobbiesForPerson(int personID)
        {
            HobbyDBContext dbContext = new HobbyDBContext();
            var hobbies = dbContext.Persons.Include("Hobbies").Where(p => p.PersonID == personID).Select(p => p.Hobbies).FirstOrDefault();
           ;
            return hobbies.ToList();
        }

        public int GetCountOfPeopleInterestedInHobby(int hobbyID)
        {
            HobbyDBContext dbContext = new HobbyDBContext();
            return dbContext.Hobbies.Include("Hobbies").Where(h => h.HobbyID == hobbyID).Select(h => h.People).FirstOrDefault().Count();
        }
        public Person GetPerson(int personID)
        {
            HobbyDBContext dbContext = new HobbyDBContext();
            return dbContext.Persons.Where(x => x.PersonID == personID).FirstOrDefault();
        }

        public Hobby GetHobby(int hobbyID)
        {
            HobbyDBContext dbContext = new HobbyDBContext();
            return dbContext.Hobbies.Where(x => x.HobbyID == hobbyID).FirstOrDefault();
        }

        public Hobby AddHobby(Hobby hobby)
        {
            HobbyDBContext dbContext = new HobbyDBContext();
            dbContext.Hobbies.Add(hobby);
            dbContext.SaveChanges();
            return hobby;
        }
    }
}
