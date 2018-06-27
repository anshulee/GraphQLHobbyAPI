using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
    public class HobbyQuery : ObjectGraphType
    {
        public HobbyQuery()

        {
            Field<PersonType>("person",
                  arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                  resolve: context => QueryResolver.GetPerson(context.GetArgument<int>("id")));
            Field<HobbyType>("hobby",
                 arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                 resolve: context => QueryResolver.GetHobby(context.GetArgument<int>("id")));

        }
    }
}
