using DataLayer;
using HobbyDataLayer.Models;
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
        public static int GetPopularityCountForHobby(int hobbyID)
        {
            DBManager manager = new DBManager();
            return manager.GetCountOfPeopleInterestedInHobby(hobbyID);
        }

        public static Person GetPerson(int personID)
        {
            DBManager manager = new DBManager();
            return manager.GetPerson(personID);
        }
        public static Hobby GetHobby(int hobbyID)
        {
            DBManager manager = new DBManager();
            return manager.GetHobby(hobbyID);
        }

        internal static Hobby AddHobby(Hobby hobby)
        {
            DBManager manager = new DBManager();
            return manager.AddHobby(hobby);
        }
    }
}
