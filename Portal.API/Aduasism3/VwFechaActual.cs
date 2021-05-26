using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class VwFechaActual
    {
        [Column("fecha", TypeName = "datetime")]
        public DateTime Fecha { get; set; }
    }
}
