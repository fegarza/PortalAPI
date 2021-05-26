using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.API.GraphQL.Mutations
{
    public class RootMutation 
    {
        public LoginMutation LoginMutation => new();
    }
}
