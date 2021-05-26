using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using Portal.API.Context;
using Portal.API.EntityFramework.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Portal.API.GraphQL.Queries
{
    [Display(Name = "Queries para oc_vehiculo", Description = "Todas la consultas referentes a un vehiculo")]
    public class OcVehiculoQuery : IQuery<OcVehiculo>
    {
        [Authorize(Roles = new[] { "A" })]
        [UseProjection]
        [UseFiltering]
        [Display(Description = "Obtener todos los vehiculos")]
        public IEnumerable<OcVehiculo> GetAll([Service] AduasisContext _contexto)
        {
            return _contexto.OcVehiculo.AsQueryable();
        }
    }
}
