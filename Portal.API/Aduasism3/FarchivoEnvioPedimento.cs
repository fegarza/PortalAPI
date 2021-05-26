using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("farchivo_envio_pedimentos")]
    public partial class FarchivoEnvioPedimento
    {
        [Key]
        [Column("fecha_pedimento", TypeName = "datetime")]
        public DateTime FechaPedimento { get; set; }
    }
}
