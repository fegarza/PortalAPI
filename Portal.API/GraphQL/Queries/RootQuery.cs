using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.GraphQL.Queries
{
    public class RootQuery 
    {
        public WebUsuarioQuery WebUsuarioQuery => new();
   
    }
}
