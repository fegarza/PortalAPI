using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fautorizacion_r1")]
    public partial class FautorizacionR1
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("id_usuario_r1")]
        [StringLength(6)]
        public string IdUsuarioR1 { get; set; }
        [Required]
        [Column("id_motivo")]
        [StringLength(6)]
        public string IdMotivo { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime FechaAutorizacion { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
    }
}
