using DataLayer;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
   public class PersonType:ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(x => x.PersonID).Description("Person Identifier");
            Field(x => x.Name).Description("Person Name");
            Field(x => x.Age).Description("Person Age");
            Field(x => x.Address, nullable:true).Description("Address");
            Field<ListGraphType<HobbyType>>("Hobbies", resolve: context => QueryResolver.GetHobbiesForPerson(context.Source.PersonID),description:"List of hobbies");
        }
    }
}
