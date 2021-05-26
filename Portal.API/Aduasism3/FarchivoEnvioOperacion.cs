using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("farchivo_envio_operacion")]
    public partial class FarchivoEnvioOperacion
    {
        [Key]
        [Column("fecha_operacion", TypeName = "datetime")]
        public DateTime FechaOperacion { get; set; }
    }
}
