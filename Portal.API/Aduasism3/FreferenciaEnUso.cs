using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("freferencia_en_uso")]
    public partial class FreferenciaEnUso
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(50)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("id_usuario")]
        [StringLength(10)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_libero")]
        [StringLength(10)]
        public string IdUsuarioLibero { get; set; }
        [Column("fecha_libero", TypeName = "datetime")]
        public DateTime? FechaLibero { get; set; }
    }
}
