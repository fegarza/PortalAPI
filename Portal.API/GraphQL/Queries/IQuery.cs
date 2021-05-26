using Microsoft.EntityFrameworkCore;
using Portal.API.Context;
using System.Collections.Generic;

namespace Portal.API.GraphQL.Queries
{
    interface IQuery<T>
    {
        IEnumerable<T> GetAll(AduasisContext contexto);
    }
}
