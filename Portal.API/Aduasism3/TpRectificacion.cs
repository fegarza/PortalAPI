using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_rectificacion")]
    public partial class TpRectificacion
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public short IdRectificacion { get; set; }
        [Column("aduana_original")]
        public int AduanaOriginal { get; set; }
        [Column("aduana_despacho")]
        public int AduanaDespacho { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(6)]
        public string ClaveDocumento { get; set; }
        [Column("fecha_pago", TypeName = "datetime")]
        public DateTime? FechaPago { get; set; }
        [Column("pedimento_original")]
        public int? PedimentoOriginal { get; set; }
        [Column("patente_original")]
        public int? PatenteOriginal { get; set; }
        [Column("fecha_original", TypeName = "datetime")]
        public DateTime? FechaOriginal { get; set; }
    }
}
