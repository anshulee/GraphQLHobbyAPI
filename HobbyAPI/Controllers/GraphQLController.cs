using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using HobbyBusinessLayer.GraphQLEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace HobbyAPI.Controllers
{
    [Route("graphql")]
    public class GraphQLController : ApiController
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        private readonly IDocumentWriter _writer;
        private readonly IDictionary<string, string> _namedQueries;
        public OkResult Options()
        {

            return Ok();
        }
        [System.Web.Mvc.HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = new HobbyQuery()};
            var inputs = query.Variables.ToInputs();
            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Inputs = inputs;
                _.Schema = schema;
                _.Query = query.Query;

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}