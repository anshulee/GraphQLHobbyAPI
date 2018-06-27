using DataLayer;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
   public class HobbyMutation : ObjectGraphType<object>
    {
        public HobbyMutation()
        {
            Name = "CreateHobbyMutation";
            Field<HobbyType>(
                  "createHobby",
                  arguments: new QueryArguments(
                  new QueryArgument<NonNullGraphType<HobbyInputType>> { Name = "hobby" }
            ),
            resolve: context =>
            {

                var hobby = context.GetArgument<Hobby>("hobby");
                return QueryResolver.AddHobby(hobby);
            });

        }
    }
}
