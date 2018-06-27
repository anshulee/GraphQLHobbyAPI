using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer
{
    public class QueryResolver
    {
        public static List<Hobby> GetHobbiesForPerson(int personID)
        {
            DBManager manager = new DBManager();
            return manager.GetHobbiesForPerson(personID);

        }

        public static Person GetPerson(int personID)
        {
            DBManager manager = new DBManager();
            return manager.GetPerson(personID);
        }
    }
}
