
using GraphQL.Types;
using HobbyDataLayer.Models;
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
            Field<IntGraphType>("PopularityCount", resolve: context => QueryResolver.GetPopularityCountForHobby(context.Source.HobbyID), description: "Count of people with this hobby");
        }

    }
}
