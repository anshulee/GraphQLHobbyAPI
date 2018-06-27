using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DBManager
    {
        public List<Hobby> GetHobbiesForPerson(int personID)
        {
            HobbyDBEntities dbContext = new HobbyDBEntities();
            List<Hobby> hobbyList = (from mapper in dbContext.PersonHobbyMappers
                                     where mapper.PersonID == personID
                                     select mapper.Hobby).ToList();
            return hobbyList;
        }

        public Person GetPerson(int personID)
        {
            HobbyDBEntities dbContext = new HobbyDBEntities();
            return dbContext.People.Where(x => x.PersonID == personID).FirstOrDefault();
        }

        public Hobby GetHobby(int hobbyID)
        {
            HobbyDBEntities dbContext = new HobbyDBEntities();
            return dbContext.Hobbies.Where(x => x.HobbyID == hobbyID).FirstOrDefault();
        }

        public Hobby AddHobby(Hobby hobby)
        {
            HobbyDBEntities dbContext = new HobbyDBEntities();
            dbContext.Hobbies.Add(hobby);
            dbContext.SaveChanges();
            return hobby;
        }
    }
}
