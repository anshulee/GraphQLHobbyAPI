using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
   public class HobbyInputType: InputObjectGraphType
    {
        public HobbyInputType()
        {
            Name = "HobbyInput";
            Field<NonNullGraphType<StringGraphType>>("name");
           
            

        }
    }
}
