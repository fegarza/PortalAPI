using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("farchivo_envio_ferrocarril")]
    public partial class FarchivoEnvioFerrocarril
    {
        [Key]
        [Column("fecha_ferrocarril", TypeName = "datetime")]
        public DateTime FechaFerrocarril { get; set; }
    }
}
