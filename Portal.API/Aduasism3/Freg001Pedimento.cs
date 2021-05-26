using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("freg001_pedimento")]
    public partial class Freg001Pedimento
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Column("numero_operacion")]
        public long? NumeroOperacion { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("partidas")]
        public int? Partidas { get; set; }
        [Column("remesas")]
        public int? Remesas { get; set; }
        [Column("subEstado")]
        [StringLength(1)]
        public string SubEstado { get; set; }
        [Column("subEstadoFecha")]
        [StringLength(1)]
        public string SubEstadoFecha { get; set; }
    }
}
