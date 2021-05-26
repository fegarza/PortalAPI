using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using Portal.API.Context;
using Portal.API.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Portal.API.GraphQL.Queries
{
    [Display(Name = "WebUsuairo", Description = "Todo lo referente a los usuarios del sistema")]
    public class WebUsuarioQuery
    {
        [Authorize(Roles = new[]{ "A" })]
        [UseProjection]
        [UseFiltering]
        [Display(Description = "Obtener todos los usuarios")]
        public IEnumerable<WebUsuario> GetAllWebUsuarios([Service] AduasisContext _contexto)
        {
            return _contexto.WebUsuarios.AsQueryable();
        }

       
       
    }
}
