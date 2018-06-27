using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobbyBusinessLayer.GraphQLEntities
{
    public class HobbyQuerySchema:Schema
    {
        public HobbyQuerySchema(IDependencyResolver resolve)
        {
            Query = resolve.Resolve<HobbyQuery>();
        }
    }
}
