using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("farchivo_envio_factura")]
    public partial class FarchivoEnvioFactura
    {
        [Key]
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
    }
}
