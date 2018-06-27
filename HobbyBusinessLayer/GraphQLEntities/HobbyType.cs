using DataLayer;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
   public  class HobbyType:ObjectGraphType<Hobby>
    {
        public HobbyType()
        {
            Field(x => x.HobbyID).Description("Hobby ID");
            Field(x => x.Name).Description("Hobby Name");
            Field("PopularityCount", x=>x.PersonHobbyMappers.Count, nullable:true).Description("Count of people with this hobby");
        }

    }
}
